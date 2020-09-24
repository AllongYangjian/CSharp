namespace Notepad
{
    partial class Form1
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
            this.btn_wordwrap = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_wordwrap
            // 
            this.btn_wordwrap.Location = new System.Drawing.Point(3, 1);
            this.btn_wordwrap.Name = "btn_wordwrap";
            this.btn_wordwrap.Size = new System.Drawing.Size(211, 44);
            this.btn_wordwrap.TabIndex = 0;
            this.btn_wordwrap.Text = "自动换行";
            this.btn_wordwrap.UseVisualStyleBackColor = true;
            this.btn_wordwrap.Click += new System.EventHandler(this.btn_wordwrap_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(382, 1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(211, 44);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(3, 52);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(797, 386);
            this.txt_content.TabIndex = 2;
            this.txt_content.WordWrap = false;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(270, 117);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(271, 28);
            this.txt_username.TabIndex = 3;
            this.txt_username.WordWrap = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(270, 165);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(271, 28);
            this.txt_password.TabIndex = 4;
            this.txt_password.WordWrap = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(270, 213);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(120, 36);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_login.Location = new System.Drawing.Point(421, 213);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 36);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_wordwrap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// 显示登录界面
        /// </summary>
        private void ShowLoginView()
        {
            this.btn_wordwrap.Visible = false;
            this.btn_save.Visible = false;
            this.txt_content.Visible = false;

            this.txt_username.Visible = true;
            this.txt_password.Visible = true;
            this.btn_reset.Visible = true;
            this.btn_login.Visible = true;
        }

        /// <summary>
        /// 隐藏登录界面
        /// </summary>
        private void HideLoginView()
        {
            this.btn_wordwrap.Visible = true;
            this.btn_save.Visible = true;
            this.txt_content.Visible = true;

            this.txt_username.Visible = false;
            this.txt_password.Visible = false;
            this.btn_reset.Visible = false;
            this.btn_login.Visible = false;

            this.txt_content.Focus();
        }

        /// <summary>
        /// 重置登录界面
        /// </summary>
        private void ResetLoginView()
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        #endregion

        private System.Windows.Forms.Button btn_wordwrap;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_login;
    }
}

