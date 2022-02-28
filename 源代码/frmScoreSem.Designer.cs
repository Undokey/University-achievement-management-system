namespace luxiaoqiang08
{
    partial class frmScoreSem
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
            this.dataGView = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.CmbSem = new System.Windows.Forms.ComboBox();
            this.laSem = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.Gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox
            // 
            this.Gbox.Controls.Add(this.dataGView);
            this.Gbox.Location = new System.Drawing.Point(122, 191);
            this.Gbox.Name = "Gbox";
            this.Gbox.Size = new System.Drawing.Size(432, 192);
            this.Gbox.TabIndex = 0;
            this.Gbox.TabStop = false;
            this.Gbox.Text = "groupBox1";
            // 
            // dataGView
            // 
            this.dataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView.Location = new System.Drawing.Point(0, 0);
            this.dataGView.Name = "dataGView";
            this.dataGView.RowTemplate.Height = 23;
            this.dataGView.Size = new System.Drawing.Size(426, 186);
            this.dataGView.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(543, 49);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CmbSem
            // 
            this.CmbSem.FormattingEnabled = true;
            this.CmbSem.Location = new System.Drawing.Point(137, 49);
            this.CmbSem.Name = "CmbSem";
            this.CmbSem.Size = new System.Drawing.Size(121, 20);
            this.CmbSem.TabIndex = 2;
            // 
            // laSem
            // 
            this.laSem.AutoSize = true;
            this.laSem.Location = new System.Drawing.Point(50, 49);
            this.laSem.Name = "laSem";
            this.laSem.Size = new System.Drawing.Size(29, 12);
            this.laSem.TabIndex = 3;
            this.laSem.Text = "学期";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(397, 49);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmScoreSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.laSem);
            this.Controls.Add(this.CmbSem);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Gbox);
            this.Name = "frmScoreSem";
            this.Text = "学生每学年成绩统计";
            this.Gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox;
        private System.Windows.Forms.DataGridView dataGView;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox CmbSem;
        private System.Windows.Forms.Label laSem;
        private System.Windows.Forms.Button btnOK;
    }
}