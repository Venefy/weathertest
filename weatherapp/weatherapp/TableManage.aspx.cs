using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace weatherapp
{
    public partial class TableManage : System.Web.UI.Page
    {
        protected void ChangeData(object sender, EventArgs e)
        { 
            if (Month.SelectedValue != "" && Year.SelectedValue == "")
            {
                MessageBox.Show(new Form { TopMost = true }, "Введите год", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Month.SelectedValue == "" && Year.SelectedValue != "")
                {
                    getWeathers.SelectCommand = "SELECT * FROM Weathers Where DATEPART(yyyy, Date) = " + Year.SelectedValue;
                }
                else
                {
                    if (Month.SelectedValue != "" && Year.SelectedValue != "")
                    {
                        getWeathers.SelectCommand = "SELECT * FROM Weathers Where DATEPART(yyyy, Date) = " + Year.SelectedValue + " AND DATEPART(m, Date) = " + Month.SelectedValue;

                    }
                    else
                    {
                        getWeathers.SelectCommand = "SELECT * FROM Weathers";
                    }
                }
            }
        }
    }
}