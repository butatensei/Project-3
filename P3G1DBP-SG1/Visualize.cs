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

namespace Project3Groep1
{
    public partial class Visualize : Form
    {
        DBConnect myConnection = new DBConnect();
        public Visualize()
        {
            InitializeComponent();
            myConnection.update();
        }

        private void maandButton_Click(object sender, EventArgs e)
        {
            //MaandButton.Text = "MAAND";
            updateChart();
        }

        public void updateChart()
        {
            barChart.Series[0].Points.Clear();
            //barChart.Series[0].Name = "FIETSENDIEFSTALLEN";

            /*
             * TODO: SCALABILITY
             * INSTEAD OF DEFININING THE QUERY IN HERE, WE SHOULD MAKE EVERY BIT VARIABLE
             * AND COMBINE A BUNCH OF PASSED VARIABLES FROM THE BUTTONS
             * AND BUILD OUR QUERY OUT OF THAT!
            */

            //Loop through the 12 months of 2011, add every iteration as a bar
            for (int i = 1; i <= 12; i++)
            {
                string myMonth = Convert.ToString(i);
                string myCountQuery = "SELECT COUNT(ID) from fietsendiefstal WHERE Jaar=2011&&Maand=" + myMonth;
                int myCountResult = myConnection.Count(myCountQuery);
                barChart.Series[0].Points.AddXY(i, myCountResult);
            }
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            /*
             * TODO:
             * ADD FUNCTIONALITY
             * THIS BUTTON SHOULD ENABLE THE 'WEATHER' FILTER
             * THIS FILTER SHOWS THE TOP PART OF THE BAR PER MONTH/WEEK IN RED
             * TO INDICATE HOW MUCH OF THE BAR IS CHANGED DURING BAD WEATHER(?)
             * WE WILL HAVE TO PERFORM A MORE COMPLEX QUERY FOR THIS
            */
        }
    }
}
