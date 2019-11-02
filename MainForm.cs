using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class MainFom : Form
    {
        public MainFom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip6_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInfo pf = new PersonalInfo();
            pf.ShowDialog();
        }

        private void MainFom_Load(object sender, EventArgs e)
        {

        }

        private void educationalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationInfo ef = new EducationInfo();
                ef.ShowDialog();
        }

        private void officialInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficialInfo of = new OfficialInfo();
            of.ShowDialog();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryPolicy sf = new SalaryPolicy();
            sf.ShowDialog();
        }

        private void experienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExperienceInfo exf = new ExperienceInfo();
            exf.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void leaveInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveInfo li = new LeaveInfo();
            li.ShowDialog();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password ps = new Password();
            ps.ShowDialog();

        }

       // private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        //{
          //  Attendancelog atl = new Attendancelog();
          //  atl.ShowDialog();
        //}

        private void leaveEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveInfo lea =new LeaveInfo();
            lea.ShowDialog();
        }

        private void addAnnouncementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAnounce aa = new AddAnounce();
            aa.ShowDialog();
        }

        private void trainingInformatioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyTrain ct = new CompanyTrain();
            ct.ShowDialog();
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceReport at = new AttendanceReport();
             at.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveApplication leav = new LeaveApplication();
            leav.ShowDialog();
           
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payroll pa = new Payroll();
            pa.ShowDialog();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportAll re = new ReportAll();
            re.ShowDialog();
        }

        private void leaveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveReort LR = new LeaveReort();
            LR.ShowDialog();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
