using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSVApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IEnumerable<string> lines = File.ReadLines("Input.csv");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                DataGridViewRow row = new DataGridViewRow();
                
            }

            

        }
    }
}
