﻿namespace _02_MD5
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.bntConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(219, 54);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(326, 28);
            this.txtSrc.TabIndex = 0;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(219, 129);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(326, 28);
            this.txtDest.TabIndex = 1;
            // 
            // bntConvert
            // 
            this.bntConvert.Location = new System.Drawing.Point(329, 192);
            this.bntConvert.Name = "bntConvert";
            this.bntConvert.Size = new System.Drawing.Size(120, 50);
            this.bntConvert.TabIndex = 2;
            this.bntConvert.Text = "转换";
            this.bntConvert.UseVisualStyleBackColor = true;
            this.bntConvert.Click += new System.EventHandler(this.BntConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntConvert);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSrc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button bntConvert;
    }
}

