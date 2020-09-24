namespace Notebook
{
    partial class MainContainer
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
            this.menu_Toolbar = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_AutoEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.打开记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ShowRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_HideRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.btn_ShowRecord = new System.Windows.Forms.Button();
            this.list_Record = new System.Windows.Forms.ListBox();
            this.menu_Toolbar.SuspendLayout();
            this.panel_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Toolbar
            // 
            this.menu_Toolbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.样式ToolStripMenuItem,
            this.打开记录ToolStripMenuItem});
            this.menu_Toolbar.Location = new System.Drawing.Point(0, 0);
            this.menu_Toolbar.Name = "menu_Toolbar";
            this.menu_Toolbar.Size = new System.Drawing.Size(800, 32);
            this.menu_Toolbar.TabIndex = 0;
            this.menu_Toolbar.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Open,
            this.MenuItem_Save});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.Size = new System.Drawing.Size(128, 30);
            this.MenuItem_Open.Text = "打开";
            this.MenuItem_Open.Click += new System.EventHandler(this.MenuItem_Open_Click);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.Size = new System.Drawing.Size(128, 30);
            this.MenuItem_Save.Text = "保存";
            this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_AutoEnter});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // MenuItem_AutoEnter
            // 
            this.MenuItem_AutoEnter.Name = "MenuItem_AutoEnter";
            this.MenuItem_AutoEnter.Size = new System.Drawing.Size(179, 30);
            this.MenuItem_AutoEnter.Text = "☆自动换行";
            this.MenuItem_AutoEnter.Click += new System.EventHandler(this.MenuItem_AutoEnter_Click);
            // 
            // 样式ToolStripMenuItem
            // 
            this.样式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Font,
            this.MenuItem_Color});
            this.样式ToolStripMenuItem.Name = "样式ToolStripMenuItem";
            this.样式ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.样式ToolStripMenuItem.Text = "样式";
            // 
            // MenuItem_Font
            // 
            this.MenuItem_Font.Name = "MenuItem_Font";
            this.MenuItem_Font.Size = new System.Drawing.Size(252, 30);
            this.MenuItem_Font.Text = "字体";
            this.MenuItem_Font.Click += new System.EventHandler(this.MenuItem_Font_Click);
            // 
            // MenuItem_Color
            // 
            this.MenuItem_Color.Name = "MenuItem_Color";
            this.MenuItem_Color.Size = new System.Drawing.Size(252, 30);
            this.MenuItem_Color.Text = "颜色";
            this.MenuItem_Color.Click += new System.EventHandler(this.MenuItem_Color_Click);
            // 
            // 打开记录ToolStripMenuItem
            // 
            this.打开记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ShowRecord,
            this.MenuItem_HideRecord});
            this.打开记录ToolStripMenuItem.Name = "打开记录ToolStripMenuItem";
            this.打开记录ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.打开记录ToolStripMenuItem.Text = "打开记录";
            // 
            // MenuItem_ShowRecord
            // 
            this.MenuItem_ShowRecord.Name = "MenuItem_ShowRecord";
            this.MenuItem_ShowRecord.Size = new System.Drawing.Size(128, 30);
            this.MenuItem_ShowRecord.Text = "显示";
            this.MenuItem_ShowRecord.Click += new System.EventHandler(this.MenuItem_ShowRecord_Click);
            // 
            // MenuItem_HideRecord
            // 
            this.MenuItem_HideRecord.Name = "MenuItem_HideRecord";
            this.MenuItem_HideRecord.Size = new System.Drawing.Size(128, 30);
            this.MenuItem_HideRecord.Text = "隐藏";
            this.MenuItem_HideRecord.Click += new System.EventHandler(this.MenuItem_HideRecord_Click);
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(0, 35);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(800, 510);
            this.txt_Content.TabIndex = 1;
            // 
            // panel_Container
            // 
            this.panel_Container.Controls.Add(this.btn_ShowRecord);
            this.panel_Container.Controls.Add(this.list_Record);
            this.panel_Container.Location = new System.Drawing.Point(0, 35);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(214, 510);
            this.panel_Container.TabIndex = 2;
            // 
            // btn_ShowRecord
            // 
            this.btn_ShowRecord.Location = new System.Drawing.Point(129, 162);
            this.btn_ShowRecord.Name = "btn_ShowRecord";
            this.btn_ShowRecord.Size = new System.Drawing.Size(75, 164);
            this.btn_ShowRecord.TabIndex = 1;
            this.btn_ShowRecord.Text = "<<";
            this.btn_ShowRecord.UseVisualStyleBackColor = true;
            this.btn_ShowRecord.Click += new System.EventHandler(this.Btn_ShowRecord_Click);
            // 
            // list_Record
            // 
            this.list_Record.FormattingEnabled = true;
            this.list_Record.ItemHeight = 18;
            this.list_Record.Location = new System.Drawing.Point(3, 3);
            this.list_Record.Name = "list_Record";
            this.list_Record.Size = new System.Drawing.Size(120, 508);
            this.list_Record.TabIndex = 0;
            this.list_Record.DoubleClick += new System.EventHandler(this.List_Record_DoubleClick);
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.menu_Toolbar);
            this.MainMenuStrip = this.menu_Toolbar;
            this.Name = "MainContainer";
            this.Text = "记事本";
            this.Load += new System.EventHandler(this.MainContainer_Load);
            this.menu_Toolbar.ResumeLayout(false);
            this.menu_Toolbar.PerformLayout();
            this.panel_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Toolbar;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_AutoEnter;
        private System.Windows.Forms.ToolStripMenuItem 样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Font;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Color;
        private System.Windows.Forms.ToolStripMenuItem 打开记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ShowRecord;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_HideRecord;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Button btn_ShowRecord;
        private System.Windows.Forms.ListBox list_Record;
    }
}

