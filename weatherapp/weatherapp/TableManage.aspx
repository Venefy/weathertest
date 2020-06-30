<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="TableManage.aspx.cs" Inherits="weatherapp.TableManage" %>

<asp:Content ID="headcont" ContentPlaceHolderID="head" runat="server">
    <title>Просмотр</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" runat="server">
    <h5>Просмотр архивов погодных условий в городе Москве</h5>
                <asp:DropDownList ID="Month" runat="server" name="Месяц">
                <asp:ListItem value=""></asp:ListItem>
                <asp:ListItem value="0">Январь</asp:ListItem>
                <asp:ListItem value="1">Февраль</asp:ListItem>
                <asp:ListItem value="2">Март</asp:ListItem>
                <asp:ListItem value="3">Апрель</asp:ListItem>
                <asp:ListItem value="4">Май</asp:ListItem>
                <asp:ListItem value="5">Июнь</asp:ListItem>
                <asp:ListItem value="6">Июль</asp:ListItem>
                <asp:ListItem value="7">Август</asp:ListItem>
                <asp:ListItem value="8">Сентябрь</asp:ListItem>
                <asp:ListItem value="9">Октябрь</asp:ListItem>
                <asp:ListItem value="10">Ноябрь</asp:ListItem>
                <asp:ListItem value="11">Декабрь</asp:ListItem>
                 </asp:DropDownList>

                <asp:DropDownList id="Year" name="Год" runat="server">
                <asp:ListItem value=""></asp:ListItem>
                <asp:ListItem value="2010">2010</asp:ListItem>
                <asp:ListItem value="2011">2011</asp:ListItem>
                <asp:ListItem value="2012">2012</asp:ListItem>
                <asp:ListItem value="2013">2013</asp:ListItem>
                </asp:DropDownList>
            <asp:Button id="SubButton" 
           Text="Обновить данные"
           OnClick="ChangeData"
           runat="server">
            </asp:Button>  
           

            <asp:GridView ID="grid" runat="server" DataSourceID="getWeathers" AutoGenerateColumns="false" DataKeyNames="Date" AllowPaging="true" PageSize="8" PagerStyle-ForeColor="Black">
            <Columns>
                <asp:BoundField HeaderText="Дата" DataField="Date" />
                <asp:BoundField HeaderText="Температура, гр. Ц" DataField="T"  />
                <asp:BoundField HeaderText="Отн. влажность, %" DataField="Humidity"  />
                <asp:BoundField HeaderText="Точка росы, гр. Ц" DataField="Td" />
                <asp:BoundField HeaderText="Атм. давление, мм рт.ст" DataField="AtmoPress" />
                <asp:BoundField HeaderText="Направление ветра" DataField="Wind" />
                <asp:BoundField HeaderText="Скорость ветра, м/с" DataField="WindSpeed" />
                <asp:BoundField HeaderText="Облачность, %" DataField="Clouds" />
                <asp:BoundField HeaderText="Нижняя граница облачности, м" DataField="h" />
                <asp:BoundField HeaderText="Горизонтальная видимость, км" DataField="VV" />
                <asp:BoundField HeaderText="Погодные явления" DataField="Other" />
            </Columns>
                <PagerSettings Mode="NumericFirstLast" />
            </asp:GridView>
        
            <asp:SqlDataSource ID="getWeathers" runat="server"
	        ConnectionString="<%$ ConnectionStrings:DBConnection %>"
	        SelectCommand="SELECT * FROM Weathers ORDER BY Date" />

</asp:Content>