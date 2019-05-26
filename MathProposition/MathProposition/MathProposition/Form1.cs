using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathProposition
{
    public partial class Form_main : Form
    {
        Random rd;
        private  const int RAND_MAX = 100000;   //最大的随机变量

        int result1 = 0;
        int result2 = 0;
        int result3 = 0;
        int result4 = 0;
        int result5 = 0;

        public Form_main()
        {
            InitializeComponent();
            rd = new Random();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_checkPic2_Click(object sender, EventArgs e)
        {

        }
        // 列出随机的算术式
        int ListMathPropo(TextBox textbox)
        {
            int result = 0;
            
            //随机一个算法+-*
            byte[] str = { (byte)'+', (byte)'-', (byte)'*' };
            int math = rd.Next(3);

            //随机两个参数
            int param1 = rd.Next(RAND_MAX);
            int param2 = rd.Next(RAND_MAX);
            if (str[math] == (byte)'-')         // param2<param1，保证没有负数计算
            {
                while (param2 >= param1)
                {
                    param1 = rd.Next(RAND_MAX);
                    param2 = rd.Next(RAND_MAX); // 重新获取随机值
                }
                result = param1 - param2;

            }
            else if (str[math] == (byte)'*')    //param2得是小于10的
            {
                param1 = rd.Next(1000,RAND_MAX);
                param2 = rd.Next(2,10); // 重新获取随机值
                result = param1 * param2;
            }
            else result = param1 + param2;
             
            //显示字符串
            textbox.AppendText(param1.ToString());
            textbox.AppendText(" ");
            textbox.AppendText(Encoding.ASCII.GetString(str, math, 1));
            textbox.AppendText(" ");
            textbox.AppendText(param2.ToString());
            return result;
        }
        private void button_malloc_propo_Click(object sender, EventArgs e)
        {
            // 清空对错图片
            pictureBox_checkPic1.Image = null;
            pictureBox_checkPic2.Image = null;
            pictureBox_checkPic3.Image = null;
            pictureBox_checkPic4.Image = null;
            pictureBox_checkPic5.Image = null;

            textBox_coding1.Text = null;
            textBox_coding2.Text = null;
            textBox_coding3.Text = null;
            textBox_coding4.Text = null;
            textBox_coding5.Text = null;

            textBox_result1.Text = null;
            textBox_result2.Text = null;
            textBox_result3.Text = null;
            textBox_result4.Text = null;
            textBox_result5.Text = null;

            // 列出随机的算术式

            result1 = ListMathPropo(textBox_coding1);
            result2 = ListMathPropo(textBox_coding2);
            result3 = ListMathPropo(textBox_coding3);
            result4 = ListMathPropo(textBox_coding4);
            result5 = ListMathPropo(textBox_coding5);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rd.Next(RAND_MAX);
        }

        //图片判断结果
        private void Picture_result(TextBox textbox, int result, PictureBox pictureBox)
        {
            try
            {
                if (textbox.Text != null && textbox.Text != "")
                {
            
                    if (result == Convert.ToInt32(textbox.Text))
                        pictureBox.Image = global::MathProposition.Properties.Resources.correct;
                    else
                        pictureBox.Image = global::MathProposition.Properties.Resources.wrong;
                }
            }catch
            {
                pictureBox.Image = global::MathProposition.Properties.Resources.wrong;
           
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //结果判断
            Picture_result(textBox_result1,result1,pictureBox_checkPic1);
            Picture_result(textBox_result2, result2, pictureBox_checkPic2);
            Picture_result(textBox_result3, result3, pictureBox_checkPic3);
            Picture_result(textBox_result4, result4, pictureBox_checkPic4);
            Picture_result(textBox_result5, result5, pictureBox_checkPic5);
        }
    }
}
