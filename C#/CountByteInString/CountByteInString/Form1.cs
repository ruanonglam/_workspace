using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountByteInString
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

        private void btnExe_Click(object sender, EventArgs e)
        {
            string inputVal = txtIputVal.Text;
            if (String.IsNullOrEmpty(inputVal))
            {
                lbResult.Text = "0: バイト";
            }
            else
            {
                lbResult.Text = countByteSJIS(inputVal) + ": バイト";
            }
        }

        private int countByte(string val)
        {
            int result = 0;
            char[] unicodes = val.ToCharArray();
            foreach(char code in unicodes)
            {
                
                if (code < 128)
                    result++;
                else
                    result += 2;
            }
            return result;
        }

        public int countByteSJIS(string inputVals)
        {
            // 入力文字列
            string inputVal = "あいうえお12345";
            // Encodingオブジェットを取得する
            Encoding encode = System.Text.Encoding.GetEncoding("UTF-8");
            // 入力文字列のバイト数を取得する
            return encode.GetByteCount(inputVal);
        }
    }
}
