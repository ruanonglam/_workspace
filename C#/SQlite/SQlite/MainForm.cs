using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SQlite
{
    public partial class MainForm : Form
    {
        SQLiteConnection connecttion;
        public MainForm()
        {
            InitializeComponent();
        }

        //--// Conect DB Group START
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "DB files (*.sqlite)|*.sql";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                String dbFile = Path.GetFullPath(saveDialog.FileName) + ".sqlite";
                SQLiteConnection.CreateFile(dbFile);
                txtLog.Text += "Đã tạo file " + saveDialog.FileName + ".sqlite thành công!" + "\r\n";
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "DB files (*.sqlite)|*.sqlite";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                String dbFile = Path.GetFullPath(openDialog.FileName);
                txtDBFile.Text = dbFile;
                btnConnectDB.Enabled = true;
                txtLog.Text += "Đã open file " + openDialog.FileName + "!" + "\r\n";
            }
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            String conectInfo = "Data Source=" + txtDBFile.Text + ";Version=3";
            connecttion = new SQLiteConnection(conectInfo);
            connecttion.Open();
            txtLog.Text += "Đã open DB thành công!" + "\r\n";
        }

        private void btnCloseDB_Click(object sender, EventArgs e)
        {
            if (connecttion != null)
            {
                connecttion.Close();
                txtLog.Text += "Đã close DB thành công!" + "\r\n";
            }
        }
        //--// Conect DB Group END


        private void btnInsert_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO BUNKEI_TBL (ID,AUDIO_NAME,IMG_NAME,UNIT,SECTION,START_TIME,PLAY_TIME) VALUES (";
                
            for (int i = 1; i < 50; i++) {
                String name = "'"+ i + ".Bunkei.mp3'";
                String unit = "'Unit" + i + "'";
                String subSQL = "'"+ i + "', " + name + " ,'1' ," + unit + ", 'Bunkei' , '0', '-1')";
                SQLiteCommand command = new SQLiteCommand(SQL + subSQL, connecttion);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Done!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO KAIWA_TBL (ID,AUDIO_NAME,IMG_NAME,UNIT,SECTION,START_TIME,PLAY_TIME) VALUES (";

            for (int i = 1; i < 51; i++)
            {
                String name = "'" + (i) + ".Kaiwa.mp3'";
                String unit = "'Unit" + (i) + "'";
                String subSQL = "'" + i + "', " + name + " ,'1' ," + unit + ", 'Kaiwa' , '0', '-1')";
                SQLiteCommand command = new SQLiteCommand(SQL + subSQL, connecttion);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Done!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO REIBUN_TBL (ID,AUDIO_NAME,IMG_NAME,UNIT,SECTION,START_TIME,PLAY_TIME) VALUES (";

            int j = 1;
            for (int i = 1; i < 101; i+= 2)
            {
                String name = "'" + j + ".Reibun.mp3'";
                String unit = "'Unit" + j + "'";
                String subSQL1 = "'" + i + "', " + name + " ,'1' ," + unit + ", 'Reibun' , '0', '-1')";
                String subSQL2= "'" + (i + 1) + "', " + name + " ,'2' ," + unit + ", 'Reibun' , '0', '-1')";
                SQLiteCommand command1 = new SQLiteCommand(SQL + subSQL1, connecttion);
                command1.ExecuteNonQuery();
                SQLiteCommand command2 = new SQLiteCommand(SQL + subSQL2, connecttion);
                command2.ExecuteNonQuery();
                j++;
            }
            MessageBox.Show("Done!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO RENSHUUC_TBL (ID,AUDIO_NAME,IMG_NAME,UNIT,SECTION,START_TIME,PLAY_TIME) VALUES (";

            int j = 1;
            for (int i = 1; i < 151; i += 3)
            {
                String name1 = "'" + j + ".Renshuu C1.mp3'";
                String name2= "'" + j + ".Renshuu C2.mp3'";
                String name3 = "'" + j + ".Renshuu C3.mp3'";
                String unit = "'Unit" + j + "'";
                String subSQL1 = "'" + i + "', " + name1 + " ,'1' ," + unit + ", 'RenshuuC' , '0', '-1')";
                String subSQL2 = "'" + (i + 1) + "', " + name2 + " ,'2' ," + unit + ", 'RenshuuC' , '0', '-1')";
                String subSQL3 = "'" + (i + 2) + "', " + name3 + " ,'3' ," + unit + ", 'RenshuuC' , '0', '-1')";
                SQLiteCommand command1 = new SQLiteCommand(SQL + subSQL1, connecttion);
                command1.ExecuteNonQuery();
                SQLiteCommand command2 = new SQLiteCommand(SQL + subSQL2, connecttion);
                command2.ExecuteNonQuery();
                SQLiteCommand command3 = new SQLiteCommand(SQL + subSQL3, connecttion);
                command3.ExecuteNonQuery();
                j++;
            }
            MessageBox.Show("Done!");
        }

        private void btnKotoba_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO KOTOBA_TBL (ID,AUDIO_NAME,IMG_NAME,UNIT,SECTION,START_TIME,PLAY_TIME) VALUES (";

            int j = 1;
            for (int i = 1; i < 2501; i += 50)
            {
                String name = "'" + j + ".Kotoba.mp3'";
                String unit = "'Unit" + j + "'";

                // 1 Unit
                for (int k = 0; k < 50; k++ )
                {
                    String subSQL1 = "'" + (i + k) + "', " + name + " ,'" + (k + 1) + "' ," + unit + ", 'Kotoba' , '0', '-1')";
                    SQLiteCommand command1 = new SQLiteCommand(SQL + subSQL1, connecttion);
                    command1.ExecuteNonQuery();
                }
                
                j++;
            }
            MessageBox.Show("Done!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO MONDAI_TBL (ID,AUDIO_NAME,IMG_NAME,UNIT,SECTION,START_TIME,PLAY_TIME) VALUES (";

            int j = 1;
            for (int i = 1; i < 151; i += 3)
            {
                String name1 = "'" + j + ".Mondai 1.mp3'";
                String name2 = "'" + j + ".Mondai 2.mp3'";
                String name3 = "'" + j + ".Mondai 3.mp3'";
                String unit = "'Unit" + j + "'";
                String subSQL1 = "'" + i + "', " + name1 + " ,'1' ," + unit + ", 'Mondai' , '0', '-1')";
                String subSQL2 = "'" + (i + 1) + "', " + name2 + " ,'2' ," + unit + ", 'Mondai' , '0', '-1')";
                String subSQL3 = "'" + (i + 2) + "', " + name3 + " ,'3' ," + unit + ", 'Mondai' , '0', '-1')";
                SQLiteCommand command1 = new SQLiteCommand(SQL + subSQL1, connecttion);
                command1.ExecuteNonQuery();
                SQLiteCommand command2 = new SQLiteCommand(SQL + subSQL2, connecttion);
                command2.ExecuteNonQuery();
                SQLiteCommand command3 = new SQLiteCommand(SQL + subSQL3, connecttion);
                command3.ExecuteNonQuery();
                j++;
            }
            MessageBox.Show("Done!");
        }
        
    }
}
