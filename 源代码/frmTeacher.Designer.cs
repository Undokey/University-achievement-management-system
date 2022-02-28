namespace luxiaoqiang08
{
    partial class frmTeacher
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
            this.laTno = new System.Windows.Forms.Label();
            this.laTname = new System.Windows.Forms.Label();
            this.laTsex = new System.Windows.Forms.Label();
            this.laTage = new System.Windows.Forms.Label();
            this.laTtitle = new System.Windows.Forms.Label();
            this.laTtel = new System.Windows.Forms.Label();
            this.txtTno = new System.Windows.Forms.TextBox();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.txtTtitle = new System.Windows.Forms.TextBox();
            this.txtTage = new System.Windows.Forms.TextBox();
            this.txtTsex = new System.Windows.Forms.TextBox();
            this.txtTtel = new System.Windows.Forms.TextBox();
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
            // laTno
            // 
            this.laTno.AutoSize = true;
            this.laTno.Location = new System.Drawing.Point(42, 26);
            this.laTno.Name = "laTno";
            this.laTno.Size = new System.Drawing.Size(53, 12);
            this.laTno.TabIndex = 0;
            this.laTno.Text = "教师编号";
            // 
            // laTname
            // 
            this.laTname.AutoSize = true;
            this.laTname.Location = new System.Drawing.Point(311, 23);
            this.laTname.Name = "laTname";
            this.laTname.Size = new System.Drawing.Size(29, 12);
            this.laTname.TabIndex = 1;
            this.laTname.Text = "姓名";
            // 
            // laTsex
            // 
            this.laTsex.AutoSize = true;
            this.laTsex.Location = new System.Drawing.Point(564, 26);
            this.laTsex.Name = "laTsex";
            this.laTsex.Size = new System.Drawing.Size(29, 12);
            this.laTsex.TabIndex = 2;
            this.laTsex.Text = "性别";
            // 
            // laTage
            // 
            this.laTage.AutoSize = true;
            this.laTage.Location = new System.Drawing.Point(42, 111);
            this.laTage.Name = "laTage";
            this.laTage.Size = new System.Drawing.Size(29, 12);
            this.laTage.TabIndex = 3;
            this.laTage.Text = "年龄";
            // 
            // laTtitle
            // 
            this.laTtitle.AutoSize = true;
            this.laTtitle.Location = new System.Drawing.Point(311, 108);
            this.laTtitle.Name = "laTtitle";
            this.laTtitle.Size = new System.Drawing.Size(29, 12);
            this.laTtitle.TabIndex = 4;
            this.laTtitle.Text = "职称";
            // 
            // laTtel
            // 
            this.laTtel.AutoSize = true;
            this.laTtel.Location = new System.Drawing.Point(564, 111);
            this.laTtel.Name = "laTtel";
            this.laTtel.Size = new System.Drawing.Size(53, 12);
            this.laTtel.TabIndex = 5;
            this.laTtel.Text = "联系电话";
            // 
            // txtTno
            // 
            this.txtTno.Location = new System.Drawing.Point(139, 26);
            this.txtTno.Name = "txtTno";
            this.txtTno.Size = new System.Drawing.Size(100, 21);
            this.txtTno.TabIndex = 6;
            // 
            // txtTname
            // 
            this.txtTname.Location = new System.Drawing.Point(374, 23);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(100, 21);
            this.txtTname.TabIndex = 7;
            // 
            // txtTtitle
            // 
            this.txtTtitle.Location = new System.Drawing.Point(374, 102);
            this.txtTtitle.Name = "txtTtitle";
            this.txtTtitle.Size = new System.Drawing.Size(100, 21);
            this.txtTtitle.TabIndex = 8;
            // 
            // txtTage
            // 
            this.txtTage.Location = new System.Drawing.Point(139, 111);
            this.txtTage.Name = "txtTage";
            this.txtTage.Size = new System.Drawing.Size(100, 21);
            this.txtTage.TabIndex = 9;
            // 
            // txtTsex
            // 
            this.txtTsex.Location = new System.Drawing.Point(633, 23);
            this.txtTsex.Name = "txtTsex";
            this.txtTsex.Size = new System.Drawing.Size(100, 21);
            this.txtTsex.TabIndex = 10;
            // 
            // txtTtel
            // 
            this.txtTtel.Location = new System.Drawing.Point(633, 105);
            this.txtTtel.Name = "txtTtel";
            this.txtTtel.Size = new System.Drawing.Size(100, 21);
            this.txtTtel.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(666, 196);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(666, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(666, 300);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(666, 351);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(6, 20);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(517, 181);
            this.dataGView.TabIndex = 16;
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGView);
            this.Gbox.Location = new System.Drawing.Point(27, 214);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(517, 187);
            this.Gbox.TabIndex = 17;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "groupBox1";
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtTtel);
            this.Controls.Add(this.txtTsex);
            this.Controls.Add(this.txtTage);
            this.Controls.Add(this.txtTtitle);
            this.Controls.Add(this.txtTname);
            this.Controls.Add(this.txtTno);
            this.Controls.Add(this.laTtel);
            this.Controls.Add(this.laTtitle);
            this.Controls.Add(this.laTage);
            this.Controls.Add(this.laTsex);
            this.Controls.Add(this.laTname);
            this.Controls.Add(this.laTno);
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师信息输入窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.Gbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTno;
        private System.Windows.Forms.Label laTname;
        private System.Windows.Forms.Label laTsex;
        private System.Windows.Forms.Label laTage;
        private System.Windows.Forms.Label laTtitle;
        private System.Windows.Forms.Label laTtel;
        private System.Windows.Forms.TextBox txtTno;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.TextBox txtTtitle;
        private System.Windows.Forms.TextBox txtTage;
        private System.Windows.Forms.TextBox txtTsex;
        private System.Windows.Forms.TextBox txtTtel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.GroupBox Gbox;
    }
}