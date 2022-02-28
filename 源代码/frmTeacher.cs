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
    public partial class frmTeacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select lxq_Tno08 as 教师编号,lxq_Tname08 as 姓名,lxq_Tsex08 as 性别," +
                    "lxq_Tage08 as 年龄,lxq_Ttitle08 as 职称,lxq_Ttel08 as 联系电话 from luxq_Teachers08";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmTeacher()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into luxq_Teachers08 values('" + txtTno.Text + "','" + txtTname.Text + "'," +
                    "'" + txtTsex.Text + "','" + Convert.ToInt32(txtTage.Text) + "'," +
                        "'" + txtTtitle.Text + "','" + txtTtel.Text + "')";
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
                    string Tno = dataGView.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from luxq_Teachers08 where lxq_Tno08= '" +Tno + "'";
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
            string Tno = dataGView.CurrentRow.Cells[0].Value.ToString();
            string Tname = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Tsex = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Tage = dataGView.CurrentRow.Cells[3].Value.ToString();
            string Ttitle = dataGView.CurrentRow.Cells[4].Value.ToString();
            string Ttel = dataGView.CurrentRow.Cells[5].Value.ToString();
            

            try
            {
                sql = "update luxq_Teachers08 set lxq_Tname08='" + Tname + "'," +
                    "lxq_Tsex08='" + Tsex + "',lxq_Tage08='" + Tage + "',lxq_Ttitle08='" + Ttitle + "'," +
                    "lxq_Ttel08='" + Ttel + "' where lxq_Tno08='" + Tno + "'";
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
