namespace StudentManagementSystem.Forms
{
    partial class CourseEnrollmentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblHeader        = new System.Windows.Forms.Label();
            this.grpEnroll        = new System.Windows.Forms.GroupBox();
            this.btnUnenroll      = new System.Windows.Forms.Button();
            this.btnEnroll        = new System.Windows.Forms.Button();
            this.cmbCourses       = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse  = new System.Windows.Forms.Label();
            this.cmbStudents      = new System.Windows.Forms.ComboBox();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.dgvEnrollments   = new System.Windows.Forms.DataGridView();
            this.lblEnrollmentList= new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.grpEnroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor=System.Drawing.Color.FromArgb(142,68,173);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock=System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location=new System.Drawing.Point(0,0);
            this.pnlHeader.Name="pnlHeader"; this.pnlHeader.Size=new System.Drawing.Size(924,65); this.pnlHeader.TabIndex=0;
            // lblHeader
            this.lblHeader.AutoSize=true;
            this.lblHeader.Font=new System.Drawing.Font("Segoe UI",18F,System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor=System.Drawing.Color.White;
            this.lblHeader.Location=new System.Drawing.Point(18,15); this.lblHeader.Name="lblHeader"; this.lblHeader.TabIndex=0;
            this.lblHeader.Text="Course Enrollment Module";
            // grpEnroll — anchored Top+Left+Right so it stretches wide
            this.grpEnroll.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.grpEnroll.Controls.Add(this.btnUnenroll); this.grpEnroll.Controls.Add(this.btnEnroll);
            this.grpEnroll.Controls.Add(this.cmbCourses);  this.grpEnroll.Controls.Add(this.lblSelectCourse);
            this.grpEnroll.Controls.Add(this.cmbStudents); this.grpEnroll.Controls.Add(this.lblSelectStudent);
            this.grpEnroll.Font=new System.Drawing.Font("Segoe UI",9.75F,System.Drawing.FontStyle.Bold);
            this.grpEnroll.Location=new System.Drawing.Point(24,80); this.grpEnroll.Name="grpEnroll";
            this.grpEnroll.Size=new System.Drawing.Size(875,110); this.grpEnroll.TabIndex=1; this.grpEnroll.TabStop=false;
            this.grpEnroll.Text="Enrollment Action";
            // Controls inside grpEnroll
            this.lblSelectStudent.AutoSize=true; this.lblSelectStudent.Font=new System.Drawing.Font("Segoe UI",9.75F); this.lblSelectStudent.Location=new System.Drawing.Point(17,25); this.lblSelectStudent.Name="lblSelectStudent"; this.lblSelectStudent.Text="Select Student:";
            this.cmbStudents.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left; this.cmbStudents.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbStudents.Font=new System.Drawing.Font("Segoe UI",9.75F); this.cmbStudents.FormattingEnabled=true; this.cmbStudents.Location=new System.Drawing.Point(20,47); this.cmbStudents.Name="cmbStudents"; this.cmbStudents.Size=new System.Drawing.Size(280,25);
            this.lblSelectCourse.AutoSize=true; this.lblSelectCourse.Font=new System.Drawing.Font("Segoe UI",9.75F); this.lblSelectCourse.Location=new System.Drawing.Point(322,25); this.lblSelectCourse.Name="lblSelectCourse"; this.lblSelectCourse.Text="Select Course:";
            this.cmbCourses.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left; this.cmbCourses.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbCourses.Font=new System.Drawing.Font("Segoe UI",9.75F); this.cmbCourses.FormattingEnabled=true; this.cmbCourses.Location=new System.Drawing.Point(325,47); this.cmbCourses.Name="cmbCourses"; this.cmbCourses.Size=new System.Drawing.Size(265,25);
            this.btnEnroll.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right; this.btnEnroll.BackColor=System.Drawing.Color.FromArgb(46,204,113); this.btnEnroll.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnEnroll.Font=new System.Drawing.Font("Segoe UI",9.75F,System.Drawing.FontStyle.Bold); this.btnEnroll.ForeColor=System.Drawing.Color.White; this.btnEnroll.Location=new System.Drawing.Point(615,40); this.btnEnroll.Name="btnEnroll"; this.btnEnroll.Size=new System.Drawing.Size(115,38); this.btnEnroll.Text="Enroll Student"; this.btnEnroll.UseVisualStyleBackColor=false; this.btnEnroll.Click+=new System.EventHandler(this.btnEnroll_Click);
            this.btnUnenroll.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right; this.btnUnenroll.BackColor=System.Drawing.Color.FromArgb(231,76,60); this.btnUnenroll.FlatStyle=System.Windows.Forms.FlatStyle.Flat; this.btnUnenroll.Font=new System.Drawing.Font("Segoe UI",9.75F,System.Drawing.FontStyle.Bold); this.btnUnenroll.ForeColor=System.Drawing.Color.White; this.btnUnenroll.Location=new System.Drawing.Point(740,40); this.btnUnenroll.Name="btnUnenroll"; this.btnUnenroll.Size=new System.Drawing.Size(115,38); this.btnUnenroll.Text="Drop Course"; this.btnUnenroll.UseVisualStyleBackColor=false; this.btnUnenroll.Click+=new System.EventHandler(this.btnUnenroll_Click);
            // lblEnrollmentList
            this.lblEnrollmentList.AutoSize=true;
            this.lblEnrollmentList.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblEnrollmentList.Font=new System.Drawing.Font("Segoe UI",11.25F,System.Drawing.FontStyle.Bold);
            this.lblEnrollmentList.Location=new System.Drawing.Point(24,205); this.lblEnrollmentList.Name="lblEnrollmentList"; this.lblEnrollmentList.Text="Current Course Enrolments";
            // dgvEnrollments — anchored all sides
            this.dgvEnrollments.AllowUserToAddRows=false; this.dgvEnrollments.AllowUserToDeleteRows=false;
            this.dgvEnrollments.Anchor=System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvEnrollments.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollments.BackgroundColor=System.Drawing.Color.White;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollments.Location=new System.Drawing.Point(24,230); this.dgvEnrollments.MultiSelect=false; this.dgvEnrollments.Name="dgvEnrollments";
            this.dgvEnrollments.ReadOnly=true; this.dgvEnrollments.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size=new System.Drawing.Size(875,230); this.dgvEnrollments.TabIndex=2;
            // CourseEnrollmentForm
            this.AutoScaleDimensions=new System.Drawing.SizeF(7F,17F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor=System.Drawing.Color.FromArgb(236,240,241);
            this.ClientSize=new System.Drawing.Size(924,480);
            this.MinimumSize=new System.Drawing.Size(700,420);
            this.Controls.Add(this.lblEnrollmentList); this.Controls.Add(this.dgvEnrollments);
            this.Controls.Add(this.grpEnroll); this.Controls.Add(this.pnlHeader);
            this.Font=new System.Drawing.Font("Segoe UI",9.75F);
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name="CourseEnrollmentForm";
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="Course Enrollment Module - LMS";
            this.Load += new System.EventHandler(this.CourseEnrollmentForm_Load);
            this.pnlHeader.ResumeLayout(false); this.pnlHeader.PerformLayout();
            this.grpEnroll.ResumeLayout(false); this.grpEnroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpEnroll;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnUnenroll;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.Label lblEnrollmentList;
    }
}
