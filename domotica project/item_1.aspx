<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="item_1.aspx.cs" Inherits="domotica_project.store_items.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="store_items/test.css"/>
    <style>
        .MortalBtn {
            display: inline-block;
            border-radius: 50%;
            background-color: #3d9970;
            border: none;
            color: #FFFFFF;
            text-align: center;
            font-size: 28px;
            padding: 20px 40px;
            width: 200px;
            height: 100px;
            transition: all 0.5s;
            cursor: pointer;
            margin: 5px 2px;
            opacity: 0.3;
            text-decoration: none;
        }

            .MortalBtn span {
                cursor: pointer;
                display: inline-block;
                position: relative;
                transition: 0.5s;
            }

                .MortalBtn span:after {
                    content: '\00bb';
                    position: absolute;
                    opacity: 0;
                    top: 0;
                    right: -20px;
                    transition: 0.5s;
                }

            .MortalBtn:hover span {
                padding-right: 25px;
            }

            .MortalBtn:hover {
                opacity: 1
            }

                .MortalBtn:hover span:after {
                    opacity: 1;
                    right: 0;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ImageUrl="https://i.imgur.com/97N7f0D.jpg" Height="220px" ID="ImgMK" runat="server" Width="376px" />
        <asp:LinkButton ID="BackBtn" CssClass="button" runat="server" OnClick="store" Height="60px" Width="150px">back to store</asp:LinkButton>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="mortal kombat html version"></asp:Label>
            </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="normally $1.99 now free"></asp:Label>
        </p>
        <p>
            <button class="MortalBtn" style="vertical-align:middle" onclick="unlock"> <span>buy</span> </button>
        </p>
    </form>
</body>
</html>
