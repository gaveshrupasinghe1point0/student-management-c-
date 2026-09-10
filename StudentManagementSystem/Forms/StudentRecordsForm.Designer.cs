namespace StudentManagementSystem.Forms
{
    partial class StudentRecordsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecordsForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.grpLoginCredentials = new System.Windows.Forms.GroupBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlHeader.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            this.grpLoginCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Green;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(258, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(358, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Student Records Management";
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.dtpDOB);
            this.grpStudentDetails.Controls.Add(this.lblDOB);
            this.grpStudentDetails.Controls.Add(this.txtAddress);
            this.grpStudentDetails.Controls.Add(this.lblAddress);
            this.grpStudentDetails.Controls.Add(this.txtPhone);
            this.grpStudentDetails.Controls.Add(this.lblPhone);
            this.grpStudentDetails.Controls.Add(this.txtEmail);
            this.grpStudentDetails.Controls.Add(this.lblEmail);
            this.grpStudentDetails.Controls.Add(this.txtLastName);
            this.grpStudentDetails.Controls.Add(this.lblLastName);
            this.grpStudentDetails.Controls.Add(this.txtFirstName);
            this.grpStudentDetails.Controls.Add(this.lblFirstName);
            this.grpStudentDetails.Controls.Add(this.txtRegNumber);
            this.grpStudentDetails.Controls.Add(this.lblRegNumber);
            this.grpStudentDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpStudentDetails.Location = new System.Drawing.Point(24, 80);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(360, 310);
            this.grpStudentDetails.TabIndex = 1;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Personal Info";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(120, 265);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(220, 25);
            this.dtpDOB.TabIndex = 0;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDOB.Location = new System.Drawing.Point(18, 268);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(84, 17);
            this.lblDOB.TabIndex = 1;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAddress.Location = new System.Drawing.Point(120, 225);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 25);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAddress.Location = new System.Drawing.Point(18, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPhone.Location = new System.Drawing.Point(120, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 25);
            this.txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPhone.Location = new System.Drawing.Point(18, 188);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 17);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(120, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(18, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLastName.Location = new System.Drawing.Point(120, 105);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(220, 25);
            this.txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLastName.Location = new System.Drawing.Point(18, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 17);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFirstName.Location = new System.Drawing.Point(120, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 25);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFirstName.Location = new System.Drawing.Point(18, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(74, 17);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRegNumber.Location = new System.Drawing.Point(120, 25);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(220, 25);
            this.txtRegNumber.TabIndex = 12;
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRegNumber.Location = new System.Drawing.Point(18, 28);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(56, 17);
            this.lblRegNumber.TabIndex = 13;
            this.lblRegNumber.Text = "Reg No:";
            // 
            // grpLoginCredentials
            // 
            this.grpLoginCredentials.Controls.Add(this.txtLoginPassword);
            this.grpLoginCredentials.Controls.Add(this.lblLoginPassword);
            this.grpLoginCredentials.Controls.Add(this.txtLoginUsername);
            this.grpLoginCredentials.Controls.Add(this.lblLoginUsername);
            this.grpLoginCredentials.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpLoginCredentials.Location = new System.Drawing.Point(24, 400);
            this.grpLoginCredentials.Name = "grpLoginCredentials";
            this.grpLoginCredentials.Size = new System.Drawing.Size(360, 100);
            this.grpLoginCredentials.TabIndex = 9;
            this.grpLoginCredentials.TabStop = false;
            this.grpLoginCredentials.Text = "Login Credentials";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoginPassword.Location = new System.Drawing.Point(120, 62);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(220, 25);
            this.txtLoginPassword.TabIndex = 0;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLoginPassword.Location = new System.Drawing.Point(18, 65);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(67, 17);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password:";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLoginUsername.Location = new System.Drawing.Point(120, 27);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(220, 25);
            this.txtLoginUsername.TabIndex = 2;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLoginUsername.Location = new System.Drawing.Point(18, 30);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(70, 17);
            this.lblLoginUsername.TabIndex = 3;
            this.lblLoginUsername.Text = "Username:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 515);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(115, 515);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(206, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(297, 515);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(405, 105);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(535, 445);
            this.dgvStudents.TabIndex = 7;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStudentList.Location = new System.Drawing.Point(405, 80);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(150, 20);
            this.lblStudentList.TabIndex = 8;
            this.lblStudentList.Text = "Registered Students";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(625, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(84, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search by ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(715, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StudentRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(964, 570);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpLoginCredentials);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "StudentRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Records Management";
            this.Load += new System.EventHandler(this.StudentRecordsForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpLoginCredentials.ResumeLayout(false);
            this.grpLoginCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpLoginCredentials;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
