namespace StudentManagementSystem.Forms
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblSubTitle      = new System.Windows.Forms.Label();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.pnlButtons       = new System.Windows.Forms.TableLayoutPanel();
            this.btnAuth          = new System.Windows.Forms.Button();
            this.btnStudentRecords= new System.Windows.Forms.Button();
            this.btnCourses       = new System.Windows.Forms.Button();
            this.btnAttendance    = new System.Windows.Forms.Button();
            this.btnGrades        = new System.Windows.Forms.Button();
            this.btnFees          = new System.Windows.Forms.Button();
            this.btnTimetable     = new System.Windows.Forms.Button();
            this.btnReportCard    = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 80);
            this.pnlHeader.TabIndex = 0;
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Management System (LMS)";
            // lblSubTitle
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblSubTitle.Location = new System.Drawing.Point(24, 52);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "CS107.3 - Object Oriented Programming with C#";
            // pnlButtons — TableLayoutPanel fills remaining space and stretches all buttons
            this.pnlButtons.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlButtons.ColumnCount = 2;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.RowCount = 4;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.Controls.Add(this.btnAuth,           0, 0);
            this.pnlButtons.Controls.Add(this.btnStudentRecords, 1, 0);
            this.pnlButtons.Controls.Add(this.btnCourses,        0, 1);
            this.pnlButtons.Controls.Add(this.btnAttendance,     1, 1);
            this.pnlButtons.Controls.Add(this.btnGrades,         0, 2);
            this.pnlButtons.Controls.Add(this.btnFees,           1, 2);
            this.pnlButtons.Controls.Add(this.btnTimetable,      0, 3);
            this.pnlButtons.Controls.Add(this.btnReportCard,     1, 3);
            this.pnlButtons.Location = new System.Drawing.Point(20, 95);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(10);
            this.pnlButtons.Size = new System.Drawing.Size(744, 350);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            // Shared button style helper
            System.Action<System.Windows.Forms.Button, string, System.Drawing.Color> styleBtn =
                (b, txt, clr) => {
                    b.BackColor = clr;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
                    b.ForeColor = System.Drawing.Color.White;
                    b.Text = txt;
                    b.Dock = System.Windows.Forms.DockStyle.Fill;
                    b.Margin = new System.Windows.Forms.Padding(8);
                    b.UseVisualStyleBackColor = false;
                    b.Cursor = System.Windows.Forms.Cursors.Hand;
                };
            var dark  = System.Drawing.Color.FromArgb(52, 73, 94);
            var blue  = System.Drawing.Color.FromArgb(41, 128, 185);
            styleBtn(this.btnAuth,           "1.  Auth / Roles",           dark);
            styleBtn(this.btnStudentRecords, "2.  Student Records",        dark);
            styleBtn(this.btnCourses,        "3.  Course Management",      blue);
            styleBtn(this.btnAttendance,     "4.  Attendance",             dark);
            styleBtn(this.btnGrades,         "5.  Grades",                 dark);
            styleBtn(this.btnFees,           "6.  Fees",                   dark);
            styleBtn(this.btnTimetable,      "7.  Timetable",              dark);
            styleBtn(this.btnReportCard,     "8.  Report Card Export",     dark);
            this.btnAuth.Click          += new System.EventHandler(this.btnAuth_Click);
            this.btnStudentRecords.Click += new System.EventHandler(this.btnStudentRecords_Click);
            this.btnCourses.Click       += new System.EventHandler(this.btnCourses_Click);
            this.btnAttendance.Click    += new System.EventHandler(this.btnAttendance_Click);
            this.btnGrades.Click        += new System.EventHandler(this.btnGrades_Click);
            this.btnFees.Click          += new System.EventHandler(this.btnFees_Click);
            this.btnTimetable.Click     += new System.EventHandler(this.btnTimetable_Click);
            this.btnReportCard.Click    += new System.EventHandler(this.btnReportCard_Click);
            // MainMenuForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - LMS Student Management System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnStudentRecords;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnReportCard;
    }
}
