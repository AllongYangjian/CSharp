namespace RadioButtonCheckBox
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
            this.lb_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.rb_role = new System.Windows.Forms.GroupBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.rb_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(267, 76);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(62, 18);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "用户名";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(364, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(168, 28);
            this.txt_username.TabIndex = 1;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(267, 120);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(44, 18);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "密码";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(364, 115);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(168, 28);
            this.txt_password.TabIndex = 3;
            // 
            // rb_role
            // 
            this.rb_role.Controls.Add(this.rb_male);
            this.rb_role.Controls.Add(this.rb_female);
            this.rb_role.Location = new System.Drawing.Point(270, 162);
            this.rb_role.Name = "rb_role";
            this.rb_role.Size = new System.Drawing.Size(262, 39);
            this.rb_role.TabIndex = 4;
            this.rb_role.TabStop = false;
            this.rb_role.Text = "角色";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(94, 11);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(51, 22);
            this.rb_male.TabIndex = 0;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "男";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(211, 11);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(51, 22);
            this.rb_female.TabIndex = 1;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "女";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(270, 207);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 40);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(422, 207);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 40);
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
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.rb_role);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rb_role.ResumeLayout(false);
            this.rb_role.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.GroupBox rb_role;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
    }
}

