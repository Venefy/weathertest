<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableLoad.aspx.cs" Inherits="weatherapp.TableLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Загрузка архивов</title>
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
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        <h4>Выберите файл для загрузки:</h4>
  
       <asp:FileUpload id="FileUpload1"                 
           runat="server" >
       </asp:FileUpload>
            
       <br /><br />
       
       <asp:Button id="UploadButton" 
           Text="Загрузить файл"
           OnClick="Upload_Click"
           runat="server">
       </asp:Button>   
    </div>
    </form>
</body>
</html>

