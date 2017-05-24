using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using i_tools.Properties;
using i_tools.Classes;

namespace i_tools
{
    public partial class MessageBox : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MessageBox()
        {
            InitializeComponent();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void MessageBoxForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MessageBoxForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MessageBoxForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showMessage(int type)
        {
            if (Constants.MESSAGE_TYPE_ERROR.Equals(type))
                MessageBoxForm.BackgroundImage = Resources.error_messagebox;
            else
                MessageBoxForm.BackgroundImage = Resources.messagebox1;
            this.ShowDialog();
        }
    }
}
