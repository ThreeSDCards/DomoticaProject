<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainMenu.aspx.cs" Inherits="domotica_project.mainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="test.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="dahouse" runat="server" onclick="house" ImageUrl="~/figures/button_TL.png"/>
            <asp:ImageButton ID="Extra" runat="server" OnClick="desp" ImageUrl="~/figures/button_TR.png" />
        </div>
            <asp:ImageButton ID="store" runat="server" onclick="cons" ImageUrl="~/figures/button_BL.png"/>
            <asp:ImageButton ID="game" runat="server" onclick="gam" ImageUrl="~/figures/button_BR.png" ImageAlign="Top"/>
    </form>
</body>
</html>

