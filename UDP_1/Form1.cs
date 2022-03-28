using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UdpClient U;
        Thread Th;

        private void listen()
        {
            
            if (textBox_port.Text != null)//port不為空時 進入下列程式
            {
                int port = int.Parse(textBox_port.Text);
                U = new UdpClient(port);
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                while (true)
                {
                    byte[] B = U.Receive(ref EP);
                    textBox_ReceiveText.Text = Encoding.Default.GetString(B);
                }
            }            

        }
        /*rivate string myIP
        {
            string hostname = Dns.GetHostName();
        IPAddress[] ip = Dns.GetHostEntry();
        foreach(IPAddress it in)
            {
            if()
                {
                    return it
                }
            }

        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(listen);
            Th.Start();
            btn_ActiveReceive.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Th = new Thread(listen);
            Th.Start();
            
            try
            {                
                Th.Abort();
                U.Close();
            }
            catch
            {

            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string IP = textBox_tragetIP.Text;
            int port = int.Parse(textBox_targetport.Text);
            byte[] B = Encoding.Default.GetBytes(textBox_sendmsg.Text);
            UdpClient S = new UdpClient();
            S.Send(B,B.Length,IP,port);
            S.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
