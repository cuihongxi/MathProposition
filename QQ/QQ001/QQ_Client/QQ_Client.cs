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
using System.Windows.Forms;

namespace QQ_Client
{
    public partial class Client : Form
    {
        Socket socketSend;
        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //文本框中显示SOCKET的信息
        private void SocketMsg(string str)
        {
            ShowText.AppendText(str + "\r\n");
        }

        private void Connet_Button_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(IP_Addr.Text);       // 将IP文本框字符串转换成IP地址类型
            Connet_Button.Enabled = false;                      // 按键使无法操作
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Point_Addr.Text));//创建IP+端口号对象
                socketSend.Connect(point);                      // 连接远程端口
                SocketMsg("连接成功");                           //提示信息

                Thread th = new Thread(Talk);
                th.IsBackground = true;
                th.Start(socketSend);
            }
            catch { }
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            string str = InputText.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);    // 将字符串转换成字节数组
            socketSend.Send(buffer, buffer.Length, SocketFlags.None);   // 通过SOCKET发送 

            InputText.Text = null; //清空发送的消息
        }

        //聊天线程
        private void Talk(object o)
        {
            Socket so = o as Socket;
            try
            {
     //           SocketMsg("\r\n" + so.RemoteEndPoint.ToString() + " ： 连接成功");
                while (true)                         // 监听客户端发来的消息
                {
                    byte[] buffer = new byte[1024];
                    int r = so.Receive(buffer);
                    if (r == 0) break;
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    SocketMsg(so.RemoteEndPoint + ":" + str);
                }
            }
            catch { }

        }

        private void IP_Addr_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
