namespace TimeSelector
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
            this.cbx_Year = new System.Windows.Forms.ComboBox();
            this.cbx_Month = new System.Windows.Forms.ComboBox();
            this.cbx_Day = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbx_Year
            // 
            this.cbx_Year.FormattingEnabled = true;
            this.cbx_Year.Location = new System.Drawing.Point(149, 107);
            this.cbx_Year.Name = "cbx_Year";
            this.cbx_Year.Size = new System.Drawing.Size(137, 26);
            this.cbx_Year.TabIndex = 0;
            this.cbx_Year.SelectedIndexChanged += new System.EventHandler(this.Cbx_Year_SelectedIndexChanged);
            // 
            // cbx_Month
            // 
            this.cbx_Month.FormattingEnabled = true;
            this.cbx_Month.Location = new System.Drawing.Point(316, 107);
            this.cbx_Month.Name = "cbx_Month";
            this.cbx_Month.Size = new System.Drawing.Size(137, 26);
            this.cbx_Month.TabIndex = 1;
            this.cbx_Month.SelectedIndexChanged += new System.EventHandler(this.Cbx_Month_SelectedIndexChanged);
            // 
            // cbx_Day
            // 
            this.cbx_Day.FormattingEnabled = true;
            this.cbx_Day.Location = new System.Drawing.Point(484, 107);
            this.cbx_Day.Name = "cbx_Day";
            this.cbx_Day.Size = new System.Drawing.Size(137, 26);
            this.cbx_Day.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_Day);
            this.Controls.Add(this.cbx_Month);
            this.Controls.Add(this.cbx_Year);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Year;
        private System.Windows.Forms.ComboBox cbx_Month;
        private System.Windows.Forms.ComboBox cbx_Day;
    }
}

