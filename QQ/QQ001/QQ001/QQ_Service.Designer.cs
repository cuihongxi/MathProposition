namespace QQ001
{
    partial class Server
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
            this.ShowText = new System.Windows.Forms.TextBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Send = new System.Windows.Forms.Button();
            this.IP_Addr = new System.Windows.Forms.TextBox();
            this.Monitor = new System.Windows.Forms.Button();
            this.Point_Addr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowText
            // 
            this.ShowText.BackColor = System.Drawing.Color.White;
            this.ShowText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowText.Enabled = false;
            this.ShowText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ShowText.Location = new System.Drawing.Point(12, 75);
            this.ShowText.Multiline = true;
            this.ShowText.Name = "ShowText";
            this.ShowText.ReadOnly = true;
            this.ShowText.ShortcutsEnabled = false;
            this.ShowText.Size = new System.Drawing.Size(632, 354);
            this.ShowText.TabIndex = 0;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.Color.White;
            this.InputText.Location = new System.Drawing.Point(12, 464);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(632, 125);
            this.InputText.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.AutoSize = true;
            this.Button_Close.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Close.Location = new System.Drawing.Point(466, 559);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(78, 30);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Send
            // 
            this.Button_Send.AutoSize = true;
            this.Button_Send.Location = new System.Drawing.Point(550, 559);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(83, 30);
            this.Button_Send.TabIndex = 3;
            this.Button_Send.Text = "发送";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // IP_Addr
            // 
            this.IP_Addr.Location = new System.Drawing.Point(397, 44);
            this.IP_Addr.Name = "IP_Addr";
            this.IP_Addr.Size = new System.Drawing.Size(122, 21);
            this.IP_Addr.TabIndex = 4;
            this.IP_Addr.Text = "192.168.31.212";
            this.IP_Addr.TextChanged += new System.EventHandler(this.IP_Addr_TextChanged);
            // 
            // Monitor
            // 
            this.Monitor.Location = new System.Drawing.Point(277, 38);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(94, 30);
            this.Monitor.TabIndex = 5;
            this.Monitor.Text = "监听";
            this.Monitor.UseVisualStyleBackColor = true;
            this.Monitor.Click += new System.EventHandler(this.Monitor_Click);
            // 
            // Point_Addr
            // 
            this.Point_Addr.Location = new System.Drawing.Point(45, 44);
            this.Point_Addr.Name = "Point_Addr";
            this.Point_Addr.Size = new System.Drawing.Size(100, 21);
            this.Point_Addr.TabIndex = 6;
            this.Point_Addr.Text = "50000";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 612);
            this.Controls.Add(this.Point_Addr);
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.IP_Addr);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.ShowText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Server";
            this.Text = "Server";
            this.TransparencyKey = System.Drawing.Color.Chocolate;
            this.Load += new System.EventHandler(this.Dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowText;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox IP_Addr;
        private System.Windows.Forms.Button Monitor;
        private System.Windows.Forms.TextBox Point_Addr;
    }
}

