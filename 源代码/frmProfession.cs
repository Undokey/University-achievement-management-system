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
    public partial class frmProfession : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
           try
            {
                sql = "select lxq_Pno08 as 专业编号,lxq_Pname08 as 专业名称 from luxq_Profession08";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        public frmProfession()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql="insert into luxq_Profession08 values('"+txtPno.Text+"','"+txtPname.Text+"')";
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
            if(MessageBox.Show("确定删除该条信息吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                try
                {
                    sql = "delete from luxq_Profession08 where lxq_Pno08='" + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
            sql = "update luxq_Profession08 set lxq_Pname08='"
              + dataGView.CurrentRow.Cells[1].Value.ToString() + "' where lxq_Pno08='"
              + dataGView.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void dataGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
