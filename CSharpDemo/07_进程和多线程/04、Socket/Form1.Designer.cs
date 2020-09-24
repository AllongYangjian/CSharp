namespace _04_Socket
{
    partial class SocketForm
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
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.cbx_IpSelect = new System.Windows.Forms.ComboBox();
            this.txt_ReceiveContent = new System.Windows.Forms.TextBox();
            this.txt_SendContent = new System.Windows.Forms.TextBox();
            this.txt_SelectFile = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.btn_vibrator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(12, 12);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(220, 28);
            this.txt_Ip.TabIndex = 0;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(265, 12);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(99, 28);
            this.txt_Port.TabIndex = 1;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(405, 12);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(96, 28);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "开始监听";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.Btn_Listen_Click);
            // 
            // cbx_IpSelect
            // 
            this.cbx_IpSelect.FormattingEnabled = true;
            this.cbx_IpSelect.Location = new System.Drawing.Point(529, 12);
            this.cbx_IpSelect.Name = "cbx_IpSelect";
            this.cbx_IpSelect.Size = new System.Drawing.Size(259, 26);
            this.cbx_IpSelect.TabIndex = 3;
            // 
            // txt_ReceiveContent
            // 
            this.txt_ReceiveContent.Location = new System.Drawing.Point(12, 46);
            this.txt_ReceiveContent.Multiline = true;
            this.txt_ReceiveContent.Name = "txt_ReceiveContent";
            this.txt_ReceiveContent.Size = new System.Drawing.Size(776, 152);
            this.txt_ReceiveContent.TabIndex = 4;
            // 
            // txt_SendContent
            // 
            this.txt_SendContent.Location = new System.Drawing.Point(12, 218);
            this.txt_SendContent.Multiline = true;
            this.txt_SendContent.Name = "txt_SendContent";
            this.txt_SendContent.Size = new System.Drawing.Size(776, 152);
            this.txt_SendContent.TabIndex = 5;
            // 
            // txt_SelectFile
            // 
            this.txt_SelectFile.Location = new System.Drawing.Point(12, 392);
            this.txt_SelectFile.Name = "txt_SelectFile";
            this.txt_SelectFile.Size = new System.Drawing.Size(352, 28);
            this.txt_SelectFile.TabIndex = 6;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(384, 392);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(96, 28);
            this.btn_Select.TabIndex = 7;
            this.btn_Select.Text = "选择";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(486, 392);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(96, 28);
            this.btn_SendFile.TabIndex = 8;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.Btn_SendFile_Click);
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(588, 392);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(96, 28);
            this.btn_SendMsg.TabIndex = 9;
            this.btn_SendMsg.Text = "发送消息";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.Btn_SendMsg_Click);
            // 
            // btn_vibrator
            // 
            this.btn_vibrator.Location = new System.Drawing.Point(692, 392);
            this.btn_vibrator.Name = "btn_vibrator";
            this.btn_vibrator.Size = new System.Drawing.Size(96, 28);
            this.btn_vibrator.TabIndex = 10;
            this.btn_vibrator.Text = "震动";
            this.btn_vibrator.UseVisualStyleBackColor = true;
            // 
            // SocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.btn_vibrator);
            this.Controls.Add(this.btn_SendMsg);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.txt_SelectFile);
            this.Controls.Add(this.txt_SendContent);
            this.Controls.Add(this.txt_ReceiveContent);
            this.Controls.Add(this.cbx_IpSelect);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_Ip);
            this.Name = "SocketForm";
            this.Text = "Socket编程";
            this.Load += new System.EventHandler(this.SocketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ComboBox cbx_IpSelect;
        private System.Windows.Forms.TextBox txt_ReceiveContent;
        private System.Windows.Forms.TextBox txt_SendContent;
        private System.Windows.Forms.TextBox txt_SelectFile;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_SendMsg;
        private System.Windows.Forms.Button btn_vibrator;
    }
}

