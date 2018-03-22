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
        DBConnect DBConnect;
        DBConnect myConnection = new DBConnect();
        public Visualize()
        {
            InitializeComponent();
            myConnection.update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myInt = myConnection.Count();
            string myText = myInt.ToString();
            testButton.Text = myText;
        }
    }
}
