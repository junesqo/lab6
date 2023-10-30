using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add("Record" + i.ToString());
                // Items property to store a collection of strings, 
                // the Add function adds an object in this case a string
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sArayItems = {"Excellent", "Good",
            "Satisfactory", "Unsatisfactory"};
            // array of strings
            listBox1.Items.Clear(); // clear the Items property
            for (int i = 0; i < sArayItems.GetLength(0); i++) // view the array
            {
                // Add an item to the listbox collection
                listBox1.Items.Add(sArayItems[i]);
            }

        }
    }
}
