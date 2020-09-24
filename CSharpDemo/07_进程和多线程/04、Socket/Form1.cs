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
using System.IO;


namespace _04_Socket
{
    public partial class SocketForm : Form
    {
        private Dictionary<string, Socket> dict;

        public SocketForm()
        {
            InitializeComponent();
        }

        private void SocketForm_Load(object sender, EventArgs e)
        {
            dict = new Dictionary<string, Socket>();
            Control.CheckForIllegalCrossThreadCalls = false;
            ShowLocalIpAndPort();
        }

        /// <summary>
        /// 显示IP地址和端口
        /// </summary>
        private void ShowLocalIpAndPort()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry localhost = Dns.GetHostEntry(hostName);
            IPAddress[] address = localhost.AddressList;
            foreach(var item in address)
            {
                if(item.AddressFamily.ToString() == "InterNetwork")
                {
                    txt_Ip.Text = item.ToString();
                    break;
                }
            }
            txt_Port.Text = "5000";

            
        }

        /// <summary>
        /// 开启socket服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Listen_Click(object sender, EventArgs e)
        {
            Socket serverSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //获取地址
            IPAddress ip = IPAddress.Parse(txt_Ip.Text);
            //绑定地址和端口
            serverSocket.Bind(new IPEndPoint(ip, Convert.ToInt32(txt_Port.Text)));
            //设置最大连接数
            serverSocket.Listen(10);
            ShowMessage("监听成功");
            //开始监听socket
            Thread thread = new Thread(ListenSocket);
            thread.IsBackground = true;
            thread.Start(serverSocket);
        }

        /// <summary>
        /// 监听客户端socket
        /// </summary>
        /// <param name="obj"></param>
        private void ListenSocket(object obj)
        {
            Socket serverSocket = obj as Socket;
            while(true)
            {
                Socket socket = serverSocket.Accept();
                string host = socket.RemoteEndPoint.ToString();
                dict.Add(host, socket);
                cbx_IpSelect.Items.Add(host);
                ShowMessage(host+":连接成功");
                Thread thread = new Thread(ReceiveMessage);
                thread.Start(socket);
            }
        }

        private void ReceiveMessage(object o)
        {
            Socket socketSend = o as Socket;
            while(true)
            {

                byte[] buffer = new byte[1024];
                int length = socketSend.Receive(buffer);
                if (length == 0)
                {
                    break;
                }
                string str = Encoding.UTF8.GetString(buffer, 0, length);
                if(str.Equals("q"))
                {
                    break;
                }
                ShowMessage(socketSend.RemoteEndPoint + ":" + str);
            }
        }


        public void ShowMessage(string msg)
        {
            txt_ReceiveContent.AppendText(msg + "\r\n");
        }

        private void Btn_SendMsg_Click(object sender, EventArgs e)
        {
            string txt = txt_SendContent.Text;
            if (txt == null || txt.Length == 0)
            {
                MessageBox.Show("请填写要发送的内容");
                return;
            }
            SendMessage(txt);

        }

        private void SendMessage(string txt)
        {
            SendMessage(Encoding.UTF8.GetBytes(txt));
        }

        private void SendMessage(byte[] buffer)
        {
            object item = cbx_IpSelect.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("请选择客户端");
                return;
            }
            string host = item.ToString();

            Socket client = dict[host];
            if (client != null)
            {
                client.Send(buffer);
                if(txt_SelectFile.Text.Length>0)
                {
                    txt_SelectFile.Clear();
                }
            }
            else
            {
                MessageBox.Show("发送失败");
                dict.Remove(host);
            }
        }

        /// <summary>
        /// 选择发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "请选择要发送的文件";
            dlg.Filter = "文件文件|*.txt|全部文件|*.*";
            dlg.InitialDirectory = @"E:\VSProject\CSharpDemo\07_进程和多线程\05、SocketClient";
            dlg.ShowDialog();

            string path = dlg.FileName;
            txt_SelectFile.Text = path;
        }

        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SendFile_Click(object sender, EventArgs e)
        {
            string path = txt_SelectFile.Text;
            if(path == null || path.Length ==0)
            {
                MessageBox.Show("请选择要发送的文件");
                return;
            }
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int length = fs.Read(buffer,0,buffer.Length);
                string txt = Encoding.UTF8.GetString(buffer, 0, length);
                SendMessage(txt);
                
            }
        }
    }
}
