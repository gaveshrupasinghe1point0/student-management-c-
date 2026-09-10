namespace StudentManagementSystem.Forms
{
    partial class ReportCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCardForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.rtbReportPreview = new System.Windows.Forms.RichTextBox();
            this.pnlHeader.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(920, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(308, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Student Report Card";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.BackColor = System.Drawing.Color.White;
            this.grpSearch.Controls.Add(this.lblStudentInfo);
            this.grpSearch.Controls.Add(this.txtSearchStudent);
            this.grpSearch.Controls.Add(this.lblStudent);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpSearch.Location = new System.Drawing.Point(24, 80);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(872, 95);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Student";
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStudentInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblStudentInfo.Location = new System.Drawing.Point(105, 68);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(120, 19);
            this.lblStudentInfo.TabIndex = 2;
            this.lblStudentInfo.Text = "Enter Student ID...";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearchStudent.Location = new System.Drawing.Point(105, 38);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(320, 29);
            this.txtSearchStudent.TabIndex = 1;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStudent.Location = new System.Drawing.Point(20, 41);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(95, 23);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student ID:";
            // 
            // grpPreview
            // 
            this.grpPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPreview.BackColor = System.Drawing.Color.White;
            this.grpPreview.Controls.Add(this.rtbReportPreview);
            this.grpPreview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpPreview.Location = new System.Drawing.Point(24, 190);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(872, 380);
            this.grpPreview.TabIndex = 2;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Report Card Details";
            // 
            // rtbReportPreview
            // 
            this.rtbReportPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.rtbReportPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReportPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReportPreview.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReportPreview.Location = new System.Drawing.Point(3, 26);
            this.rtbReportPreview.Name = "rtbReportPreview";
            this.rtbReportPreview.ReadOnly = true;
            this.rtbReportPreview.Size = new System.Drawing.Size(866, 351);
            this.rtbReportPreview.TabIndex = 0;
            this.rtbReportPreview.Text = "";
            // 
            // ReportCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(920, 590);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Report Card";
            this.Load += new System.EventHandler(this.ReportCardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.RichTextBox rtbReportPreview;
    }
}
