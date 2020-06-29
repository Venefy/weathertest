<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableManage.aspx.cs" Inherits="weatherapp.TableManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Просмотр архивов</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:Menu ID="Menu1" runat="server"  StaticDisplayLevels="2">
          <items>
          <asp:menuitem navigateurl="Default.aspx" 
            text="Главная"
            tooltip="Главная страница">
              <asp:menuitem navigateurl="TableManage.aspx"
              text="Просмотр архивов"
              tooltip="Просмотр архивов погодных условий в городе Москве"/>
            <asp:menuitem navigateurl="TableLoad.aspx"
              text="Загрузка архивов"
              tooltip="Загрузка архивов погодных условий в городе Москве"/>
            </asp:menuitem>
        </items>
        </asp:Menu>

            <h4>Просмотр туть</h4>
        </div>
    </form>
</body>
</html>
