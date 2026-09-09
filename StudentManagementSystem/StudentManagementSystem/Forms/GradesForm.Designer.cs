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
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtGradeValue = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrades
            // 
            this.dgvGrades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(35, 26);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.RowTemplate.Height = 24;
            this.dgvGrades.Size = new System.Drawing.Size(486, 230);
            this.dgvGrades.TabIndex = 0;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(617, 43);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(135, 24);
            this.cmbStudent.TabIndex = 1;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(619, 139);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(133, 24);
            this.cmbCourse.TabIndex = 2;
            // 
            // txtGradeValue
            // 
            this.txtGradeValue.Location = new System.Drawing.Point(66, 358);
            this.txtGradeValue.Name = "txtGradeValue";
            this.txtGradeValue.Size = new System.Drawing.Size(167, 22);
            this.txtGradeValue.TabIndex = 3;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(408, 358);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(167, 22);
            this.txtRemarks.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(650, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remarks";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtGradeValue);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.dgvGrades);
            this.Name = "GradesForm";
            this.Text = "GradesForm";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtGradeValue;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}