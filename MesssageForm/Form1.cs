using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesssageForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            colorlabel.Text = " ";
            foreach (FontFamily family in FontFamily.Families)
                fontnamebox.Items.Add(family.Name);
            viewlbl.Text = " ";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            colorlabel.BackColor = dialog.Color;
            viewlbl.ForeColor = colorlabel.BackColor;
        }

        private void fontnamebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fontnamebox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                viewlbl.Font = new Font(fontnamebox.Text, (int)fontsizebox.Value);
                
            }
           
            
           
        }

        private void koyucheck_CheckedChanged(object sender, EventArgs e)
        {
            if (koyucheck.Checked == true)
            {
                viewlbl.Font = new Font(viewlbl.Font,FontStyle.Bold);
            }
            else if (koyucheck.Checked == false)
            {
                viewlbl.Font = new Font(viewlbl.Font, FontStyle.Regular);
            }
        }

        private void italiccheck_CheckedChanged(object sender, EventArgs e)
        {
            if (italiccheck.Checked == true)
            {
                viewlbl.Font = new Font(viewlbl.Font, FontStyle.Italic);
            }
            else if (italiccheck.Checked == false)
            {
                viewlbl.Font = new Font(viewlbl.Font, FontStyle.Regular);
            }
        }

        private void writelbl_TextChanged(object sender, EventArgs e)
        {
            
            viewlbl.Text =writelbl.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.TopLeft;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.TopCenter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.TopRight;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.MiddleRight;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.BottomLeft;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.BottomCenter;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            viewlbl.TextAlign = ContentAlignment.BottomRight;
        }
    }
}
