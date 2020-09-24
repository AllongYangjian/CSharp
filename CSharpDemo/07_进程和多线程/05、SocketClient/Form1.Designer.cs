namespace _05_SocketClient
{
    partial class FormClient
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_ReceiveContent = new System.Windows.Forms.TextBox();
            this.txt_SendContent = new System.Windows.Forms.TextBox();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(12, 12);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(197, 28);
            this.txt_IP.TabIndex = 0;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(226, 12);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(92, 28);
            this.txt_Port.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(376, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(96, 28);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // txt_ReceiveContent
            // 
            this.txt_ReceiveContent.Location = new System.Drawing.Point(12, 55);
            this.txt_ReceiveContent.Multiline = true;
            this.txt_ReceiveContent.Name = "txt_ReceiveContent";
            this.txt_ReceiveContent.Size = new System.Drawing.Size(776, 159);
            this.txt_ReceiveContent.TabIndex = 3;
            // 
            // txt_SendContent
            // 
            this.txt_SendContent.Location = new System.Drawing.Point(12, 232);
            this.txt_SendContent.Multiline = true;
            this.txt_SendContent.Name = "txt_SendContent";
            this.txt_SendContent.Size = new System.Drawing.Size(776, 159);
            this.txt_SendContent.TabIndex = 4;
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(676, 410);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(112, 28);
            this.btn_SendMsg.TabIndex = 5;
            this.btn_SendMsg.Text = "发送消息";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.Btn_SendMsg_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SendMsg);
            this.Controls.Add(this.txt_SendContent);
            this.Controls.Add(this.txt_ReceiveContent);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Name = "FormClient";
            this.Text = "Socket客户端";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_ReceiveContent;
        private System.Windows.Forms.TextBox txt_SendContent;
        private System.Windows.Forms.Button btn_SendMsg;
    }
}

