using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_SocketClient
{
    public partial class FormClient : Form
    {
        private Socket clientSocket;
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ShowIpAddressAndPort()
        {
            txt_Port.Text = "5000";

            //string hostName = Dns.GetHostName();
            //IPHostEntry localHost =  Dns.GetHostEntry(hostName);

            //IPAddress[] address  =localHost.AddressList;
            //foreach(var item in address)
            //{
            //    if(item.AddressFamily.ToString() == "InterNetwork")
            //    {

            //        break;
            //    }
            //}
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            string ip = txt_IP.Text;
            string port = txt_Port.Text;
            if(ip.Length ==0 || port.Length ==0)
            {
                MessageBox.Show("请输入IP地址或端口");
                return;
            }

            try
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(new IPEndPoint(ipAddress, Convert.ToInt32(port)));
                ShowMessage("连接成功");
                Thread thread = new Thread(ReceiveMessage);
                thread.Start(clientSocket);
            }
            catch
            {
                MessageBox.Show("连接异常");
            }
            
        }

        private void ReceiveMessage(object o)
        {
            Socket socket = o as Socket;
            while(true)
            {
                byte[] buffer = new byte[1024];
                int length = socket.Receive(buffer);
                string txt = Encoding.UTF8.GetString(buffer, 0, length);

                ShowMessage(socket.RemoteEndPoint.ToString()+":"+txt);
            }
        }


        /// <summary>
        /// 显示接收的消息
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMessage(string msg)
        {
            txt_ReceiveContent.AppendText(msg + "\r\n");
        }

       /// <summary>
       /// 发送消息
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Btn_SendMsg_Click(object sender, EventArgs e)
        {
            if(clientSocket!=null)
            {
                string txt = txt_SendContent.Text;
                clientSocket.Send(Encoding.UTF8.GetBytes(txt));
                txt_SendContent.Clear();
            }
        }

        private void Vibrator()
        {
            for(int x = 0;x<10;x++)
            {
                int w = this.Location.X;
                int h = this.Location.Y;
                this.Location = new Point(w + 2, h + 2);
                this.Location = new Point(w ,h);
            }
        }
    }
}
