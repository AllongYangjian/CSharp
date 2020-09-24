namespace _2_ClassDemo
{
    partial class ClassForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.txtClassDesc = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassEdit = new System.Windows.Forms.Button();
            this.txtClassNameDesc = new System.Windows.Forms.TextBox();
            this.txtClassNameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClassAdd);
            this.groupBox1.Controls.Add(this.txtClassDesc);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "增加";
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Location = new System.Drawing.Point(628, 28);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(111, 30);
            this.btnClassAdd.TabIndex = 4;
            this.btnClassAdd.Text = "增加";
            this.btnClassAdd.UseVisualStyleBackColor = true;
            this.btnClassAdd.Click += new System.EventHandler(this.BtnClassAdd_Click);
            // 
            // txtClassDesc
            // 
            this.txtClassDesc.Location = new System.Drawing.Point(410, 31);
            this.txtClassDesc.Name = "txtClassDesc";
            this.txtClassDesc.Size = new System.Drawing.Size(197, 28);
            this.txtClassDesc.TabIndex = 3;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(121, 31);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(197, 28);
            this.txtClassName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级名称";
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(22, 138);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowTemplate.Height = 30;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(748, 206);
            this.dgvClass.TabIndex = 1;
            this.dgvClass.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClass_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.btnClassDelete);
            this.groupBox2.Controls.Add(this.btnClassEdit);
            this.groupBox2.Controls.Add(this.txtClassNameDesc);
            this.groupBox2.Controls.Add(this.txtClassNameEdit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 119);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑修改";
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Location = new System.Drawing.Point(628, 83);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(111, 30);
            this.btnClassDelete.TabIndex = 5;
            this.btnClassDelete.Text = "删除";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.BtnClassDelete_Click);
            // 
            // btnClassEdit
            // 
            this.btnClassEdit.Location = new System.Drawing.Point(628, 28);
            this.btnClassEdit.Name = "btnClassEdit";
            this.btnClassEdit.Size = new System.Drawing.Size(111, 30);
            this.btnClassEdit.TabIndex = 4;
            this.btnClassEdit.Text = "保存修改";
            this.btnClassEdit.UseVisualStyleBackColor = true;
            this.btnClassEdit.Click += new System.EventHandler(this.BtnClassEdit_Click);
            // 
            // txtClassNameDesc
            // 
            this.txtClassNameDesc.Location = new System.Drawing.Point(410, 31);
            this.txtClassNameDesc.Name = "txtClassNameDesc";
            this.txtClassNameDesc.Size = new System.Drawing.Size(197, 28);
            this.txtClassNameDesc.TabIndex = 3;
            // 
            // txtClassNameEdit
            // 
            this.txtClassNameEdit.Location = new System.Drawing.Point(121, 31);
            this.txtClassNameEdit.Name = "txtClassNameEdit";
            this.txtClassNameEdit.Size = new System.Drawing.Size(197, 28);
            this.txtClassNameEdit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "班级名称";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(33, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 18);
            this.txtId.TabIndex = 6;
            this.txtId.Visible = false;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.TextBox txtClassDesc;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassEdit;
        private System.Windows.Forms.TextBox txtClassNameDesc;
        private System.Windows.Forms.TextBox txtClassNameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtId;
    }
}

