using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QQ登录
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=.;Initial catalog=DB;User ID=sa;pwd=165334;";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();                        //启动连接
                if (conn.State != ConnectionState.Open) MessageBox.Show("数据库连接失败");
                else
                { 
                    string comStr = "INSERT INTO [DB].[dbo].[Article]([name],[passWord])VALUES(@value_name,@value_passWord)";
                    SqlCommand com = new SqlCommand(comStr, conn);
                    com.CommandTimeout = 10;         //设定超时时间，单位秒
                    com.Connection = conn;
                    SqlParameter param_name = new SqlParameter("@value_name", SqlDbType.NVarChar, 50);
                    param_name.Direction = ParameterDirection.Input;
                    param_name.Value = textBox_Name.Text;

                    SqlParameter param_passWord = new SqlParameter("@value_passWord", SqlDbType.NVarChar, 50);
                    param_passWord.Direction = ParameterDirection.Input;
                    param_passWord.Value = textBox_PW.Text;

                    com.Parameters.Add(param_name);
                    com.Parameters.Add(param_passWord);
                    int res = 0;
                    try 
                    {
                        res = com.ExecuteNonQuery();

                    }catch(System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("该用户已经注册");
                    }
                    if (res != 0)
                    { 
                        MessageBox.Show("注册成功");
                        this.Close();
                    } 
                    
              
                }

            }
        }
    }
}
