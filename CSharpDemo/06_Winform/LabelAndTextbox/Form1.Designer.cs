namespace LabelAndTextbox
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(240, 82);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(283, 101);
            this.txtWords.TabIndex = 0;
            this.txtWords.TextChanged += new System.EventHandler(this.txtWords_TextChanged);
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(346, 217);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(0, 18);
            this.label_value.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.txtWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label label_value;
    }
}

