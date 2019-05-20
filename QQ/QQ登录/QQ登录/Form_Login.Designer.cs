namespace QQ登录
{
    partial class Form_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Button_Login = new System.Windows.Forms.Button();
            this.Button_Register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.textBox_Acount = new System.Windows.Forms.TextBox();
            this.Button_FindPW = new System.Windows.Forms.Button();
            this.CheckBox_PW = new System.Windows.Forms.CheckBox();
            this.CheckBox_AutoLogin = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(80, 148);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(285, 38);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "登录";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.BackColor = System.Drawing.Color.White;
            this.Button_Register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_Register.FlatAppearance.BorderSize = 0;
            this.Button_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Register.Location = new System.Drawing.Point(3, 163);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(75, 23);
            this.Button_Register.TabIndex = 1;
            this.Button_Register.Text = "注册账号";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox_PW);
            this.panel1.Controls.Add(this.textBox_Acount);
            this.panel1.Controls.Add(this.Button_FindPW);
            this.panel1.Controls.Add(this.CheckBox_PW);
            this.panel1.Controls.Add(this.CheckBox_AutoLogin);
            this.panel1.Controls.Add(this.Button_Login);
            this.panel1.Controls.Add(this.Button_Register);
            this.panel1.Location = new System.Drawing.Point(-6, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 205);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(107, 71);
            this.textBox_PW.Multiline = true;
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(258, 24);
            this.textBox_PW.TabIndex = 6;
            // 
            // textBox_Acount
            // 
            this.textBox_Acount.Location = new System.Drawing.Point(107, 27);
            this.textBox_Acount.Multiline = true;
            this.textBox_Acount.Name = "textBox_Acount";
            this.textBox_Acount.Size = new System.Drawing.Size(258, 24);
            this.textBox_Acount.TabIndex = 5;
            // 
            // Button_FindPW
            // 
            this.Button_FindPW.BackColor = System.Drawing.Color.White;
            this.Button_FindPW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_FindPW.FlatAppearance.BorderSize = 0;
            this.Button_FindPW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.Button_FindPW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_FindPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FindPW.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_FindPW.Location = new System.Drawing.Point(302, 111);
            this.Button_FindPW.Name = "Button_FindPW";
            this.Button_FindPW.Size = new System.Drawing.Size(75, 23);
            this.Button_FindPW.TabIndex = 4;
            this.Button_FindPW.Text = "找回密码";
            this.Button_FindPW.UseVisualStyleBackColor = false;
            // 
            // CheckBox_PW
            // 
            this.CheckBox_PW.AutoSize = true;
            this.CheckBox_PW.ForeColor = System.Drawing.Color.DarkGray;
            this.CheckBox_PW.Location = new System.Drawing.Point(197, 115);
            this.CheckBox_PW.Name = "CheckBox_PW";
            this.CheckBox_PW.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_PW.TabIndex = 3;
            this.CheckBox_PW.Text = "记住密码";
            this.CheckBox_PW.UseVisualStyleBackColor = true;
            // 
            // CheckBox_AutoLogin
            // 
            this.CheckBox_AutoLogin.AutoSize = true;
            this.CheckBox_AutoLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.CheckBox_AutoLogin.Location = new System.Drawing.Point(81, 115);
            this.CheckBox_AutoLogin.Name = "CheckBox_AutoLogin";
            this.CheckBox_AutoLogin.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_AutoLogin.TabIndex = 2;
            this.CheckBox_AutoLogin.Text = "自动登录";
            this.CheckBox_AutoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox_AutoLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.Button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(426, 298);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QQ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.TextBox textBox_Acount;
        private System.Windows.Forms.Button Button_FindPW;
        private System.Windows.Forms.CheckBox CheckBox_PW;
        private System.Windows.Forms.CheckBox CheckBox_AutoLogin;
    }
}

