namespace StudentManagementSystem.Forms
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpAttendance = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Green;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(678, 53);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(171, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(335, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Student Attendance Module";
            // 
            // grpAttendance
            // 
            this.grpAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAttendance.Controls.Add(this.btnClear);
            this.grpAttendance.Controls.Add(this.btnSave);
            this.grpAttendance.Controls.Add(this.cmbStatus);
            this.grpAttendance.Controls.Add(this.lblStatus);
            this.grpAttendance.Controls.Add(this.dtpDate);
            this.grpAttendance.Controls.Add(this.lblDate);
            this.grpAttendance.Controls.Add(this.cmbCourse);
            this.grpAttendance.Controls.Add(this.lblCourse);
            this.grpAttendance.Controls.Add(this.lblStudentInfo);
            this.grpAttendance.Controls.Add(this.txtSearchStudent);
            this.grpAttendance.Controls.Add(this.lblStudent);
            this.grpAttendance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpAttendance.Location = new System.Drawing.Point(18, 65);
            this.grpAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAttendance.Name = "grpAttendance";
            this.grpAttendance.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAttendance.Size = new System.Drawing.Size(641, 114);
            this.grpAttendance.TabIndex = 1;
            this.grpAttendance.TabStop = false;
            this.grpAttendance.Text = "Record Attendance";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(532, 42);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(424, 42);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Late"});
            this.cmbStatus.Location = new System.Drawing.Point(259, 83);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(106, 25);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(214, 85);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(52, 83);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(144, 25);
            this.dtpDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDate.Location = new System.Drawing.Point(15, 85);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(214, 39);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(151, 25);
            this.cmbCourse.TabIndex = 3;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCourse.Location = new System.Drawing.Point(214, 20);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(90, 17);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Select Course:";
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStudentInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblStudentInfo.Location = new System.Drawing.Point(14, 63);
            this.lblStudentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(101, 15);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Enter Student ID...";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearchStudent.Location = new System.Drawing.Point(15, 39);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(181, 25);
            this.txtSearchStudent.TabIndex = 0;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStudent.Location = new System.Drawing.Point(14, 20);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(71, 17);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student ID:";
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.Location = new System.Drawing.Point(18, 191);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(150, 20);
            this.lblGridTitle.TabIndex = 2;
            this.lblGridTitle.Text = "Attendance Records";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(18, 215);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(641, 252);
            this.dgvAttendance.TabIndex = 3;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 488);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.grpAttendance);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Management";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpAttendance.ResumeLayout(false);
            this.grpAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpAttendance;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}