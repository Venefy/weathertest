using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Windows;
using ExcelDataReader;

using System.Data;

namespace weatherapp
{
    public partial class TableLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
                    XSSFWorkbook xssfwb;
                    //Открываем файл
                    using (FileStream file = new FileStream(Server.MapPath("~/Uploads/" + fileName), FileMode.Open, FileAccess.Read))
                    {
                        xssfwb = new XSSFWorkbook(file);
                    }
                    ISheet sheet = xssfwb.GetSheetAt(1);
                    for (int row = 0; row <= sheet.LastRowNum; row++)
                    {
                        var currentRow = sheet.GetRow(row);

                        for (int column = 0; column < currentRow.Cells.Count; column++)
                        {
                            var stringCellValue = currentRow.GetCell(column);
                            
                            myLabel.Text += string.Format("Ячейка {0}-{1} значение:{2}", row, column, stringCellValue);
                            
                        }


                    }
                }
            
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
            }
            else
            {
                MessageBox.Show("Не удалось загрузить файл.");
            }

        }
        //protected void Button2_Click(object sender, EventArgs e)
        //{

        //    using (WeatherContext db = new WeatherContext())
        //    {
        //        db.Database.Delete();
        //        // создаем два объекта Weather
        //        Weather user1 = new Weather { Month = "Tom", Year = 33 };
        //        Weather user2 = new Weather { Month = "Sam", Year = 26 };

        //        // добавляем их в бд
        //        db.Weathers.Add(user1);
        //        db.Weathers.Add(user2);
        //        db.SaveChanges();

        //        string str = "";

        //        var users = db.Weathers;

        //        foreach (Weather u in users)
        //        {
        //            str += u.Id.ToString();
        //            str += u.Year.ToString();
        //            str += u.Month.ToString();

        //        }

        //        //    TableCell c = new TableCell();
        //        //    c.Controls.Add(new LiteralControl(db.Weathers.ToString()));

        //        //    // Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
        //        //}
        //    }

        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    int rows = Convert.ToInt16(TextBox1.Text);
        //    int cols = Convert.ToInt16(TextBox2.Text);
        //    for (int j = 0; j < rows; j++)
        //    {
        //        TableRow r = new TableRow();
        //        for (int i = 0; i < cols; i++)
        //        {
        //            TableCell c = new TableCell();
        //            c.Controls.Add(new LiteralControl("row" +
        //            j.ToString() + ", cell " + i.ToString()));
        //            r.Cells.Add(c);
        //        }
        //        Table1.Rows.Add(r);
        //    }

        //}
    }
}