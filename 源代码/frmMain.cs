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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent fStudent = new frmStudent();
            fStudent.Show();
        }

        private void 课程表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse fCourse = new frmCourse();
            fCourse.Show();
        }

        private void 教师表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacher fTeacher = new frmTeacher();
            fTeacher.Show();
        }

        private void 成绩表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport fReport = new frmReport();
            fReport.Show();
        }

        private void 专业表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfession fProfession = new frmProfession();
            fProfession.Show();

        }

        private void 班级表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fClass = new frmClass();
            fClass.Show();
        }

        private void 授课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstruct fInstruct = new frmInstruct();
            fInstruct.Show();
        }

        private void 上课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeaching fTeaching = new frmTeaching();
            fTeaching.Show();
        }

        private void 基本表维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 班级课程开设表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetup fSetup = new frmSetup();
            fSetup.Show();
        }

        private void 学生成绩按每学年成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScoreSem fScoreSem = new frmScoreSem();
            fScoreSem.Show();

        }

        private void 每门课程平均成绩统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvgScore fAvgScore = new frmAvgScore();
            fAvgScore.Show();
        }

        private void 学生成绩名次排定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScoreRanking fScoreRanking = new frmScoreRanking();
            fScoreRanking.Show();
        }

        private void 学生所学课程及学分统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumCouandCre fSumCouandCre = new frmSumCouandCre();
            fSumCouandCre.Show();
        }
    }
}
