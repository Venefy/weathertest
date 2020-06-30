<%@ Page Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="TableLoad.aspx.cs" Inherits="weatherapp.TableLoad" %>

<asp:Content ID="headcont" ContentPlaceHolderID="head" runat="server">
    <title>Загрузка</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" runat="server">
        <h4>Загрузка архивов погодных условий в городе Москве</h4>
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
 </asp:Content>
