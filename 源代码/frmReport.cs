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
    public partial class frmReport : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select lxq_Sno08 as 学号,lxq_Semester08 as 学期,lxq_Coname08 as 课程名称," +
                    "lxq_Cono08 as 课程编号,lxq_Score08 as 成绩,lxq_Tno08 as 教师编号 from luxq_Reports08";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[3].ReadOnly = true;
                dataGView.Columns[5].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmReport()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into luxq_Reports08 values('" + txtSno.Text + "','" + txtSem.Text + "'," +
                    "'" + txtConame.Text + "','" + txtCono.Text + "','" + Convert.ToInt32(txtScore.Text) + "'," +
                        "'" + txtTno.Text + "')";
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
                    string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from luxq_Reports08 where lxq_Sno08= '" + Sno + "'";
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
            string Sno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Sem = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Coname = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Cono = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Score = dataGView.CurrentRow.Cells[4].Value.ToString();
            string Tno = dataGView.CurrentRow.Cells[5].Value.ToString();

            try
            {
                    sql = "update luxq_Reports08 set lxq_Semester08='" + Sem + "'," +
                         "lxq_Coname08='" + Coname + "',lxq_Score08='" + Score + "'" +
                         " where lxq_Sno08='" + Sno + "' AND lxq_Cono08='" + Cono + "' " +
                         " AND lxq_Tno08='" + Tno + "'";
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
