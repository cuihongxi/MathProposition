using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace QQ登录
{
    public partial class Form_Login : Form
    {
        Socket socketSend;
        public Form_Login()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("192.168.31.212");   // 将IP文本框字符串转换成IP地址类型
            Button_Login.Enabled = false;                      // 按键使无法操作
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint point = new IPEndPoint(ip,50000);//创建IP+端口号对象
                try
                { 
                    socketSend.Connect(point);                      // 连接远程端口
                }catch()
                {

                }

                

                Thread th = new Thread(Talk);
                th.IsBackground = true;
                th.Start(socketSend);
            }
            catch { }

        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            Form_Register form_register = new Form_Register();
            form_register.Show();
        }
    }
}
