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
                if (line != null)
                {
                    string[] parts = line.Split(',');
                    dataGridView1.ColumnCount = parts.Length;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, parts);
                    dataGridView1.Rows.Add(row);
                }
            }
        }
    }
}
