using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptAndDecryptData
{
    public partial class ImgShow : Form
    {
        private String img = null;
        public ImgShow()
        {
            InitializeComponent();
        }

        public String IMG
        {
            get;
            set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.EncryptAndDecryptData encrypt = new Classes.EncryptAndDecryptData(Common.Constants.AFTECH_KEY_LANGUAGE);
            //MessageBox.Show("" + IMG);

            pictureBox1.Image = encrypt.DecryptSingleFileToBitmap(IMG);

        }
    }
}
