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
            Commandbuilder("Lamp 3");
        }

        protected void btnLamp1_Click(object sender, EventArgs e)
        {
            Commandbuilder("lamp 1");
        }

        protected void btnLamp0_Click(object sender, EventArgs e)
        {
            Commandbuilder("lamp 0");
        }

        protected void btnLamp2_Click(object sender, EventArgs e)
        {
            Commandbuilder("lamp 2");
        }

        protected void btnTemperature_Click(object sender, EventArgs e)
        {
            Commandbuilder("temp");
        }

        protected void btnWindow0_Click(object sender, EventArgs e)
        {
            Commandbuilder("window 0");
        }

        protected void btnWindow1_Click(object sender, EventArgs e)
        {
            Commandbuilder("window 1");
        }

        protected void btnLamp4_Click(object sender, EventArgs e)
        {
            Commandbuilder("lamp 4");
        }
        void Commandbuilder(string obj)
        {
            if (client.Connected)
            {
                NetworkStream cmdstream = client.GetStream();
                string command = "";

                if (obj == "temp")
                {
                    command = "heater " + txtTemperature.Text;
                }
                else
                {
                    if ((bool)Application[obj])
                    {
                        if (obj.Contains("lamp"))
                        {
                            command = obj + " on\n";
                        }
                        else
                        {
                            command = obj + " close\n";
                        }

                    }
                    else
                    {
                        if (obj.Contains("lamp"))
                        {
                            command = obj + " off\n";
                        }
                        else
                        {
                            command = obj + " open\n";
                        }
                    }
                }
                byte[] bcommand = Encoding.ASCII.GetBytes(command);
                cmdstream.Write(bcommand, 0, bcommand.Length);
                Application[obj] = !((bool)Application[obj]);
            }
            else
            {

            }
        }

    }
}