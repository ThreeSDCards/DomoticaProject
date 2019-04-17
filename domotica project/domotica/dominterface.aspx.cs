using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.Drawing;
using System.Net.Sockets;

namespace domotica_project.domotica
{
    public partial class dominterface : System.Web.UI.Page
    {
        public static TcpClient client = new TcpClient();

        string LAMP4ON = "lamp 4 on";
        string LAMP4OFF = "lamp 4 off";

        string LAMP3ON = "lamp 3 on";
        string LAMP3OFF = "lamp 3 off";

        string LAMP2ON = "lamp 2 on";
        string LAMP2OFF = "lamp 2 off";

        string LAMP1ON = "lamp 1 on";
        string LAMP1OFF = "lamp 1 off";

        string LAMP0ON = "lamp 0 on";
        string LAMP0OFF = "lamp 0 off";

        string WINDOW0ON = "window 0 open";
        string WINDOW0OFF = "window 0 close";

        string WINDOW1ON = "window 1 open";
        string WINDOW1OFF = "window 1 close";

        protected void Page_Load(object sender, EventArgs e)
        {
            lblConStatus.Text = ConnectionStatus();
            if (client.Connected)
            {
                lblConStatus.ForeColor = Color.Green;
            }
            else
            {
                lblConStatus.ForeColor = Color.Red;
            }
        }

        protected void btnVerbinden_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                try
                {
                    client.Connect(new IPEndPoint(IPAddress.Loopback, 11000));

                    lblConStatus.Text = ConnectionStatus();
                    if (client.Connected)
                    {
                        lblConStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblConStatus.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {

            }
        }
        public static string ConnectionStatus()
        {
            if (client.Connected)
            {
                return "Online";
            }
            else
            {
                return "Offline";
            }
        }

        protected void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                client.GetStream().Close();
                client.Close();

                lblConStatus.Text = ConnectionStatus();
                if (client.Connected)
                {
                    lblConStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblConStatus.ForeColor = Color.Red;
                }
            }
            else
            {

            }
        }

        protected void btnLamp3_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if (!(bool)Application["Lamp3"])
                {
                    LAMP3ON += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(LAMP3ON);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Lamp3"] = true;
                }

                else
                {
                    LAMP3OFF += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(LAMP3OFF);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Lamp3"] = false;
                }
            }
            else
            {

            }
        }

        protected void btnLamp1_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if (!(bool)Application["Lamp1"])
                {
                    LAMP1ON += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(LAMP1ON);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Lamp1"] = true;
                }

                else
                {
                    LAMP1OFF += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(LAMP1OFF);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Lamp1"] = false;
                }
            }
            else
            {

            }
        }

        protected void btnLamp0_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if (!(bool)Application["Lamp0"])
                {
                    LAMP0ON += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(LAMP0ON);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Lamp0"] = true;
                }

                else
                {
                    LAMP0OFF += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(LAMP0OFF);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Lamp0"] = false;
                }
            }
        }

        protected void btnLamp2_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if (!(bool)Application["Lamp2"])
                {
                    LAMP2ON += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(LAMP2ON);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Lamp2"] = true;
                }

                else
                {
                    LAMP2OFF += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(LAMP2OFF);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Lamp2"] = false;
                }
            }
        }

        protected void btnTemperature_Click(object sender, EventArgs e)
        {
            string tempcommand = "heater " + txtTemperature.Text;

            NetworkStream stream = client.GetStream();
            tempcommand += Environment.NewLine;
            byte[] bcommand = Encoding.ASCII.GetBytes(tempcommand);
            stream.Write(bcommand, 0, bcommand.Length);
        }

        protected void btnWindow0_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if ((bool)Application["Window0"])
                {
                    WINDOW0OFF += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(WINDOW0OFF);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Window0"] = false;
                }

                else
                {
                    WINDOW0ON += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(WINDOW0ON);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Window0"] = true;
                }
            }
        }

        protected void btnWindow1_Click(object sender, EventArgs e)
        {

            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if ((bool)Application["Window1"])
                {
                    WINDOW1OFF += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(WINDOW1OFF);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Window1"] = false;
                }

                else
                {
                    WINDOW1ON += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(WINDOW1ON);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Window1"] = true;
                }
            }
        }

        protected void btnLamp4_Click(object sender, EventArgs e)
        {

            if (client.Connected)
            {
                NetworkStream commandstream = client.GetStream();

                if (!(bool)Application["Lamp4"])
                {
                    LAMP4ON += Environment.NewLine;
                    byte[] bLampOn = Encoding.ASCII.GetBytes(LAMP4ON);
                    commandstream.Write(bLampOn, 0, bLampOn.Length);
                    commandstream.Flush();
                    Application["Lamp4"] = true;
                }

                else
                {
                    LAMP4OFF += Environment.NewLine;
                    byte[] bLampOff = Encoding.ASCII.GetBytes(LAMP4OFF);
                    commandstream.Write(bLampOff, 0, bLampOff.Length);
                    Application["Lamp4"] = false;
                }
            }
            else
            {

            }
        }
    }
}