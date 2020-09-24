namespace demo1
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
            this.btn_love = new System.Windows.Forms.Button();
            this.btn_not_love = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_love
            // 
            this.btn_love.Location = new System.Drawing.Point(99, 106);
            this.btn_love.Name = "btn_love";
            this.btn_love.Size = new System.Drawing.Size(94, 43);
            this.btn_love.TabIndex = 0;
            this.btn_love.Text = "爱";
            this.btn_love.UseVisualStyleBackColor = true;
            this.btn_love.Click += new System.EventHandler(this.btn_love_Click);
            // 
            // btn_not_love
            // 
            this.btn_not_love.Location = new System.Drawing.Point(431, 106);
            this.btn_not_love.Name = "btn_not_love";
            this.btn_not_love.Size = new System.Drawing.Size(94, 43);
            this.btn_not_love.TabIndex = 1;
            this.btn_not_love.Text = "不爱";
            this.btn_not_love.UseVisualStyleBackColor = true;
            this.btn_not_love.Click += new System.EventHandler(this.btn_not_love_Click);
            this.btn_not_love.MouseEnter += new System.EventHandler(this.btn_not_love_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_not_love);
            this.Controls.Add(this.btn_love);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_love;
        private System.Windows.Forms.Button btn_not_love;
    }
}

