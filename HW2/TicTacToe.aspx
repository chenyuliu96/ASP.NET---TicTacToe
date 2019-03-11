<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="HW2.TicTacToe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <link href="Styles/MyStyles.css" rel="stylesheet" />
   
    <h3><asp:Label ID="Winner" runat="server" Text=""></asp:Label></h3>
    <h3><asp:Label ID="currentPlayer" runat="server" Text="Current Player is X"></asp:Label></h3>
    <div>
       
    </div>
        <div ID="GameContainer" runat="server">

        
              <div id="board">
                  
                <div class="bottom right">
                     
                     <asp:Button CssClass="Buttons" ID="Button0" runat="server" Text="Button"  OnClick="Button_Click" />
                    <asp:Image ID="Image0" CssClass="Image"   runat="server" /> 
                </div>

                <div class="left bottom right">
                   <asp:Button CssClass="Buttons" ID="Button1" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image1" CssClass="Image"   runat="server" /> 
                </div>

                <div class="left bottom">
                   <asp:Button CssClass="Buttons" ID="Button2" runat="server"  Text="Button" OnClick="Button_Click" />
                   <asp:Image ID="Image2" CssClass="Image"   runat="server" /> 
                </div>

                <div class="top right bottom">
                     <asp:Button CssClass="Buttons" ID="Button3" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image3" CssClass="Image"   runat="server" /> 
                </div>

                <div class="top right bottom left">
                     <asp:Button CssClass="Buttons" ID="Button4" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image4" CssClass="Image"  runat="server" /> 
                </div>

                <div class="top left bottom">
                     <asp:Button CssClass="Buttons" ID="Button5" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image5" CssClass="Image"   runat="server" /> 
                </div>

                <div class="top right">
                     <asp:Button CssClass="Buttons" ID="Button6" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image6" CssClass="Image"   runat="server" /> 
                </div>

                <div class="left top right">
                     <asp:Button CssClass="Buttons" ID="Button7" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image7" CssClass="Image"   runat="server" /> 
                </div>

                <div class="top left">
                    <asp:Button CssClass="Buttons" ID="Button8" runat="server"  Text="Button" OnClick="Button_Click" />
                     <asp:Image ID="Image8" CssClass="Image"   runat="server" /> 
                </div>
            </div>

            </div>
    <h2><asp:Label ID="noAccess" runat="server" Text="You do not have access to this page."></asp:Label></h2>

</asp:Content>
