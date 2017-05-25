using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace skaner_portow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skanuj_Click(object sender, EventArgs e)
        {
            short[] ListaPortow = { 20, 21, 22, 24, 25, 27, 87, 55, 43, 87, 43 };
            string host = adres.Text;
            info.Items.Add("Skanuje: " + host);
            info.Items.Add("To moze chwile potrwac");
            foreach(short port in ListaPortow)
            { this.Refresh();
              try
                {
                    TcpClient klient = new TcpClient(host, port);
                    info.Items.Add("port: " + port.ToString() + "jest otwarty"); 
                }
                catch
                {
                    info.Items.Add("port: " + port.ToString() + "jest zamkniety");
                }
            }

        }
    }
}
