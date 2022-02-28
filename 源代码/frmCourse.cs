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
    public partial class frmCourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select lxq_Cono08 as 课程编号,lxq_Coname08 as 课程名称,lxq_Tname08 as 任课教师," +
                    "lxq_Cosem08 as 开课学期,lxq_Chour08 as 学时,lxq_Ctype08 as 考试或考查," +
                    "lxq_Ccredit08 as 学分 from luxq_Courses08";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmCourse()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           try
            {
                sql = "insert into luxq_Courses08 values('" + txtCono.Text + "','" + txtConame.Text + "'," +
                    "'" + txtTname.Text + "','" + txtCosem.Text + "','" + Convert.ToInt32(txtChour.Text) + "'," +
                        "'" + txtCtype.Text + "','" + Convert.ToInt32(txtCcredit.Text) + "')";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                try
                {
                    string Cono = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from luxq_Courses08 where lxq_Cono08= '" + Cono + "'";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string Cono = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Coname = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Tname = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Cosem = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Chour = dataGView.CurrentRow.Cells[4].Value.ToString();  
            string Ctype = dataGView.CurrentRow.Cells[5].Value.ToString();
            string Ccredit = dataGView.CurrentRow.Cells[6].Value.ToString();  
            
            try
            {
                sql = "update luxq_Courses08 set lxq_Coname08='" + Coname + "'," +
                    "lxq_Tname08='" + Tname + "',lxq_Cosem08='" + Cosem + "',lxq_Chour08='" + Chour + "'," +
                    "lxq_Ctype08='" + Ctype + "',lxq_Ccredit08='" + Ccredit + "' where lxq_Cono08='" + Cono + "'";
                con.OperateData(sql);
                SetBind();
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
