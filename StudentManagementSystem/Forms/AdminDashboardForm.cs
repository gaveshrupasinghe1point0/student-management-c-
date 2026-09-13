using System;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LayoutDashboardButtons();
        }

        private void AdminDashboardForm_Resize(object sender, EventArgs e)
        {
            LayoutDashboardButtons();
        }

        private void LayoutDashboardButtons()
        {
            if (btnAuth == null || pnlHeader == null) return;

            lblTitle.Left = Math.Max(20, (pnlHeader.Width - lblTitle.Width) / 2);
            lblTitle.Top = Math.Max(10, (pnlHeader.Height - lblTitle.Height) / 2);

            int padX = 30;   
            int padY = 20;   
            int topOffset = pnlHeader.Height + padY;
            int availableWidth  = this.ClientSize.Width - (2 * padX);
            int availableHeight = this.ClientSize.Height - topOffset - padY;

            int gapX = 20;   
            int gapY = 14;   

            int btnWidth  = Math.Max(200, (availableWidth - gapX) / 2);
            int btnHeight = Math.Max(45,  (availableHeight - (3 * gapY)) / 4);

            int totalGridWidth  = (btnWidth * 2) + gapX;
            int totalGridHeight = (btnHeight * 4) + (gapY * 3);

            int startX = padX + (availableWidth - totalGridWidth) / 2;
            int startY = topOffset + (availableHeight - totalGridHeight) / 2;
            if (startY < topOffset) startY = topOffset;

            int col1X = startX;
            int col2X = startX + btnWidth + gapX;

            btnAuth.SetBounds(col1X, startY, btnWidth, btnHeight);
            btnStudentRecords.SetBounds(col2X, startY, btnWidth, btnHeight);

            int row1Y = startY + btnHeight + gapY;
            btnCourses.SetBounds(col1X, row1Y, btnWidth, btnHeight);
            btnAttendance.SetBounds(col2X, row1Y, btnWidth, btnHeight);

            int row2Y = startY + (btnHeight + gapY) * 2;
            btnGrades.SetBounds(col1X, row2Y, btnWidth, btnHeight);
            btnFees.SetBounds(col2X, row2Y, btnWidth, btnHeight);

            int row3Y = startY + (btnHeight + gapY) * 3;
            int reportCardX = (availableWidth - btnWidth) / 2;
            btnReportCard.SetBounds(reportCardX, row3Y, btnWidth, btnHeight);
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnStudentRecords_Click(object sender, EventArgs e)
        {
            StudentRecordsForm studentForm = new StudentRecordsForm();
            studentForm.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseManagementForm courseForm = new CourseManagementForm();
            courseForm.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new AttendanceForm().Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            new GradesForm().Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            new FeesForm().Show();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timetable module placeholder (Member 7). Wire your form here!", "Member 7 Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReportCard_Click(object sender, EventArgs e)
        {
            new ReportCardForm().Show();
        }
    }
}
