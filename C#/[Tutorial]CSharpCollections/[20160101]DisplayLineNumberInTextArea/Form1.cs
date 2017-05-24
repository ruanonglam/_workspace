using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20160101_DisplayLineNumberInTextArea
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

        private void txtContent_KeyDown_1(object sender, KeyEventArgs e)
        {
            //for (int i = 0; i <= txtContent.Lines.Count(); i++)
            //{
            //    if (!(e.KeyCode == Keys.Back))
            //    {
            //        if (!txtLineNumber.Text.Contains(i.ToString()))
            //        {
            //            txtLineNumber.Text += i.ToString() + "\n";
            //        }
            //    }
            //    else
            //    {
            //        txtLineNumber.Clear();
            //    }
            //}
        }

        private void txtContent_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtContent_VScroll(object sender, EventArgs e)
        {
            
        }
    }
}
