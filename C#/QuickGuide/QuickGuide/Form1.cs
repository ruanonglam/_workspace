using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right){
                MessageBox.Show("Right");
            } else if (e.KeyCode == Keys.Left) {
                MessageBox.Show("Left");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MessageBox.Show("Right");
            }
            else if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("Left");
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MessageBox.Show("Right");
            }
            else if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("Left");
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MessageBox.Show("Right");
            }
            else if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("Left");
            }
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.A) {
                MessageBox.Show("A");
            }
        }
    }
}
