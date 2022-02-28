namespace luxiaoqiang08
{
    partial class frmCourse
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
            this.laCono = new System.Windows.Forms.Label();
            this.laConame = new System.Windows.Forms.Label();
            this.laTname = new System.Windows.Forms.Label();
            this.laCosem = new System.Windows.Forms.Label();
            this.laChour = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.laCcredit = new System.Windows.Forms.Label();
            this.txtCono = new System.Windows.Forms.TextBox();
            this.txtConame = new System.Windows.Forms.TextBox();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.txtCosem = new System.Windows.Forms.TextBox();
            this.txtChour = new System.Windows.Forms.TextBox();
            this.txtCtype = new System.Windows.Forms.TextBox();
            this.txtCcredit = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Gbox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.Gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // laCono
            // 
            this.laCono.AutoSize = true;
            this.laCono.Location = new System.Drawing.Point(50, 44);
            this.laCono.Name = "laCono";
            this.laCono.Size = new System.Drawing.Size(53, 12);
            this.laCono.TabIndex = 0;
            this.laCono.Text = "课程编号";
            // 
            // laConame
            // 
            this.laConame.AutoSize = true;
            this.laConame.Location = new System.Drawing.Point(304, 44);
            this.laConame.Name = "laConame";
            this.laConame.Size = new System.Drawing.Size(53, 12);
            this.laConame.TabIndex = 1;
            this.laConame.Text = "课程名称";
            // 
            // laTname
            // 
            this.laTname.AutoSize = true;
            this.laTname.Location = new System.Drawing.Point(565, 44);
            this.laTname.Name = "laTname";
            this.laTname.Size = new System.Drawing.Size(53, 12);
            this.laTname.TabIndex = 2;
            this.laTname.Text = "任课教师";
            // 
            // laCosem
            // 
            this.laCosem.AutoSize = true;
            this.laCosem.Location = new System.Drawing.Point(50, 108);
            this.laCosem.Name = "laCosem";
            this.laCosem.Size = new System.Drawing.Size(53, 12);
            this.laCosem.TabIndex = 3;
            this.laCosem.Text = "开课学期";
            // 
            // laChour
            // 
            this.laChour.AutoSize = true;
            this.laChour.Location = new System.Drawing.Point(304, 108);
            this.laChour.Name = "laChour";
            this.laChour.Size = new System.Drawing.Size(29, 12);
            this.laChour.TabIndex = 4;
            this.laChour.Text = "学时";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(565, 108);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(65, 12);
            this.la.TabIndex = 5;
            this.la.Text = "考试或考查";
            // 
            // laCcredit
            // 
            this.laCcredit.AutoSize = true;
            this.laCcredit.Location = new System.Drawing.Point(50, 184);
            this.laCcredit.Name = "laCcredit";
            this.laCcredit.Size = new System.Drawing.Size(29, 12);
            this.laCcredit.TabIndex = 6;
            this.laCcredit.Text = "学分";
            // 
            // txtCono
            // 
            this.txtCono.Location = new System.Drawing.Point(125, 44);
            this.txtCono.Name = "txtCono";
            this.txtCono.Size = new System.Drawing.Size(100, 21);
            this.txtCono.TabIndex = 7;
            // 
            // txtConame
            // 
            this.txtConame.Location = new System.Drawing.Point(376, 41);
            this.txtConame.Name = "txtConame";
            this.txtConame.Size = new System.Drawing.Size(100, 21);
            this.txtConame.TabIndex = 8;
            // 
            // txtTname
            // 
            this.txtTname.Location = new System.Drawing.Point(630, 41);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(100, 21);
            this.txtTname.TabIndex = 9;
            // 
            // txtCosem
            // 
            this.txtCosem.Location = new System.Drawing.Point(125, 105);
            this.txtCosem.Name = "txtCosem";
            this.txtCosem.Size = new System.Drawing.Size(100, 21);
            this.txtCosem.TabIndex = 10;
            // 
            // txtChour
            // 
            this.txtChour.Location = new System.Drawing.Point(376, 108);
            this.txtChour.Name = "txtChour";
            this.txtChour.Size = new System.Drawing.Size(100, 21);
            this.txtChour.TabIndex = 11;
            // 
            // txtCtype
            // 
            this.txtCtype.Location = new System.Drawing.Point(630, 105);
            this.txtCtype.Name = "txtCtype";
            this.txtCtype.Size = new System.Drawing.Size(100, 21);
            this.txtCtype.TabIndex = 12;
            // 
            // txtCcredit
            // 
            this.txtCcredit.Location = new System.Drawing.Point(125, 184);
            this.txtCcredit.Name = "txtCcredit";
            this.txtCcredit.Size = new System.Drawing.Size(100, 21);
            this.txtCcredit.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(645, 216);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(645, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(645, 321);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(645, 378);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(0, 7);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(581, 150);
            this.dataGView.TabIndex = 18;
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGView);
            this.Gbox.Location = new System.Drawing.Point(37, 244);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(581, 145);
            this.Gbox.TabIndex = 19;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "groupBox1";
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCcredit);
            this.Controls.Add(this.txtCtype);
            this.Controls.Add(this.txtChour);
            this.Controls.Add(this.txtCosem);
            this.Controls.Add(this.txtTname);
            this.Controls.Add(this.txtConame);
            this.Controls.Add(this.txtCono);
            this.Controls.Add(this.laCcredit);
            this.Controls.Add(this.la);
            this.Controls.Add(this.laChour);
            this.Controls.Add(this.laCosem);
            this.Controls.Add(this.laTname);
            this.Controls.Add(this.laConame);
            this.Controls.Add(this.laCono);
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息输入窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.Gbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laCono;
        private System.Windows.Forms.Label laConame;
        private System.Windows.Forms.Label laTname;
        private System.Windows.Forms.Label laCosem;
        private System.Windows.Forms.Label laChour;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label laCcredit;
        private System.Windows.Forms.TextBox txtCono;
        private System.Windows.Forms.TextBox txtConame;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.TextBox txtCosem;
        private System.Windows.Forms.TextBox txtChour;
        private System.Windows.Forms.TextBox txtCtype;
        private System.Windows.Forms.TextBox txtCcredit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.GroupBox Gbox;
    }
}