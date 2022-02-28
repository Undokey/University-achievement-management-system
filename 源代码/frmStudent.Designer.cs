namespace luxiaoqiang08
{
    partial class frmStudent
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
            this.Gbox = new System.Windows.Forms.GroupBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSsex = new System.Windows.Forms.TextBox();
            this.txtSage = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.txtSsourceofstu = new System.Windows.Forms.TextBox();
            this.txtScredit = new System.Windows.Forms.TextBox();
            this.txtSarea = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.laSno = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.laSex = new System.Windows.Forms.Label();
            this.laSage = new System.Windows.Forms.Label();
            this.laCno = new System.Windows.Forms.Label();
            this.laSsourceofstu = new System.Windows.Forms.Label();
            this.laScredit = new System.Windows.Forms.Label();
            this.laSarea = new System.Windows.Forms.Label();
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGView);
            this.Gbox.Location = new System.Drawing.Point(21, 254);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(597, 140);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "groupBox1";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(114, 57);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 1;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(356, 54);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 21);
            this.txtSname.TabIndex = 2;
            // 
            // txtSsex
            // 
            this.txtSsex.Location = new System.Drawing.Point(605, 57);
            this.txtSsex.Name = "txtSsex";
            this.txtSsex.Size = new System.Drawing.Size(100, 21);
            this.txtSsex.TabIndex = 3;
            // 
            // txtSage
            // 
            this.txtSage.Location = new System.Drawing.Point(114, 118);
            this.txtSage.Name = "txtSage";
            this.txtSage.Size = new System.Drawing.Size(100, 21);
            this.txtSage.TabIndex = 4;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(356, 124);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(100, 21);
            this.txtCno.TabIndex = 5;
            // 
            // txtSsourceofstu
            // 
            this.txtSsourceofstu.Location = new System.Drawing.Point(605, 124);
            this.txtSsourceofstu.Name = "txtSsourceofstu";
            this.txtSsourceofstu.Size = new System.Drawing.Size(100, 21);
            this.txtSsourceofstu.TabIndex = 6;
            // 
            // txtScredit
            // 
            this.txtScredit.Location = new System.Drawing.Point(114, 190);
            this.txtScredit.Name = "txtScredit";
            this.txtScredit.Size = new System.Drawing.Size(100, 21);
            this.txtScredit.TabIndex = 7;
            // 
            // txtSarea
            // 
            this.txtSarea.Location = new System.Drawing.Point(356, 196);
            this.txtSarea.Name = "txtSarea";
            this.txtSarea.Size = new System.Drawing.Size(100, 21);
            this.txtSarea.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(605, 194);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(42, 57);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 10;
            this.laSno.Text = "学号";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(268, 57);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(29, 12);
            this.laName.TabIndex = 11;
            this.laName.Text = "姓名";
            // 
            // laSex
            // 
            this.laSex.AutoSize = true;
            this.laSex.Location = new System.Drawing.Point(534, 60);
            this.laSex.Name = "laSex";
            this.laSex.Size = new System.Drawing.Size(29, 12);
            this.laSex.TabIndex = 12;
            this.laSex.Text = "性别";
            // 
            // laSage
            // 
            this.laSage.AutoSize = true;
            this.laSage.Location = new System.Drawing.Point(42, 127);
            this.laSage.Name = "laSage";
            this.laSage.Size = new System.Drawing.Size(29, 12);
            this.laSage.TabIndex = 13;
            this.laSage.Text = "年龄";
            // 
            // laCno
            // 
            this.laCno.AutoSize = true;
            this.laCno.Location = new System.Drawing.Point(256, 127);
            this.laCno.Name = "laCno";
            this.laCno.Size = new System.Drawing.Size(53, 12);
            this.laCno.TabIndex = 14;
            this.laCno.Text = "班级编号";
            // 
            // laSsourceofstu
            // 
            this.laSsourceofstu.AutoSize = true;
            this.laSsourceofstu.Location = new System.Drawing.Point(534, 127);
            this.laSsourceofstu.Name = "laSsourceofstu";
            this.laSsourceofstu.Size = new System.Drawing.Size(65, 12);
            this.laSsourceofstu.TabIndex = 15;
            this.laSsourceofstu.Text = "生源所在地";
            // 
            // laScredit
            // 
            this.laScredit.AutoSize = true;
            this.laScredit.Location = new System.Drawing.Point(12, 196);
            this.laScredit.Name = "laScredit";
            this.laScredit.Size = new System.Drawing.Size(77, 12);
            this.laScredit.TabIndex = 16;
            this.laScredit.Text = "已修学分总数";
            // 
            // laSarea
            // 
            this.laSarea.AutoSize = true;
            this.laSarea.Location = new System.Drawing.Point(256, 196);
            this.laSarea.Name = "laSarea";
            this.laSarea.Size = new System.Drawing.Size(53, 12);
            this.laSarea.TabIndex = 17;
            this.laSarea.Text = "地区信息";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(6, 11);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(591, 123);
            this.dataGView.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(678, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(678, 340);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 19;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(678, 383);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.laSarea);
            this.Controls.Add(this.laScredit);
            this.Controls.Add(this.laSsourceofstu);
            this.Controls.Add(this.laCno);
            this.Controls.Add(this.laSage);
            this.Controls.Add(this.laSex);
            this.Controls.Add(this.laName);
            this.Controls.Add(this.laSno);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSarea);
            this.Controls.Add(this.txtScredit);
            this.Controls.Add(this.txtSsourceofstu);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.txtSage);
            this.Controls.Add(this.txtSsex);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.Gbox);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息输入窗口";
            this.Gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSsex;
        private System.Windows.Forms.TextBox txtSage;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.TextBox txtSsourceofstu;
        private System.Windows.Forms.TextBox txtScredit;
        private System.Windows.Forms.TextBox txtSarea;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laSex;
        private System.Windows.Forms.Label laSage;
        private System.Windows.Forms.Label laCno;
        private System.Windows.Forms.Label laSsourceofstu;
        private System.Windows.Forms.Label laScredit;
        private System.Windows.Forms.Label laSarea;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
    }
}