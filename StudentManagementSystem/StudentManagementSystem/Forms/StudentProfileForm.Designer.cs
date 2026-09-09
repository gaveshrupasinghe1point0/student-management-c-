namespace StudentManagementSystem.Forms
{
    partial class StudentProfileForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.lblPhoneVal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmailVal = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegNoVal = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblNameVal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCourses = new System.Windows.Forms.GroupBox();
            this.dgvEnrolledCourses = new System.Windows.Forms.DataGridView();
            this.grpGrades = new System.Windows.Forms.GroupBox();
            this.dgvMyGrades = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpProfile.SuspendLayout();
            this.grpCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledCourses)).BeginInit();
            this.grpGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(960, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Location = new System.Drawing.Point(530, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 22);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, Student";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(845, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(22, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(262, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Student Portal Profile";
            // 
            // grpProfile
            // 
            this.grpProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProfile.BackColor = System.Drawing.Color.White;
            this.grpProfile.Controls.Add(this.lblPhoneVal);
            this.grpProfile.Controls.Add(this.lblPhone);
            this.grpProfile.Controls.Add(this.lblEmailVal);
            this.grpProfile.Controls.Add(this.lblEmail);
            this.grpProfile.Controls.Add(this.lblRegNoVal);
            this.grpProfile.Controls.Add(this.lblRegNo);
            this.grpProfile.Controls.Add(this.lblNameVal);
            this.grpProfile.Controls.Add(this.lblName);
            this.grpProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpProfile.Location = new System.Drawing.Point(24, 85);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(912, 100);
            this.grpProfile.TabIndex = 1;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Student Details";
            // 
            // lblPhoneVal
            // 
            this.lblPhoneVal.AutoSize = true;
            this.lblPhoneVal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPhoneVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPhoneVal.Location = new System.Drawing.Point(620, 60);
            this.lblPhoneVal.Name = "lblPhoneVal";
            this.lblPhoneVal.Size = new System.Drawing.Size(13, 17);
            this.lblPhoneVal.TabIndex = 7;
            this.lblPhoneVal.Text = "-";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(530, 60);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 17);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmailVal
            // 
            this.lblEmailVal.AutoSize = true;
            this.lblEmailVal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEmailVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblEmailVal.Location = new System.Drawing.Point(620, 30);
            this.lblEmailVal.Name = "lblEmailVal";
            this.lblEmailVal.Size = new System.Drawing.Size(13, 17);
            this.lblEmailVal.TabIndex = 5;
            this.lblEmailVal.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(530, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblRegNoVal
            // 
            this.lblRegNoVal.AutoSize = true;
            this.lblRegNoVal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRegNoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRegNoVal.Location = new System.Drawing.Point(145, 60);
            this.lblRegNoVal.Name = "lblRegNoVal";
            this.lblRegNoVal.Size = new System.Drawing.Size(13, 17);
            this.lblRegNoVal.TabIndex = 3;
            this.lblRegNoVal.Text = "-";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegNo.ForeColor = System.Drawing.Color.Gray;
            this.lblRegNo.Location = new System.Drawing.Point(30, 60);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(77, 17);
            this.lblRegNo.TabIndex = 2;
            this.lblRegNo.Text = "Student ID:";
            // 
            // lblNameVal
            // 
            this.lblNameVal.AutoSize = true;
            this.lblNameVal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblNameVal.Location = new System.Drawing.Point(145, 30);
            this.lblNameVal.Name = "lblNameVal";
            this.lblNameVal.Size = new System.Drawing.Size(13, 17);
            this.lblNameVal.TabIndex = 1;
            this.lblNameVal.Text = "-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name:";
            // 
            // grpCourses
            // 
            this.grpCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCourses.BackColor = System.Drawing.Color.White;
            this.grpCourses.Controls.Add(this.dgvEnrolledCourses);
            this.grpCourses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpCourses.Location = new System.Drawing.Point(24, 200);
            this.grpCourses.Name = "grpCourses";
            this.grpCourses.Size = new System.Drawing.Size(912, 190);
            this.grpCourses.TabIndex = 2;
            this.grpCourses.TabStop = false;
            this.grpCourses.Text = "Enrolled Courses";
            // 
            // dgvEnrolledCourses
            // 
            this.dgvEnrolledCourses.AllowUserToAddRows = false;
            this.dgvEnrolledCourses.AllowUserToDeleteRows = false;
            this.dgvEnrolledCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnrolledCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrolledCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvEnrolledCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolledCourses.Location = new System.Drawing.Point(15, 28);
            this.dgvEnrolledCourses.MultiSelect = false;
            this.dgvEnrolledCourses.Name = "dgvEnrolledCourses";
            this.dgvEnrolledCourses.ReadOnly = true;
            this.dgvEnrolledCourses.RowHeadersVisible = false;
            this.dgvEnrolledCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrolledCourses.Size = new System.Drawing.Size(880, 145);
            this.dgvEnrolledCourses.TabIndex = 0;
            // 
            // grpGrades
            // 
            this.grpGrades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrades.BackColor = System.Drawing.Color.White;
            this.grpGrades.Controls.Add(this.dgvMyGrades);
            this.grpGrades.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpGrades.Location = new System.Drawing.Point(24, 400);
            this.grpGrades.Name = "grpGrades";
            this.grpGrades.Size = new System.Drawing.Size(912, 175);
            this.grpGrades.TabIndex = 3;
            this.grpGrades.TabStop = false;
            this.grpGrades.Text = "My Grades & Academic Results";
            // 
            // dgvMyGrades
            // 
            this.dgvMyGrades.AllowUserToAddRows = false;
            this.dgvMyGrades.AllowUserToDeleteRows = false;
            this.dgvMyGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMyGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyGrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvMyGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyGrades.Location = new System.Drawing.Point(15, 28);
            this.dgvMyGrades.MultiSelect = false;
            this.dgvMyGrades.Name = "dgvMyGrades";
            this.dgvMyGrades.ReadOnly = true;
            this.dgvMyGrades.RowHeadersVisible = false;
            this.dgvMyGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyGrades.Size = new System.Drawing.Size(880, 130);
            this.dgvMyGrades.TabIndex = 0;
            // 
            // StudentProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(960, 595);
            this.Controls.Add(this.grpGrades);
            this.Controls.Add(this.grpCourses);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "StudentProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Portal - My Profile";
            this.Load += new System.EventHandler(this.StudentProfileForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.grpCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolledCourses)).EndInit();
            this.grpGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameVal;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblRegNoVal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailVal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneVal;
        private System.Windows.Forms.GroupBox grpCourses;
        private System.Windows.Forms.DataGridView dgvEnrolledCourses;
        private System.Windows.Forms.GroupBox grpGrades;
        private System.Windows.Forms.DataGridView dgvMyGrades;
    }
}