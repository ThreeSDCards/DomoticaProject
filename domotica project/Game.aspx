<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="domotica_project.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="test.css"/>
    <style>
        .button {
            
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
     <div class="btn-group">
        <h2>A nice game of snake</h2>

        <a href="snake.html"><img src="figures/snake.PNG"/></a>

        <h2>Or a game of flappy block</h2>

        <a href="block.html"><img src="figures/flappy.PNG"/></a>

        <h2>Or maybe a racing game</h2>

        <a href="https://codeincomplete.com/games/racer/v4-final/"><img src="figures/race.PNG"/></a>

    </div>
    <div class="btn-group">
        <h2>But maybe just mortal kombat</h2>

        <a href="https://mk.mgechev.com/"><img src="figures/mortal.PNG"/></a>

        <h2>or how about browser quest</h2>

        <a href="http://browserquest.mozilla.org/"><img src="figures/browser.PNG"/></a>

        <h2>maybe a plane ride</h2>

        <a href="https://playcanv.as/p/JtL2iqIH/"><img src="figures/airplanes.PNG"/></a>
    </div>
    <div class="btn-group">
        <h2>a space racer perhaps</h2>

        <a href="http://hexgl.bkcore.com/play/"><img src="figures/future.PNG"/></a>

        <h2>The last thing i can offer is a wizard game</h2>

        <a href="https://hypnoticowl.com/games/the-wizard/play/"><img src="figures/wizard.PNG"/></a>

         <h2>I lied but dont show the kids this one.</h2>

        <a href="https://js-dos.com/games/doom.exe.html"><img src="figures/doom.PNG"/></a>
        
     </div>

    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="MainMenuBtn" runat="server" OnClick="mainmenu" Height="60px" Width="150px" ImageUrl="~/figures/return_blue_even_bigger.png"/>
        </div>
    </form>
</body>
</html>
