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
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;


namespace weatherapp
{
    public partial class TableLoad : System.Web.UI.Page
    {
        protected void delete_Click(object sender, EventArgs e)
        {
            using (WeatherContext db = new WeatherContext())
            {
                db.Database.ExecuteSqlCommand("DELETE FROM Weathers");
                MessageBox.Show("Все данные были успешно удалены.");
            }
        }
        protected void Upload_Click(object sender, EventArgs e)
        {
            if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
            {
                foreach (HttpPostedFile uploadedFile in FileUpload1.PostedFiles)
                {
                    try
                    {
                        XSSFWorkbook xssfwb;
                        Stream file = uploadedFile.InputStream;
                        {
                            xssfwb = new XSSFWorkbook(file);
                        }
                        WeatherContext db = new WeatherContext();

                        for (int i = 0; i < 12; i++)
                        {
                            ISheet sheet = xssfwb.GetSheetAt(i);
                            for (int row = 4; row <= sheet.LastRowNum; row++)
                            {
                                var curRow = sheet.GetRow(row);
                                string date = curRow.GetCell(0).StringCellValue;
                                date += " " + curRow.GetCell(1).StringCellValue;

                                Weather wew1 = new Weather
                                {
                                    ID = row,
                                    Date = Convert.ToDateTime(date)
                                };

                                wew1.T = Convert.ToDouble(curRow.GetCell(2).NumericCellValue, CultureInfo.InvariantCulture);
                                wew1.Humidity = Convert.ToDouble(curRow.GetCell(3).NumericCellValue, CultureInfo.InvariantCulture);
                                wew1.Td = Convert.ToDouble(curRow.GetCell(4).NumericCellValue, CultureInfo.InvariantCulture);
                                wew1.AtmoPress = curRow.GetCell(5).NumericCellValue;
                                wew1.Wind = curRow.GetCell(6).ToString();
                                if (curRow.GetCell(7).CellType == CellType.String) { }
                                if (curRow.GetCell(7).CellType == CellType.Numeric)
                                {
                                    wew1.WindSpeed = curRow.GetCell(7).NumericCellValue;
                                }
                                if (curRow.GetCell(8).CellType == CellType.String) { }
                                if (curRow.GetCell(8).CellType == CellType.Numeric)
                                {
                                    wew1.Clouds = curRow.GetCell(8).NumericCellValue;
                                }
                                if (curRow.GetCell(9).CellType == CellType.String) { }
                                if (curRow.GetCell(9).CellType == CellType.Numeric)
                                {
                                    wew1.h = curRow.GetCell(9).NumericCellValue;
                                }
                                if (curRow.GetCell(10).CellType == CellType.String) { }
                                if (curRow.GetCell(10).CellType == CellType.Numeric)
                                {
                                    wew1.VV = curRow.GetCell(10).NumericCellValue;
                                }
                                //MessageBox.Show(curRow.LastCellNum.ToString());
                                if (curRow.LastCellNum == 12)
                                {
                                    wew1.Other = curRow.GetCell(11).ToString();
                                }
                                db.Weathers.Add(wew1);
                            }
                            db.SaveChanges();
                        }
                        myLabel.Text += "\t Таблицы из файла " + uploadedFile.FileName + " успешно загружены.   \n";
                    }
                    catch
                    {
                        MessageBox.Show("Таблица неверного формата");
                    }
                }
            }
        }
    }
}