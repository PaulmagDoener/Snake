using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        bool unten, oben, links, rechts;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (radioButton1.Checked)
                timer1.Interval = 1500;

            else if (radioButton2.Checked)
                timer1.Interval = 1000;

            else if (radioButton3.Checked)
                timer1.Interval = 500;

            groupBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void feld_Paint(object sender, PaintEventArgs e)
        {

        }

        private void head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (unten)
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head), feld.GetRow(head) + 1));

            if (oben)
            {
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head), feld.GetRow(head) - 1));
            }


            if (rechts)
            {
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head) + 1, feld.GetRow(head)));
            }

            if (links)
            {
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head) - 1, feld.GetRow(head)));
            }
        }
    }
}
