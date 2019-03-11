<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HW2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
   
        <h1>Welcome to the Tic Tac Toe game!</h1>
 
  
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DisplayRememberMe="False" TitleText="Register or Login to Play Game" BackColor="#CCFFFF" BorderPadding="6" Height="165px" LoginButtonText="Login" PasswordLabelText="Password: " UserNameLabelText="User Name: " Width="388px"></asp:Login>
    <asp:Button ID="LogOffButton" runat="server" Text="Log Off" OnClick="LogOffButton_Click" />
    <p>Click <a href="Public.aspx"> here</a> for general information.</p>


</asp:Content>
