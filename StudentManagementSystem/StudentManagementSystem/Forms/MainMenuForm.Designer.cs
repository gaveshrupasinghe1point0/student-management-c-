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
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAuth.ForeColor = System.Drawing.Color.White;
            this.btnAuth.Margin = new System.Windows.Forms.Padding(8);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(350, 66);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "1.  Auth / Roles";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnStudentRecords
            // 
            this.btnStudentRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStudentRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentRecords.FlatAppearance.BorderSize = 0;
            this.btnStudentRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStudentRecords.ForeColor = System.Drawing.Color.White;
            this.btnStudentRecords.Margin = new System.Windows.Forms.Padding(8);
            this.btnStudentRecords.Name = "btnStudentRecords";
            this.btnStudentRecords.Size = new System.Drawing.Size(350, 66);
            this.btnStudentRecords.TabIndex = 1;
            this.btnStudentRecords.Text = "2.  Student Records";
            this.btnStudentRecords.UseVisualStyleBackColor = false;
            this.btnStudentRecords.Click += new System.EventHandler(this.btnStudentRecords_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Margin = new System.Windows.Forms.Padding(8);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(350, 66);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "3.  Course Management";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(8);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(350, 66);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "4.  Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrades.FlatAppearance.BorderSize = 0;
            this.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrades.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGrades.ForeColor = System.Drawing.Color.White;
            this.btnGrades.Margin = new System.Windows.Forms.Padding(8);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(350, 66);
            this.btnGrades.TabIndex = 4;
            this.btnGrades.Text = "5.  Grades";
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnFees
            // 
            this.btnFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFees.FlatAppearance.BorderSize = 0;
            this.btnFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFees.ForeColor = System.Drawing.Color.White;
            this.btnFees.Margin = new System.Windows.Forms.Padding(8);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(350, 66);
            this.btnFees.TabIndex = 5;
            this.btnFees.Text = "6.  Fees";
            this.btnFees.UseVisualStyleBackColor = false;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTimetable.ForeColor = System.Drawing.Color.White;
            this.btnTimetable.Margin = new System.Windows.Forms.Padding(8);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(350, 66);
            this.btnTimetable.TabIndex = 6;
            this.btnTimetable.Text = "7.  Timetable";
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnReportCard
            // 
            this.btnReportCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReportCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportCard.FlatAppearance.BorderSize = 0;
            this.btnReportCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReportCard.ForeColor = System.Drawing.Color.White;
            this.btnReportCard.Margin = new System.Windows.Forms.Padding(8);
            this.btnReportCard.Name = "btnReportCard";
            this.btnReportCard.Size = new System.Drawing.Size(350, 66);
            this.btnReportCard.TabIndex = 7;
            this.btnReportCard.Text = "8.  Report Card Export";
            this.btnReportCard.UseVisualStyleBackColor = false;
            this.btnReportCard.Click += new System.EventHandler(this.btnReportCard_Click);
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
