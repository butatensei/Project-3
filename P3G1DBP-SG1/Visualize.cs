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
        }

        private void maandButton_Click(object sender, EventArgs e)
        {
            //MaandButton.Text = "MAAND";
            /*
             * TODO: PASS MONTH MODE TO UPDATECHART()
             * INSTEAD OF MAKING IT DO EVERYTHING
            */
            updateChart();
        }

        public bool updateChart()
        {
            FlipEnabledAllButtons();
            barChart.Series[0].Points.Clear(); //clear the chart for starters
            /*
            * TODO: SCALABILITY
            * INSTEAD OF DEFININING THE QUERY IN HERE, WE SHOULD MAKE EVERY BIT VARIABLE
            * AND COMBINE A BUNCH OF PASSED VARIABLES FROM THE BUTTONS
            * AND BUILD OUR QUERY OUT OF THAT!
            */
            //set up variables for use in our looped checks...
            int myPrecipitationMode = MasterChartConfig.PrecipitationMode;
            int mySunMode = MasterChartConfig.SunMode;
            bool mySubgroupData = MasterChartConfig.SubGroupData;
            string myTable;

            if (mySubgroupData)
            {
                myTable = "fietsendiefstal";
            }
            else
            {
                myTable = "straatroof";
            }
            
            //Loop through all the entries

            /* 
             * query that uses the table assigned above to select where the data will come from
             * bit hard to read due to all the +es but it beats having one massive line
             */
            string myQuery =
                    "Select count(ID), TemperatuurGem " +
                    "From "+myTable+", weer " +
                    "Where " + myTable + ".Dag = weer.Dag and " +
                    "" + myTable + ".Maand = weer.Maand and " +
                    "" + myTable + ".Jaar = weer.Jaar and TemperatuurGem is not null " +
                    "Group by TemperatuurGem;";
            Console.WriteLine(myQuery);
            List<DBConnect.CountTemp> myCountResult = myConnection.DBselect(myQuery);
            Console.WriteLine(myCountResult);
            foreach (var mylistEntry in myCountResult)
            {
                //write query that gets weather data and checks it with primary data
                //Going to have to write a new function in DBConnect that doesn't use count, but returns tuples.
                //string myCountQuery = "SELECT COUNT(ID) from " + myTable + " WHERE Dag=" + myDay;
                barChart.Series[0].Points.AddXY(mylistEntry.TempGem / 10, mylistEntry.Count);
            }
            Console.WriteLine("SETTINGS USED:" + "PRECIP MODE " + myPrecipitationMode + " " + "TABLE " + myTable);
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
        /// Flips 'enabled' property of a button
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
            }
            else //false, fietsendiefstal
            {
                SubGroupButton.Text = "🚲";
                barChart.Series[0].Name = "Fietsendiefstal";
            }

            updateChart(); //We pressed a button, so update the chart!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("hello");
            updateChart();
        }
    }
}
