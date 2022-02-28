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
    public partial class frmSumCouandCre : Form
    {
        sqlConnect con1 = new sqlConnect();
        sqlConnect con2= new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = " select luxq_Students08.lxq_Sno08 as 学号,luxq_Courses08.lxq_Cono08 as 课程编号, " +
                    "luxq_Courses08.lxq_Coname08 as 课程名称 from luxq_Students08,luxq_Courses08,luxq_Reports08 " +
                    "where luxq_Students08.lxq_Sno08=luxq_Reports08.lxq_Sno08 AND " +
                    "luxq_Reports08.lxq_Cono08 = luxq_Courses08.lxq_Cono08";
                con1.BindDataGridView(dataGView1, sql);
                dataGView1.Columns[0].ReadOnly = true;
                dataGView1.Columns[1].ReadOnly = true;
                dataGView1.Columns[2].ReadOnly = true;
                sql = " select luxq_Students08.lxq_Sno08 as 学号,luxq_Students08.lxq_Sname08 as 姓名," +
                    "luxq_Students08.lxq_Scredit08 as 学分 from luxq_Students08";
                con2.BindDataGridView(dataGView2, sql);
                dataGView2.Columns[0].ReadOnly = true;
                dataGView2.Columns[1].ReadOnly = true;
                dataGView2.Columns[2].ReadOnly = true;
                dataGView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能作该操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmSumCouandCre()
        {
            InitializeComponent();
            SetBind();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
