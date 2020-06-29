<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="weatherapp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
        Rows:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        Columns:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Create Table" OnClick="Button1_Click" /><br />
        <asp:Button ID="Button2" runat="server" Text="nya" OnClick="Button2_Click" />
        <asp:Label ID="Label1" runat="server"> tut</asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" Text="basochka" OnClick="Button3_Click" />
        <h4>Select a file to upload:</h4>
   
       <asp:FileUpload id="FileUpload1"                 
           runat="server">
       </asp:FileUpload>
            
       <br /><br />
       
       <asp:Button id="UploadButton" 
           Text="Upload file"
           OnClick="Button3_Click"
           runat="server">
       </asp:Button>   
    </div>
    </form>
</body>
</html>
