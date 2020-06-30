<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="weatherapp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Главная страница</title>
    <link  type="text/css" rel="stylesheet" href="bootstrap.css" />
    <link  type="text/css" rel="stylesheet" href="Style1.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="Menu1" runat="server"  StaticDisplayLevels="2" Font-Size="Larger" >
            <staticmenuitemstyle
          forecolor="Black"/>
        <statichoverstyle Font-Bold="true"/>
          <items>
          <asp:menuitem navigateurl="Default.aspx" 
            text="Главная"
            tooltip="Главная страница">
              <asp:menuitem navigateurl="TableManage.aspx"
              text="Просмотр архивов "
              tooltip="Просмотр архивов погодных условий в городе Москве"/>
            <asp:menuitem navigateurl="TableLoad.aspx"
              text="Загрузка архивов "
              tooltip="Загрузка архивов погодных условий в городе Москве"/>
            </asp:menuitem>

        </items>
        </asp:Menu>
        <br /><br /> 
        <h4>Главная страница</h4>
        Данное приложение позволит Вам просмотреть архивы погодных условий в городе Москве. И при желании загрузить свои данные.


    </div>
    </form>
</body>
</html>
