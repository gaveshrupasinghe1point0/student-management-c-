namespace StudentManagementSystem.Forms
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFees = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnStudentRecords = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportCard = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Green;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(107, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(523, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Management System (LMS)";
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
            this.btnFees.Location = new System.Drawing.Point(380, 182);
            this.btnFees.Margin = new System.Windows.Forms.Padding(8);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(346, 66);
            this.btnFees.TabIndex = 5;
            this.btnFees.Text = "6.  Fees";
            this.btnFees.UseVisualStyleBackColor = false;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
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
            this.btnAttendance.Location = new System.Drawing.Point(380, 100);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(8);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(346, 66);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "4.  Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
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
            this.btnStudentRecords.Location = new System.Drawing.Point(380, 18);
            this.btnStudentRecords.Margin = new System.Windows.Forms.Padding(8);
            this.btnStudentRecords.Name = "btnStudentRecords";
            this.btnStudentRecords.Size = new System.Drawing.Size(346, 66);
            this.btnStudentRecords.TabIndex = 1;
            this.btnStudentRecords.Text = "2.  Student Records";
            this.btnStudentRecords.UseVisualStyleBackColor = false;
            this.btnStudentRecords.Click += new System.EventHandler(this.btnStudentRecords_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlButtons.ColumnCount = 2;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlButtons.Controls.Add(this.btnReportCard, 0, 3);
            this.pnlButtons.Controls.Add(this.btnAuth, 0, 0);
            this.pnlButtons.Controls.Add(this.btnStudentRecords, 1, 0);
            this.pnlButtons.Controls.Add(this.btnCourses, 0, 1);
            this.pnlButtons.Controls.Add(this.btnAttendance, 1, 1);
            this.pnlButtons.Controls.Add(this.btnGrades, 0, 2);
            this.pnlButtons.Controls.Add(this.btnFees, 1, 2);
            this.pnlButtons.Location = new System.Drawing.Point(20, 95);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(10);
            this.pnlButtons.RowCount = 4;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlButtons.Size = new System.Drawing.Size(744, 350);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnReportCard
            // 
            this.btnReportCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlButtons.SetColumnSpan(this.btnReportCard, 2);
            this.btnReportCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportCard.FlatAppearance.BorderSize = 0;
            this.btnReportCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReportCard.ForeColor = System.Drawing.Color.White;
            this.btnReportCard.Location = new System.Drawing.Point(199, 265);
            this.btnReportCard.Margin = new System.Windows.Forms.Padding(8);
            this.btnReportCard.Name = "btnReportCard";
            this.btnReportCard.Size = new System.Drawing.Size(346, 66);
            this.btnReportCard.TabIndex = 7;
            this.btnReportCard.Text = "7.  Student Report Card";
            this.btnReportCard.UseVisualStyleBackColor = false;
            this.btnReportCard.Click += new System.EventHandler(this.btnReportCard_Click);
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
            this.btnAuth.Location = new System.Drawing.Point(18, 18);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(8);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(346, 66);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "1.  Auth / Roles";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(18, 100);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(8);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(346, 66);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "3.  Course Management";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
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
            this.btnGrades.Location = new System.Drawing.Point(18, 182);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(8);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(346, 66);
            this.btnGrades.TabIndex = 4;
            this.btnGrades.Text = "5.  Grades";
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - LMS Student Management System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnStudentRecords;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnReportCard;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnGrades;
    }
}
