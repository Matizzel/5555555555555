using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5555555555555
{
    public partial class Form1 : Form
    {
        int panelCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Panel panel = new Panel();
                panel.Location = new System.Drawing.Point(10, 10 + panelCount * 50);
                panel.Size = new System.Drawing.Size(200, 40);
                this.Controls.Add(panel);

                panelCount++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(10, 10);
                    textBox.Size = new System.Drawing.Size(100, 20);
                    control.Controls.Add(textBox);
                }
            }
        }
    }
}
