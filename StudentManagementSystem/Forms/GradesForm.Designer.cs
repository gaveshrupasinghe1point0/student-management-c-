namespace StudentManagementSystem.Forms
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpGrades = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtGradeValue = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Green;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(904, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(259, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(351, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Student Grades Module";
            // 
            // grpGrades
            // 
            this.grpGrades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrades.Controls.Add(this.btnClear);
            this.grpGrades.Controls.Add(this.btnSave);
            this.grpGrades.Controls.Add(this.txtRemarks);
            this.grpGrades.Controls.Add(this.lblRemarks);
            this.grpGrades.Controls.Add(this.txtGradeValue);
            this.grpGrades.Controls.Add(this.lblGrade);
            this.grpGrades.Controls.Add(this.cmbCourse);
            this.grpGrades.Controls.Add(this.lblCourse);
            this.grpGrades.Controls.Add(this.lblStudentInfo);
            this.grpGrades.Controls.Add(this.txtSearchStudent);
            this.grpGrades.Controls.Add(this.lblStudent);
            this.grpGrades.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpGrades.Location = new System.Drawing.Point(24, 80);
            this.grpGrades.Name = "grpGrades";
            this.grpGrades.Size = new System.Drawing.Size(855, 140);
            this.grpGrades.TabIndex = 1;
            this.grpGrades.TabStop = false;
            this.grpGrades.Text = "Record Student Grade";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(725, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 42);
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
            this.btnSave.Location = new System.Drawing.Point(595, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Grade";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRemarks.Location = new System.Drawing.Point(365, 89);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(195, 29);
            this.txtRemarks.TabIndex = 7;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRemarks.Location = new System.Drawing.Point(300, 92);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(78, 23);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtGradeValue
            // 
            this.txtGradeValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGradeValue.Location = new System.Drawing.Point(80, 89);
            this.txtGradeValue.Name = "txtGradeValue";
            this.txtGradeValue.Size = new System.Drawing.Size(200, 29);
            this.txtGradeValue.TabIndex = 5;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGrade.Location = new System.Drawing.Point(20, 92);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(60, 23);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(365, 38);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(195, 29);
            this.cmbCourse.TabIndex = 3;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCourse.Location = new System.Drawing.Point(300, 41);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(67, 23);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course:";
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStudentInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblStudentInfo.Location = new System.Drawing.Point(85, 68);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(120, 19);
            this.lblStudentInfo.TabIndex = 2;
            this.lblStudentInfo.Text = "Enter Student ID...";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearchStudent.Location = new System.Drawing.Point(85, 38);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(195, 29);
            this.txtSearchStudent.TabIndex = 1;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStudent.Location = new System.Drawing.Point(12, 41);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(95, 23);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student ID:";
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.Location = new System.Drawing.Point(24, 235);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(164, 25);
            this.lblGridTitle.TabIndex = 2;
            this.lblGridTitle.Text = "Recorded Grades";
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(24, 265);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.RowTemplate.Height = 24;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(855, 310);
            this.dgvGrades.TabIndex = 3;
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 600);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.grpGrades);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades Management";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpGrades.ResumeLayout(false);
            this.grpGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpGrades;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGradeValue;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvGrades;
    }
}