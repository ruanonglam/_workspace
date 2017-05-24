using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Model;
using System.IO;

namespace ExcelWriteAndRead
{
    public partial class Form1 : Form
    {
        HSSFWorkbook workbook;
        HSSFSheet sheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputExcel = @"C:\Users\AFTECH\Desktop\NFFS\Test.xls";
            FileStream fs = new FileStream(inputExcel, FileMode.Open, FileAccess.Read);
            workbook = new HSSFWorkbook(fs);

            // Get sheets from workbook
            string[] result = new string[workbook.Count];
            for (int u = 0; u < workbook.Count; u++)
            {
                result[u] = workbook.GetSheetAt(u).SheetName;
            }
            // Get data from sheet
            sheet = (HSSFSheet)workbook.GetSheet(result[0]);

            int i = 0;
            while (sheet.GetRow(i) != null)
            {
                // add necessary columns
                if (i == 0)
                {
                    if (dgvData.Columns.Count < sheet.GetRow(i).Cells.Count)
                    {
                        for (int j = 0; j < sheet.GetRow(i).Cells.Count; j++)
                        {
                            dgvData.Columns.Add("COL_" + j, sheet.GetRow(i).Cells[j].ToString());
                        }
                    }
                }


                // add row
                dgvData.Rows.Add();
                // write row value
                if (i > 0)
                {
                    int index = i;

                    for (int j = 0; j < sheet.GetRow(index).Cells.Count; j++)
                    {
                        var cell = sheet.GetRow(index).GetCell(j);

                        if (cell != null)
                        {
                            // TODO: you can add more cell types capability, e. g. formula
                            switch (cell.CellType)
                            {
                                case NPOI.SS.UserModel.CellType.Numeric:
                                    dgvData[j, index].Value = sheet.GetRow(index).GetCell(j).NumericCellValue;
                                    break;
                                case NPOI.SS.UserModel.CellType.String:
                                    dgvData[j, index].Value = sheet.GetRow(index).GetCell(j).StringCellValue;
                                    break;
                            }
                        }
                    }
                }
                i++;
            }
        }

    }
}
