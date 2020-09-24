using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03_NPIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            List<Person> persons = new List<Person> {
                new Person(){ Name = "yj",Age = 18,Email = "yj@qq.com"},
                new Person(){ Name = "yj",Age = 18,Email = "yj@qq.com"}
            };

            //创建工作簿
            IWorkbook wkBoot = new HSSFWorkbook();
            //创建工作表
            ISheet sheet = wkBoot.CreateSheet("List for Person");
            for (int x = 0; x < persons.Count; x++)
            {
                //创建一行
                IRow row = sheet.CreateRow(x);
                row.CreateCell(0).SetCellValue(persons[x].Name);
                row.CreateCell(1).SetCellValue(persons[x].Age);
                row.CreateCell(2).SetCellValue(persons[x].Email);
            }

            //将工作簿写入文件
            using (FileStream fsWrite = File.OpenWrite("list.xls"))
            {
                wkBoot.Write(fsWrite);
            }
            MessageBox.Show("写入成功");
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.OpenRead("list.xls"))
            {
                //获取工作表
                IWorkbook wk = new HSSFWorkbook(fs);
                //遍历工作表
                for (int x = 0; x < wk.NumberOfSheets; x++)
                {
                    ISheet sheet = wk.GetSheetAt(x);
                    Console.WriteLine("{0}", sheet.SheetName);
                    //使用sheel.GetLastRow 会存在问题，不会取到最后一行
                    for (int r = 0; r < sheet.PhysicalNumberOfRows; r++)
                    {
                        IRow currentRow = sheet.GetRow(r);
                        //遍历当前行的单元格
                        for (int c = 0; c < currentRow.LastCellNum; c++)
                        {
                            //获取当前单元格
                            ICell cell = currentRow.GetCell(c);
                            string value = cell.ToString();
                            Console.Write("{0} |", value);
                        }
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
