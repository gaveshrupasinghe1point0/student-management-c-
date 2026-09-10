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

            // Center header title in header panel
            lblTitle.Left = Math.Max(20, (pnlHeader.Width - lblTitle.Width) / 2);
            lblTitle.Top = Math.Max(10, (pnlHeader.Height - lblTitle.Height) / 2);

            int padX = 30;   // left + right padding so buttons never touch the edges
            int padY = 20;   // top gap below header & bottom padding
            int topOffset = pnlHeader.Height + padY;
            int availableWidth  = this.ClientSize.Width - (2 * padX);
            int availableHeight = this.ClientSize.Height - topOffset - padY;

            int gapX = 20;   // horizontal gap between the two columns
            int gapY = 14;   // vertical gap between rows

            // Equal button width for 2 columns, equal height for 4 rows
            int btnWidth  = Math.Max(200, (availableWidth - gapX) / 2);
            int btnHeight = Math.Max(45,  (availableHeight - (3 * gapY)) / 4);

            // Center the grid inside the padded area
            int totalGridWidth  = (btnWidth * 2) + gapX;
            int totalGridHeight = (btnHeight * 4) + (gapY * 3);

            int startX = padX + (availableWidth - totalGridWidth) / 2;
            int startY = topOffset + (availableHeight - totalGridHeight) / 2;
            if (startY < topOffset) startY = topOffset;

            int col1X = startX;
            int col2X = startX + btnWidth + gapX;

            // Row 0
            btnAuth.SetBounds(col1X, startY, btnWidth, btnHeight);
            btnStudentRecords.SetBounds(col2X, startY, btnWidth, btnHeight);

            // Row 1
            int row1Y = startY + btnHeight + gapY;
            btnCourses.SetBounds(col1X, row1Y, btnWidth, btnHeight);
            btnAttendance.SetBounds(col2X, row1Y, btnWidth, btnHeight);

            // Row 2
            int row2Y = startY + (btnHeight + gapY) * 2;
            btnGrades.SetBounds(col1X, row2Y, btnWidth, btnHeight);
            btnFees.SetBounds(col2X, row2Y, btnWidth, btnHeight);

            // Row 3: Report Card (Centered with the EXACT same width & height as all other buttons!)
            int row3Y = startY + (btnHeight + gapY) * 3;
            int reportCardX = (availableWidth - btnWidth) / 2;
            btnReportCard.SetBounds(reportCardX, row3Y, btnWidth, btnHeight);
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            // Member 1: Launch Authentication / Login Form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnStudentRecords_Click(object sender, EventArgs e)
        {
            // Member 2: Launch Student Records Form
            StudentRecordsForm studentForm = new StudentRecordsForm();
            studentForm.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            // Member 3: Launch Course Management Form
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
