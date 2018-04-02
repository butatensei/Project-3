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
            GroepeerBox.SelectedItem = 5;
            GroepeerBox.Text = "5";
        }


        private void maandButton_Click(object sender, EventArgs e)
        {
            updateChart();
        }

        public bool updateChart()
        {
            FlipEnabledAllButtons();
            string space = " ";
            //clear the chart for starters
            barChart.Series[0].Points.Clear(); 
            barChart.Series[1].Points.Clear();
            barChart.Series[2].Points.Clear();
            barChart.Series[3].Points.Clear();
            Console.WriteLine("***********************");
            //moved query to master chart config class
            string myQuery = MasterChartConfig.BuildQuery(); // get proper query from master config
            Console.WriteLine(myQuery); //debug
            List<DBConnect.CountTemp> myCountResult = myConnection.DBselect(myQuery); //exec query
            Console.WriteLine(myCountResult); //debug, query results

            //I'm trying to set up the list we need to toss the vars in to make the bars work
            List<int> [] myHoldingList = new List<int>[3];
            myHoldingList[0] = new List<int>();
            myHoldingList[1] = new List<int>();
            myHoldingList[2] = new List<int>();

            foreach (var mylistEntry in myCountResult) //loop through query results
            {
                int TempGemround = mylistEntry.TempGem;
                int RoundNumber = Convert.ToInt32(GroepeerBox.SelectedItem) * 10;
                TempGemround = Convert.ToInt32(Math.Round(TempGemround / (RoundNumber * 1.0)) * RoundNumber);

                /*
                if (MasterChartConfig.PrecipitationMode == 1 && mylistEntry.Neerslag != 0)
                {
                    if (MasterChartConfig.RainMode == 1 && mylistEntry.Regen) { Console.WriteLine("RAIN" + mylistEntry.Count); barChart.Series[2].Points.AddXY(TempGemround / 10, mylistEntry.Count); }
                    else if (mylistEntry.Neerslag != 0) { Console.WriteLine("NEERSLAG" + mylistEntry.Count); barChart.Series[1].Points.AddXY(TempGemround / 10, mylistEntry.Count); }
                    if (MasterChartConfig.SnowMode == 1 && mylistEntry.Sneeuw) { Console.WriteLine("SNOW" + mylistEntry.Count); barChart.Series[3].Points.AddXY(TempGemround / 10, mylistEntry.Count); }
                    else if (mylistEntry.Neerslag != 0) { Console.WriteLine("NEERSLAG" + mylistEntry.Count); barChart.Series[1].Points.AddXY(TempGemround / 10, mylistEntry.Count); }
                }
                else { Console.WriteLine("st" + space +  mylistEntry.Count + space + mylistEntry.Neerslag + space + mylistEntry.Regen + mylistEntry.Sneeuw); barChart.Series[0].Points.AddXY(TempGemround / 10, mylistEntry.Count); }
                //barChart.Series[0].Points.AddXY(TempGemround / 10, mylistEntry.Count);*/
                /*if (MasterChartConfig.PrecipitationMode == 1 && mylistEntry.Neerslag != 0)
                {
                    if (MasterChartConfig.RainMode == 1 && mylistEntry.Regen) { myHoldingList[2].Add(mylistEntry.Count); }
                    else if (mylistEntry.Neerslag != 0) { myHoldingList[1].Add(mylistEntry.Count); }
                    if (MasterChartConfig.SnowMode == 1 && mylistEntry.Sneeuw) { myHoldingList[3].Add(mylistEntry.Count); }
                    else if (mylistEntry.Neerslag != 0) { myHoldingList[1].Add(mylistEntry.Count); }
                }
                else { myHoldingList[0].Add(mylistEntry.Count); }*/
                if (MasterChartConfig.PrecipitationMode == 1 && mylistEntry.Neerslag != 0)
                {
                    if (MasterChartConfig.RainMode == 1 && mylistEntry.Regen) { myHoldingList[2][2] = myHoldingList[2][2] + mylistEntry.Count; }
                    else if (mylistEntry.Neerslag != 0) { myHoldingList[1][1] = myHoldingList[1][1] + mylistEntry.Count; }
                    if (MasterChartConfig.SnowMode == 1 && mylistEntry.Sneeuw) { myHoldingList[3][3] = myHoldingList[3][3] + mylistEntry.Count; }
                    else if (mylistEntry.Neerslag != 0) { myHoldingList[1][1] = myHoldingList[1][1] + mylistEntry.Count; }
                }
                else { myHoldingList[0].Add(mylistEntry.Count); }
                myHoldingList[0][0] = myHoldingList[0][0] + mylistEntry.Count;
            }
            /*
             * IF 
             * 
             */
            foreach (var myListEntry in myHoldingList)
                Console.WriteLine(myHoldingList[0][0]);
                barChart.Series[0].Points.AddXY(50 / 10, myHoldingList[0]);
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

            if (passedVariable < 2)
            {
                passedVariable++;
                if (passedVariable == 1)
                {
                    passedButton.ForeColor = System.Drawing.Color.DodgerBlue;
                }
                else
                {
                    passedButton.ForeColor = System.Drawing.Color.DarkRed;
                }
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
            }
            else //false, fietsendiefstal
            {
                SubGroupButton.Text = "🚲";
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
