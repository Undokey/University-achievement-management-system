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
    public partial class frmStudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select lxq_Sno08 as 学号,lxq_Sname08 as 姓名,lxq_Ssex08 as 性别,lxq_Sage08 as 年龄," +
                    "lxq_Cno08 as 班级编号,lxq_Ssourceofstu08 as 生源所在地,lxq_Scredit08 as 已修学分总数," +
                    "lxq_Sarea08 as 地区信息 from luxq_Students08";
                ds = con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.Columns[1].ReadOnly = true;
                dataGView.Columns[2].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmStudent()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                /*sql = "insert into luxq_Students08 values('" + txtSno.Text + "','"+txtSname.Text+"','"+txtSsex.Text+'",
                    txtSage.Text,'"++"',)";*/
                sql="insert into luxq_Students08 values('"+txtSno.Text+"','"+txtSname.Text+"','" + txtSsex.Text + "','"+Convert.ToInt32(txtSage.Text)+"'," +
                    "'"+txtCno.Text+"','"+txtSsourceofstu.Text+"','"+Convert.ToInt32(txtScredit.Text)+"','"+txtSarea.Text+"')";
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
                    sql = "delete from luxq_Students08 where lxq_Sno08= '" + Sno + "'";
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
            string Sname = dataGView.CurrentRow.Cells[1].Value.ToString();
            string Ssex = dataGView.CurrentRow.Cells[2].Value.ToString();
            string Sage= dataGView.CurrentRow.Cells[3].Value.ToString();
            string Cono = dataGView.CurrentRow.Cells[4].Value.ToString();
            string Ssourceofstu = dataGView.CurrentRow.Cells[5].Value.ToString();
            string Scredit = dataGView.CurrentRow.Cells[6].Value.ToString();
            string Sarea= dataGView.CurrentRow.Cells[7].Value.ToString();
            try
            {
                sql = "update luxq_Students08 set lxq_Sname08='" + Sname + "'," +
                    "lxq_Ssex08='" + Ssex + "',lxq_Sage08='" + Sage + "',lxq_Cno08='" + Cono + "'," +
                    "lxq_Ssourceofstu08='" + Ssourceofstu + "',lxq_Scredit08='" + Scredit + "'," +
                    "lxq_Sarea08='" + Sarea + "' where lxq_Sno08='" + Sno + "'";
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
