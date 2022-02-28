using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luxiaoqiang08
{
    public partial class frmScoreSem : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void CmbSemBind()
        {
            try
            {
                CmbSem.DropDownStyle = ComboBoxStyle.DropDownList;

                CmbSem.Items.Add("第一学期");
                CmbSem.Items.Add("第二学期");
            }
            catch (Exception)
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        public frmScoreSem()
        {
            InitializeComponent();
            CmbSemBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select lxq_Sno08 as 学号,lxq_Semester08 as 学期,lxq_Coname08 as 课程名称,lxq_Score08 as 成绩 " +
                    " from luxq_Reports08 where lxq_Semester08='" + CmbSem.SelectedItem.ToString() + "'";
                con.BindDataGridView(dataGView, sql);
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
