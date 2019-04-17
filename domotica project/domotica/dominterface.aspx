<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dominterface.aspx.cs" Inherits="domotica_project.domotica.dominterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="dom.css"/>
</head>
<body>
    <form id="form1" runat="server">
            <span style="COLOR: greenyellow">Connection Status:</span>
            <asp:Label ID="lblConStatus" runat="server" Text="" CssClass="label"></asp:Label>
            <asp:Button ID="btnLamp3" runat="server" Text="Lamp 3" Height="80px" Width="117px" OnClick="btnLamp3_Click" style="z-index: 1; left: 79px; top: 210px; position: absolute"/>
            <asp:Button ID="btnLamp2" runat="server" Text="Lamp 2" Height ="80px" Width="117px" OnClick="btnLamp2_Click" style="z-index: 1; left: 514px; top: 210px; position: absolute" />
            <asp:Button ID="btnLamp1" runat="server" Text="Lamp 1" Height="80px" Width="117px" OnClick="btnLamp1_Click" style="z-index: 1; left: 81px; top: 402px; position: absolute"/>
            <asp:Button ID="btnLamp0" runat="server" Text="Lamp 0" Height="80px" Width="117px" OnClick="btnLamp0_Click" style="z-index: 1; left: 515px; top: 401px; position: absolute"/>
            <asp:Button ID="btnVerbinden" runat="server" Height="60px" Text="Connect" Width="223px" OnClick="btnVerbinden_Click" style="z-index: 1; left: 144px; top: 532px; position: absolute"/>
            <asp:Button ID="btnDisconnect" runat="server" Height="60px" Text="Disconnect" Width="93px" OnClick="btnDisconnect_Click" style="z-index: 1; left: 464px; top: 532px; position: absolute" />
            <asp:TextBox ID="txtTemperature" runat="server" style="z-index: 1; left: 268px; top: 438px; position: absolute; width: 64px"></asp:TextBox>
            <asp:Button ID="btnTemperature" runat="server" style="z-index: 1; left: 353px; top: 435px; position: absolute" Text="Update" OnClick="btnTemperature_Click" />
            <asp:Button ID="btnWindow0" runat="server" style="z-index: 1; left: 201px; top: 305px; position: absolute" Text="Window 0" Height="80px" Width="117px" OnClick="btnWindow0_Click"/>
            <asp:Button ID="btnWindow1" runat="server" style="z-index: 1; left: 370px; top: 306px; position: absolute" Text="Window 1" Height="80px" Width="117px" OnClick="btnWindow1_Click"/>
            <asp:Button ID="btnLamp4" runat="server" style="z-index: 1; left: 288px; top: 182px; position: absolute" Text="Lamp 4" Height="80px" Width="117px" OnClick="btnLamp4_Click"/>
    </form>
</body>
</html>
