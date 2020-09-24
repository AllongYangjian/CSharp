namespace MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.titlebar_showChild = new System.Windows.Forms.ToolStripMenuItem();
            this.titlebar_horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.titlebar_vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titlebar_showChild,
            this.titlebar_horizontal,
            this.titlebar_vertical});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "toolbar";
            // 
            // titlebar_showChild
            // 
            this.titlebar_showChild.Name = "titlebar_showChild";
            this.titlebar_showChild.Size = new System.Drawing.Size(112, 28);
            this.titlebar_showChild.Text = "显示子窗体";
            this.titlebar_showChild.Click += new System.EventHandler(this.Titlebar_showChild_Click);
            // 
            // titlebar_horizontal
            // 
            this.titlebar_horizontal.Name = "titlebar_horizontal";
            this.titlebar_horizontal.Size = new System.Drawing.Size(94, 28);
            this.titlebar_horizontal.Text = "横向排列";
            this.titlebar_horizontal.Click += new System.EventHandler(this.Titlebar_horizontal_Click);
            // 
            // titlebar_vertical
            // 
            this.titlebar_vertical.Name = "titlebar_vertical";
            this.titlebar_vertical.Size = new System.Drawing.Size(94, 28);
            this.titlebar_vertical.Text = "纵向排列";
            this.titlebar_vertical.Click += new System.EventHandler(this.Titlebar_vertical_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem titlebar_showChild;
        private System.Windows.Forms.ToolStripMenuItem titlebar_horizontal;
        private System.Windows.Forms.ToolStripMenuItem titlebar_vertical;
    }
}

