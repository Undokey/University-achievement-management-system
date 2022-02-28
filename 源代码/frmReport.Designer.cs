namespace luxiaoqiang08
{
    partial class frmReport
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
            this.laSno = new System.Windows.Forms.Label();
            this.laCono = new System.Windows.Forms.Label();
            this.laSem = new System.Windows.Forms.Label();
            this.laConame = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.laTno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.txtCono = new System.Windows.Forms.TextBox();
            this.txtConame = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtTno = new System.Windows.Forms.TextBox();
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
            // laSno
            // 
            this.laSno.AutoSize = true;
            this.laSno.Location = new System.Drawing.Point(38, 38);
            this.laSno.Name = "laSno";
            this.laSno.Size = new System.Drawing.Size(29, 12);
            this.laSno.TabIndex = 0;
            this.laSno.Text = "学号";
            // 
            // laCono
            // 
            this.laCono.AutoSize = true;
            this.laCono.Location = new System.Drawing.Point(38, 109);
            this.laCono.Name = "laCono";
            this.laCono.Size = new System.Drawing.Size(53, 12);
            this.laCono.TabIndex = 1;
            this.laCono.Text = "课程编号";
            // 
            // laSem
            // 
            this.laSem.AutoSize = true;
            this.laSem.Location = new System.Drawing.Point(321, 38);
            this.laSem.Name = "laSem";
            this.laSem.Size = new System.Drawing.Size(29, 12);
            this.laSem.TabIndex = 2;
            this.laSem.Text = "学期";
            // 
            // laConame
            // 
            this.laConame.AutoSize = true;
            this.laConame.Location = new System.Drawing.Point(589, 38);
            this.laConame.Name = "laConame";
            this.laConame.Size = new System.Drawing.Size(53, 12);
            this.laConame.TabIndex = 3;
            this.laConame.Text = "课程名称";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Location = new System.Drawing.Point(321, 109);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(29, 12);
            this.labScore.TabIndex = 4;
            this.labScore.Text = "成绩";
            // 
            // laTno
            // 
            this.laTno.AutoSize = true;
            this.laTno.Location = new System.Drawing.Point(589, 109);
            this.laTno.Name = "laTno";
            this.laTno.Size = new System.Drawing.Size(53, 12);
            this.laTno.TabIndex = 5;
            this.laTno.Text = "教师编号";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(114, 38);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 21);
            this.txtSno.TabIndex = 6;
            // 
            // txtSem
            // 
            this.txtSem.Location = new System.Drawing.Point(404, 38);
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(100, 21);
            this.txtSem.TabIndex = 7;
            // 
            // txtCono
            // 
            this.txtCono.Location = new System.Drawing.Point(114, 100);
            this.txtCono.Name = "txtCono";
            this.txtCono.Size = new System.Drawing.Size(100, 21);
            this.txtCono.TabIndex = 8;
            // 
            // txtConame
            // 
            this.txtConame.Location = new System.Drawing.Point(678, 35);
            this.txtConame.Name = "txtConame";
            this.txtConame.Size = new System.Drawing.Size(100, 21);
            this.txtConame.TabIndex = 9;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(404, 100);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 21);
            this.txtScore.TabIndex = 10;
            // 
            // txtTno
            // 
            this.txtTno.Location = new System.Drawing.Point(678, 106);
            this.txtTno.Name = "txtTno";
            this.txtTno.Size = new System.Drawing.Size(100, 21);
            this.txtTno.TabIndex = 11;
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGView);
            this.Gbox.Location = new System.Drawing.Point(56, 265);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(492, 136);
            this.Gbox.TabIndex = 12;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "groupBox1";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(0, 0);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(486, 136);
            this.dataGView.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(678, 221);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(678, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(678, 334);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "保存";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(678, 388);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Gbox);
            this.Controls.Add(this.txtTno);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtConame);
            this.Controls.Add(this.txtCono);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.laTno);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.laConame);
            this.Controls.Add(this.laSem);
            this.Controls.Add(this.laCono);
            this.Controls.Add(this.laSno);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩信息输入窗口";
            this.Gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laSno;
        private System.Windows.Forms.Label laCono;
        private System.Windows.Forms.Label laSem;
        private System.Windows.Forms.Label laConame;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label laTno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.TextBox txtCono;
        private System.Windows.Forms.TextBox txtConame;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtTno;
        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button Cancel;
    }
}