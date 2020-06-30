<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableLoad.aspx.cs" Inherits="weatherapp.TableLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Загрузка архивов</title>
    <link  type="text/css" rel="stylesheet" href="bootstrap.css" />
    <link  type="text/css" rel="stylesheet" href="Style1.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Menu ID="Menu1" runat="server"  StaticDisplayLevels="2" Font-Size="Larger">
               <staticmenuitemstyle
          forecolor="Black"/>
        <statichoverstyle Font-Bold="true"/>
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
        <br /><br /> 
        <h4>Просмотр архивов погодных условий в городе Москве</h4>
        <h5>Выберите файл для загрузки:</h5>
  
       <asp:FileUpload id="FileUpload1"                 
           runat="server" 
           AllowMultiple="true" >
       </asp:FileUpload>
       <br /><br />  
       <asp:Button id="UploadButton" 
           Text="Загрузить файлы"
           OnClick="Upload_Click"
           runat="server">
       </asp:Button>  
        <asp:Label ID="myLabel" runat="server"></asp:Label>
        <br /><br />
        <br /><br />  
        <asp:Button id="delete" 
           Text="Очистить все данные"
           OnClick="delete_Click"
           runat="server">
       </asp:Button>  
    </div>
    </form>
</body>
</html>

