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
    public partial class frmScoreRanking : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select b.lxq_Sno08 as 学号,SUM(a.lxq_Score08) as 总分," +
                    "RANK() OVER(order by SUM(a.lxq_Score08) DESC) as 排名  " +
                    "from luxq_Reports08 a,luxq_Students08 b " +
                    "where a.lxq_Sno08 = b.lxq_Sno08 group by b.lxq_Sno08";
                con.BindDataGridView(dataGView, sql);
                dataGView.Columns[0].ReadOnly = true;
                dataGView.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmScoreRanking()
        {
    
            InitializeComponent();
            SetBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
