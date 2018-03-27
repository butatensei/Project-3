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
            barChart.Series[0].Points.Clear(); //clear the chart for starters
            /*
            * TODO: SCALABILITY
            * INSTEAD OF DEFININING THE QUERY IN HERE, WE SHOULD MAKE EVERY BIT VARIABLE
            * AND COMBINE A BUNCH OF PASSED VARIABLES FROM THE BUTTONS
            * AND BUILD OUR QUERY OUT OF THAT!
            */
            //set up variables for use in our looped checks...
            int myPrecipitationMode = MasterChartConfig.PrecipitationMode;
            bool mySubgroupData = MasterChartConfig.SubGroupData;
            string myTable;
            int myTotalCount = 0;
            string space = " ";

            if (mySubgroupData)
            {
                myTable = "fietsendiefstal";
            }
            else
            {
                myTable = "straatroof";
            }
            //Loop through all days
            for (int i = 1; i <= 365; i++)
            {
                string myDay = Convert.ToString(i);
                //write query that gets weather data and checks it with primary data
                //Going to have to write a new function in DBConnect that doesn't use count, but returns tuples.
                string myCountQuery = "SELECT COUNT(ID) from " + myTable + " WHERE Dag=" + myDay;
                Console.WriteLine(myCountQuery);
                Console.WriteLine(i);
                int myCountResult = myConnection.Count(myCountQuery);
                Console.WriteLine(myCountResult);
                int myTemp = 5; //temp magic number
                myTotalCount = myTotalCount + myCountResult;
                barChart.Series[0].Points.AddXY(i, myCountResult);
            }
            Console.WriteLine("SETTINGS USED:" + "PRECIP MODE " + myPrecipitationMode + " " + "TABLE " + myTable);
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

        
        private void NeerslagDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This dropdown is now obsolete due to the IntegerButtonPressed() function.
            MasterChartConfig.PrecipitationMode = NeerslagDropdown.SelectedIndex;
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
            myConnection.dbSELECT("Select count(ID), TemperatuurGem From straatroof, weer Where straatroof.Dag = weer.Dag and straatroof.Maand = weer.Maand and straatroof.Jaar = weer.Jaar and TemperatuurGem is not null Group by TemperatuurGem");
        }

        private void Visualize_Load(object sender, EventArgs e)
        {

        }
    }
}
