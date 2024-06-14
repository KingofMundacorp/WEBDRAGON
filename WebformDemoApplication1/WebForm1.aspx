<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebformDemoApplication1.WebForm1" %>

<%@ Register Src="~/WebUserControl1.ascx" TagName="WebCtrl" TagPrefix="TWebCtrl" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BUGATTI LA VOITURE NOIRE</title>
    <style>
        body {
            background-color:antiquewhite;
            height: 100%;
            margin: 20px 20px 20px 0;
            
            font-family: Arial, sans-serif;
        }
        .Myname {
            padding:10px 10px 10px 10px;
        }
        .Customizelabel {
            color: darkblue;
            font-size: 16px;
            font-family: Arial, sans-serif;
            font-weight:500;
            
        }
        .listboxName {
            padding:10px 10px 10px 10px;
        }
        .Buttoncolour {
            color:aquamarine;
            font-size: 16px;
            font-family:'Times New Roman', Times, serif;
            font-weight:500;
            background-color:darkmagenta;
            border-width:2px;
            border-color:antiquewhite;
            padding:2px 5px 2px 5px;
        }
        .Textboxatrributes {
            color:black;
            font-size: 16px;
            font-family:'Times New Roman', Times, serif;
            font-weight:500;
            background-color:aliceblue;
            border-width:3px;
            border-color:brown;
        }
        .Kinglist {
            line-height:200px;
        }
        .Radio {
            padding:10px 10px 10px 10px;
        }
        .CheckBox {
            padding:10px 10px 10px 10px;
        }
        .buttonbox {
            padding:10px 10px 20px 10px;

        }   
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <TWebCtrl:WebCtrl ID="Header" runat="server" MinValue="500" />
        <div class="Myname">
            <asp:Label ID="lblName" runat="server" Text="Name" CssClass="Customizelabel" ></asp:Label>
            <asp:TextBox ID="txtName" runat="server" CssClass="Textboxatrributes" ></asp:TextBox>
        </div>
        <div class="listboxName">
            <asp:ListBox ID="lstKingnames" runat="server" SelectionMode="Multiple" Height="170px">
                <asp:ListItem Text="King of Mundacorp" Value="1"></asp:ListItem>
                <asp:ListItem Text="Konig von Mundacorp" Value="2"></asp:ListItem>
                <asp:ListItem Text="Rey de Mundacorp" Value="3"></asp:ListItem>
                <asp:ListItem Text="Kralj Mundacorpa" Value="4"></asp:ListItem>
                <asp:ListItem Text="Rei de Mundacorp" Value="5"></asp:ListItem>
                <asp:ListItem Text="Re di Mundacorp" Value="6"></asp:ListItem>
                <asp:ListItem Text="Roi de Mundacorp" Value="7"></asp:ListItem>
                <asp:ListItem Text="Kongen af Mundacorp" Value="8"></asp:ListItem>
                <asp:ListItem Text="Koning van Mundacorp" Value="9"></asp:ListItem>
                <asp:ListItem Text="Mundacorpin Kuningas" Value="10"></asp:ListItem>
            </asp:ListBox>
            
        </div>
        <div class="Radio">
            <div class="RadioButton1">
                <asp:RadioButton ID="RadioButtonKing" runat="server" GroupName="Options" Text="King" />
            </div>
            <div class="RadioButton2">
                <asp:RadioButton ID="RadioButtonQueen" runat="server" GroupName="Options" Text="Queen"  />
            </div>
            <div class="RadioButton3">
                <asp:RadioButton ID="RadioButtonServant" runat="server" GroupName="Options" Text="Servant"  />
            </div>
        </div>
        <div class="CheckBox">
            <div id="Checkbox1">
                <asp:CheckBox ID="CheckBoxLuminous" runat="server" Text="Orrak" />
            </div>
            <div class="Checkbox2">
                <asp:CheckBox ID="CheckBoxFire" runat="server" Text="Slyrak" />
            </div>
            <div class="Checkbox3">
                <asp:CheckBox ID="CheckBoxIonic" runat="server" Text="Indrak" />
            </div>
        </div>
            <div class="buttonbox">
                <asp:Button ID="Webbtn" runat="server" Text="Submit" CssClass="Buttoncolour" OnClick="Webbtn_Click"></asp:Button>
            </div>
            <div class="resultLabel">
               <asp:Label ID="ResultLabel" runat="server" CssClass="Customizelabel"></asp:Label>
            </div>  
        
    </form>
</body>
</html>
