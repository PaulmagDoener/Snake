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
                timer1.Interval = 1000;

            else if (radioButton2.Checked)
                timer1.Interval = 600;

            else if (radioButton3.Checked)
                timer1.Interval = 300;

            groupBox1.Enabled = false;
            button1.Enabled = false;

            unten = true;

            apple.BackColor = SystemColors.Highlight;
            apple.Size = new Size(13, 13);
            feld.Controls.Add(apple,zufall.Next(0,feld.ColumnCount), zufall.Next(0, feld.RowCount));

            Schlange.Add(head);
            zellen.Add(feld.GetCellPosition(head));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void feld_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (!unten)
                    {
                        unten = links = rechts = false;
                        oben = true;
                    }

                    break;

                case Keys.A:
                    if (!rechts)
                    {
                        unten = oben = rechts = false;
                        links = true;
                    }
                    break;


                case Keys.S:
                    if (!oben)
                    {
                        oben = links = rechts = false; unten = links = oben = false;
                        unten = true;
                    }
                    break;

                case Keys.D:
                    if (!links)
                    {
                        unten = links = oben = false;
                        rechts = true;
                    }
                    break;




            }
        }

        private void head_Paint(object sender, PaintEventArgs e)
        {

        }

        Panel apple = new Panel(); 

        Random zufall  = new Random();

        List<Panel> Schlange = new List<Panel>();
        List<TableLayoutPanelCellPosition> zellen = new List<TableLayoutPanelCellPosition>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (unten)
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head), feld.GetRow(head) + 1));

            if (oben)
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head), feld.GetRow(head) - 1));
           


            if (rechts)
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head) + 1, feld.GetRow(head)));
            

            if (links)
                feld.SetCellPosition(head, new TableLayoutPanelCellPosition(feld.GetColumn(head) - 1, feld.GetRow(head)));

            if (feld.GetCellPosition(head).Equals(feld.GetCellPosition(apple)))
            {
                feld.SetCellPosition(apple, new TableLayoutPanelCellPosition(zufall.Next(0, feld.ColumnCount), zufall.Next(0, feld.RowCount)));

                Panel schweif = new Panel();
                schweif.BackColor = SystemColors.ControlText;
                schweif.Size = new Size(13, 13);
                feld.Controls.Add(schweif, zellen[zellen.Count - 1].Column, zellen[zellen.Count - 1].Row);

                Schlange.Add(schweif);
                zellen.Add(new TableLayoutPanelCellPosition(zellen[zellen.Count - 1].Column, zellen[zellen.Count - 1].Row));

            }

            
        }
    }
}
