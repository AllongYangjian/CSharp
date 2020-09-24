namespace FontAndColor
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
            this.btn_Color = new System.Windows.Forms.Button();
            this.btn_Font = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(148, 12);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(100, 36);
            this.btn_Color.TabIndex = 0;
            this.btn_Color.Text = "颜色";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.Btn_Color_Click);
            // 
            // btn_Font
            // 
            this.btn_Font.Location = new System.Drawing.Point(12, 12);
            this.btn_Font.Name = "btn_Font";
            this.btn_Font.Size = new System.Drawing.Size(100, 36);
            this.btn_Font.TabIndex = 1;
            this.btn_Font.Text = "字体";
            this.btn_Font.UseVisualStyleBackColor = true;
            this.btn_Font.Click += new System.EventHandler(this.Btn_Font_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(745, 339);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Font);
            this.Controls.Add(this.btn_Color);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.Button btn_Font;
        private System.Windows.Forms.TextBox textBox1;
    }
}

