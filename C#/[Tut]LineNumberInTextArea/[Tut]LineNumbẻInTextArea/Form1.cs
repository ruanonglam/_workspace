using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Tut_LineNumbẻInTextArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i <= richTextBox2.Lines.Count(); i++)
            {
                if (!(e.KeyCode == Keys.Back))
                {
                    if (!richTextBox1.Text.Contains(i.ToString()))
                    {
                        richTextBox1.Text += i.ToString() + "\n";
                    }
                }
                else
                {
                    richTextBox1.Clear();
                }
            }    
        }
    }
}
