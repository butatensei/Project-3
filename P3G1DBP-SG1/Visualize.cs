using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Project3Groep1
{
    public partial class Visualize : Form
    {
        DBConnect myConnection = new DBConnect();
        /// <summary>
        /// The master config class used to store all our variables
        /// </summary>
        ChartConfig MasterChartConfig = new ChartConfig();
        public Visualize()
        {
            InitializeComponent();
            myConnection.updateDatabase();
            this.Text = "Fietsendiefstal & het weer";
            updateChart();
        }


        private void maandButton_Click(object sender, EventArgs e)
        {
            updateChart();
        }

        public bool updateChart()
        {
            FlipEnabledAllButtons();
            barChart.Series[0].Points.Clear(); //clear the chart for starters
            //moved query to master chart config class
            string myQuery = MasterChartConfig.BuildQuery(); // get proper query from master config
            Console.WriteLine(myQuery); //debug
            List<DBConnect.CountTemp> myCountResult = myConnection.DBselect(myQuery); //exec query
            Console.WriteLine(myCountResult); //debug, query results
            foreach (var mylistEntry in myCountResult) //loop through query results
            {
                int TempGemround = mylistEntry.TempGem;
                int RoundNumber = Convert.ToInt32(1) * 10;
                TempGemround = Convert.ToInt32(Math.Round(TempGemround / (RoundNumber * 1.0)) * RoundNumber);
                //barChart.Series[0].Points.AddXY(TempGemround / 10, mylistEntry.Count);
                barChart.Series[0].Points.AddXY(TempGemround / 10, mylistEntry.Count);
            }
            Console.WriteLine("SETTINGS USED:" + "PRECIP MODE " + MasterChartConfig.PrecipitationMode + " " + "TABLE " + MasterChartConfig.SubGroupData);
            FlipEnabledAllButtons();
            return true;
        }

        /// <summary>
        /// Integer button that increments related variable and re-colors the button
        /// </summary>
        /// <param name="passedVariable">Variable from the master config relating to the button pressed</param>
        /// <param name="passedButton">the object of the button being pressed</param>
        /// <returns>integer, changed passedVariable</returns>
        public int ChangeButtonInteger(int passedVariable, Button passedButton)
        {
            /*
             * TODO:
             * COMPLETE FUNCTIONALITY
             * 
             * THIS FUNCTION SHOULD ENABLE A FILTER IN THREE MODES
             * 
             * MODE 1: ALWAYS ON
             * THIS IS THE DEFAULT MODE
             * THIS SHOWS THE THEFTS DURING BAD WEATHER IN THE NORMAL COLUMN
             * THE BUTTON SHOULD LOOK NORMAL
             * 
             * MODE 2: HIGHLIGHT
             * THIS SHOWS THE THEFTS DURING BAD WEATHER WITH A RED HIGHLIGHT ON TOP OF A NORMAL COLUMN
             * THE BUTTON SHOULD LOOK HIGHLIGHTED, POSSIBLY BLUE?
             * 
             * MODE 3: FILTER
             * THIS FILTERS THE THEFTS DURING BAD WEATHER FROM THE COLUMN, REDUCING IT
             * THE BUTTON SHOULD LOOK DISABLED, POSSIBLY CROSSED OUT OR RED
            */

            if (passedVariable < 1)
            {
                passedVariable++;
                passedButton.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                passedVariable = 0;
                passedButton.ForeColor = System.Drawing.Color.Black;
            }

            //We pressed a button, so update the chart!
            return passedVariable;
        }

        /// <summary>
        /// Returns a list of controls (buttons)
        /// </summary>
        /// <param name="c"></param>
        /// <param name="list"></param>
        public void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control, list);
            }
        }

        /// <summary>
        /// Flips 'enabled' property of all buttons, causing UI to grey out or re-color
        /// </summary>
        public void FlipEnabledAllButtons()
        {
            List<Control> AllButtons = new List<Control>();

            GetAllControl(this, AllButtons);

            foreach (Control control in AllButtons)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Enabled = !control.Enabled;
                }
            }
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            //This calls the generic button function, less copypasta.
            MasterChartConfig.PrecipitationMode = ChangeButtonInteger(MasterChartConfig.PrecipitationMode, WeatherButton);
            updateChart();
        }

        private void RainButton_Click(object sender, EventArgs e)
        {
            MasterChartConfig.RainMode = ChangeButtonInteger(MasterChartConfig.RainMode, RainButton);
            updateChart();
        }

        private void FrostButton_Click(object sender, EventArgs e)
        {
            MasterChartConfig.SnowMode = ChangeButtonInteger(MasterChartConfig.SnowMode, FrostButton);
            updateChart();
        }

        private void sunButton_Click(object sender, EventArgs e)
        {
            MasterChartConfig.SunMode = ChangeButtonInteger(MasterChartConfig.SunMode, sunButton);
            updateChart();
        }

        private void SubGroupButton_Click(object sender, EventArgs e) //This one's seperate because it's not an int, but a bool!
        {
            MasterChartConfig.SubGroupData = !MasterChartConfig.SubGroupData; //Flip the bool.
            if (MasterChartConfig.SubGroupData) //true, straatroof
            {
                SubGroupButton.Text = "💰";
                barChart.Series[0].Name = "Straatroof";
                this.Text = "Straatroof & het weer";
                labelY.Text = "straatroven";
            }
            else //false, fietsendiefstal
            {
                SubGroupButton.Text = "🚲";
                barChart.Series[0].Name = "Fietsendiefstal";
                this.Text = "Fietsendiefstal & het weer";
                labelY.Text = "fietsendiefstallen";
            }

            updateChart(); //We pressed a button, so update the chart!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("hello");
            updateChart();
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
