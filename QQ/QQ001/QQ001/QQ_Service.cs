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

namespace QQ001
{
    public partial class Server : Form
    {
        Socket socketSend;
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();    //建立字典
        public Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;        //不检查错误线程
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }



        //监听
        private void Monitor_Click(object sender, EventArgs e)
        {    
            IPAddress ip = IPAddress.Any;
            Monitor.Enabled = false;            // 按键使无法操作
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Point_Addr.Text));//创建IP+端口号对象
                socketWatch.Bind(point);            // 监听端口
                socketWatch.Listen(10);

                Thread th = new Thread(Listener);
                th.IsBackground = true;             // 后台程序
                th.Start(socketWatch);              // 开启线程
            }
            catch { }




        }
       
        //文本框中显示SOCKET的信息
        private void SocketMsg(string str)
        {
            ShowText.AppendText(str + "\r\n");
        }
        //监听线程函数
        private void Listener(object o)
        {

            Socket so = o as Socket;
            try
            {
                while (true)                                    // 监听连接
                {

                    //等待客户端的连接,并且创建一个负责通讯的socket
                    socketSend = so.Accept();
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);    //存入字典
                    Thread th = new Thread(Talk);
                    th.IsBackground = true;                     // 后台程序
                    th.Start(socketSend);                       // 开启线程

                }
            }
            catch { }

        }

        //聊天线程
        private void Talk(object o)
        {
            Socket so = o as Socket;
            try
            {
                SocketMsg("\r\n" + so.RemoteEndPoint.ToString() + " ： 连接成功");
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

        //发送消息
        private void Button_Send_Click(object sender, EventArgs e)
        {
            string str = InputText.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);        // 将字符串转换成字节数组
           // socketSend.Send(buffer,buffer.Length,SocketFlags.None);       // 通过SOCKET发送 
            if (IP_Addr.Text.Contains(":"))
                dicSocket[IP_Addr.Text].Send(buffer, buffer.Length, SocketFlags.None); // 根据字典中的key找到，通过SOCKET发送 
            else MessageBox.Show("请输入端口号！");
            InputText.Text = null; //清空发送的消息

        }

        private void IP_Addr_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
