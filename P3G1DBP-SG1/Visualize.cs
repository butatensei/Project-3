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

        private void button1_Click(object sender, EventArgs e)
        {
            //int myInt = myConnection.Count("SELECT Count(*) FROM fietsendiefstal");
            //string myText = myInt.ToString();
            testButton.Text = "Update";
            updateChart();
        }

        public void updateChart()
        {
            barChart.Series[0].Points.Clear();
            barChart.Series[0].Name = "FIETSENDIEFSTALLEN";

            //Okay, this one worked! Cool. Now... maybe we can loop through it.
            for (int i = 1; i <= 12; i++)
            {
                string myMonth = Convert.ToString(i);
                string myCountQuery = "SELECT COUNT(ID) from fietsendiefstal WHERE Jaar=2011&&Maand=" + myMonth;
                int myCountResult = myConnection.Count(myCountQuery);
                barChart.Series[0].Points.AddXY(i, myCountResult);
            }
        }
    }
}
