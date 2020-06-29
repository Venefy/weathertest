using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace weatherapp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            XSSFWorkbook xssfwb;

            if (FileUpload1.HasFile)
            {
                string fileName = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));

                using (FileStream file = new FileStream(Server.MapPath("~/Uploads/" + fileName), FileMode.Open, FileAccess.Read))
                {
                    xssfwb = new XSSFWorkbook(file);
                }

                ISheet sheet = xssfwb.GetSheetAt(0);
                for (int row = 0; row <= sheet.LastRowNum; row++)
                {
                    if (sheet.GetRow(row) != null) //null если пустые
                    {
                        MessageBox.Show(string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue));
                    }
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            using (WeatherContext db = new WeatherContext())
            {
                db.Database.Delete();
                // создаем два объекта Weather
                Weather user1 = new Weather { Month = "Tom", Year = 33 };
                Weather user2 = new Weather { Month = "Sam", Year = 26 };

                // добавляем их в бд
                db.Weathers.Add(user1);
                db.Weathers.Add(user2);
                db.SaveChanges();

                string str = "";
                
                var users = db.Weathers;

                foreach (Weather u in users)
                {
                    str += u.Id.ToString();
                    str += u.Year.ToString();
                    str += u.Month.ToString();

                }
                Label1.Text = str;
                //    TableCell c = new TableCell();
                //    c.Controls.Add(new LiteralControl(db.Weathers.ToString()));

                //    // Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                //}
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt16(TextBox1.Text);
            int cols = Convert.ToInt16(TextBox2.Text);
            for (int j = 0; j < rows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < cols; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl("row" +
                    j.ToString() + ", cell " + i.ToString()));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }

        }
    }
}