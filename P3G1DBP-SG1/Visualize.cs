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
            myConnection.update();
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

        public void updateChart()
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
                // write query that gets weather data and checks it with primary data
                string myCountQuery = "SELECT COUNT(Dag) from " + myTable + " WHERE Dag=" + myDay;
                Console.WriteLine(myCountQuery);
                Console.WriteLine(i);
                int myCountResult = myConnection.Count(myCountQuery);
                Console.WriteLine(myCountResult);
                int myTemp = 5; //temp magic number
                myTotalCount = myTotalCount + myCountResult;
                barChart.Series[0].Points.AddXY(i, myCountResult);
            }
            Console.WriteLine("SETTINGS USED:" + "PRECIP MODE " + myPrecipitationMode + " " + "TABLE USED:" + myTable);
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            /*
             * TODO:
             * ADD FUNCTIONALITY
             * 
             * THIS BUTTON SHOULD ENABLE THE 'WEATHER' FILTER IN THREE MODES
             * 
             * MODE 1: ALWAYS ON
             * THIS IS THE DEFAULT MODE
             * THIS SHOWS THE THEFTS DURING BAD WEATHER IN THE NORMAL BAR
             * THE BUTTON SHOULD LOOK NORMAL
             * 
             * MODE 2: HIGHLIGHT
             * THIS SHOWS THE THEFTS DURING BAD WEATHER WITH A RED HIGHLIGHT ON TOP OF A NORMAL BAR
             * THE BUTTON SHOULD LOOK HIGHLIGHTED, POSSIBLY BLUE?
             * 
             * MODE 3: FILTER
             * THIS FILTERS THE THEFTS DURING BAD WEATHER FROM THE BAR, REDUCING IT
             * THE BUTTON SHOULD LOOK DISABLED, POSSIBLY CROSSED OUT OR RED
            */
        }

        private void NeerslagDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            MasterChartConfig.PrecipitationMode = NeerslagDropdown.SelectedIndex;
        }
    }
}
