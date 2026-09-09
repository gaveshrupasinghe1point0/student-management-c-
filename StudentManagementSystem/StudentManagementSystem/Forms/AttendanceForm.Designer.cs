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
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(28, 73);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(1127, 233);
            this.dgvAttendance.TabIndex = 0;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(837, 352);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(186, 24);
            this.cmbStudent.TabIndex = 1;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(112, 352);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(211, 24);
            this.cmbCourse.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(28, 26);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(295, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Late"});
            this.cmbStatus.Location = new System.Drawing.Point(477, 352);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(186, 24);
            this.cmbStatus.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1033, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 660);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.dgvAttendance);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
    }
}