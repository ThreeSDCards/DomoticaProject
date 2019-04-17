<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="store.aspx.cs" Inherits="domotica_project.NewFolder1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" type="text/css" href="test.css"/>
    <style>
        .button {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            display: inline-block;
            border-radius: 50%;
            background-color: #3d9970;
            color: #FFFFFF;
            text-align: center;
            font-size: 28px;
            padding: 20px 40px;
            width: 200px;
            height: 100px;
            transition: all 0.5s;
            cursor: pointer;
            margin: 0px 2px 5px 2px;
            opacity: 0.3;
            text-decoration: none;
        }

            .button span {
                cursor: pointer;
                display: inline-block;
                position: relative;
                transition: 0.5s;
            }

                .button span:after {
                    content: '\00bb';
                    position: absolute;
                    opacity: 0;
                    top: 0;
                    right: -20px;
                    transition: 0.5s;
                }

            .button:hover span {
                padding-right: 25px;
            }

            .button:hover {
                opacity: 1
            }

                .button:hover span:after {
                    opacity: 1;
                    right: 0;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Image ID="ImgConstruction" runat="server" style="margin-top: 4px" ImageUrl="~/figures/coming_soon.png" />
            <asp:ImageButton ID="MainMenuBtn" runat="server" OnClick="mainmenu" Height="60px" Width="150px" ImageUrl="~/figures/return_blue_even_bigger.png"/>
        <div>
        </div>
    </form>
</body>
</html>
