using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QQ服务器
{
    public partial class QQ_Service : Form
    {
        public QQ_Service()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //与数据库建立连接
            string connectionStr = "Data Source=.;Initial catalog=DB;User ID=sa;pwd=165334;";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                if (conn.State != ConnectionState.Open) MessageBox.Show("数据库连接失败");
            }

        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Any;
            Monitor.Enabled = false;            // 按键使无法操作
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Point_Addr.Text));//创建IP+端口号对象
                socketWatch.Bind(point);            // 监听端口
                socketWatch.Listen(50);

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

        private void IP_Addr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
