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
            int myInt = myConnection.Count("SELECT COUNT(ID) from fietsendiefstal WHERE Jaar=2011&&Maand=1");
            //Okay, this one worked! Cool. Now... maybe we can loop through it.


            // var myQuery = myConnection.GetStringList("select ID, count(ID) from p3g1.fietsendiefstal where Jaar='2011'");
            //int myCount = myConnection.Count("SELECT `ID`, COUNT(*) from p3g1.fietsendiefstal WHERE Jaar='2011'");
            barChart.Series[0].Points.AddXY(0,myInt);
            //Fill the chart with data from the list entries.
            /*foreach (int element in myCount)
            {
                Console.WriteLine("element{0}");
                barChart.Series[0].Points.AddXY(element[0], element[0]);
            }*/

        }
    }
}
