namespace luxiaoqiang08
{
    partial class frmProfession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laPno = new System.Windows.Forms.Label();
            this.laPname = new System.Windows.Forms.Label();
            this.txtPno = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // laPno
            // 
            this.laPno.AutoSize = true;
            this.laPno.Location = new System.Drawing.Point(99, 108);
            this.laPno.Name = "laPno";
            this.laPno.Size = new System.Drawing.Size(53, 12);
            this.laPno.TabIndex = 0;
            this.laPno.Text = "专业编号";
            // 
            // laPname
            // 
            this.laPname.AutoSize = true;
            this.laPname.Location = new System.Drawing.Point(368, 107);
            this.laPname.Name = "laPname";
            this.laPname.Size = new System.Drawing.Size(53, 12);
            this.laPname.TabIndex = 1;
            this.laPname.Text = "专业名称";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(197, 105);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(100, 21);
            this.txtPno.TabIndex = 2;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(472, 104);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(100, 21);
            this.txtPname.TabIndex = 3;
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGView);
            this.Gbox.Location = new System.Drawing.Point(97, 194);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(243, 128);
            this.Gbox.TabIndex = 4;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "groupBox1";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(0, 0);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(242, 129);
            this.dataGView.TabIndex = 0;
            this.dataGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGView_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(651, 102);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnDelete.Location = new System.Drawing.Point(345, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(487, 391);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(651, 391);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmProfession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.laPname);
            this.Controls.Add(this.laPno);
            this.Name = "frmProfession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专业信息输入窗口";
            this.Gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laPno;
        private System.Windows.Forms.Label laPname;
        private System.Windows.Forms.TextBox txtPno;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
    }
}