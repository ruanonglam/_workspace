using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IniFileOperator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            IniOperator.IniWriteValue("System", "StringVal", txtStringVal1.Text);
            IniOperator.IniWriteValue("System", "IntVal", txtIntVal1.Text);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtStringVal2.Text = IniOperator.IniReadValue("System", "StringVal");
            txtIntVal2.Text = IniOperator.IniReadValue("System", "IntVal");
        }
    }
}
