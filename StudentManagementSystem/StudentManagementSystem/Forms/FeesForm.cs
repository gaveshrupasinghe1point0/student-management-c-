using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class FeesForm : Form
    {
        private readonly StudentRepository _studentRepository;
        private List<Student> _allStudents = new List<Student>();
        private Student _selectedStudent = null;

        public FeesForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
        }

        private void FeesForm_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0; // Default to "Paid"
            LoadStudents();
            LoadFeesGrid();
        }

        private void LoadStudents()
        {
            try
            {
                _allStudents = _studentRepository.GetAllStudents();

                var autoSource = new AutoCompleteStringCollection();
                foreach (var s in _allStudents)
                {
                    autoSource.Add(s.RegNumber);
                    autoSource.Add(s.StudentID.ToString());
                }

                txtStudentID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtStudentID.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtStudentID.AutoCompleteCustomSource = autoSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load students: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            ResolveStudent();
        }

        private void ResolveStudent()
        {
            string input = txtStudentID.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                _selectedStudent = null;
                lblStudentInfo.Text = "Enter Student ID...";
                lblStudentInfo.ForeColor = Color.DimGray;
                return;
            }

            var match = _allStudents.Find(s =>
                s.RegNumber.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                s.StudentID.ToString().Equals(input, StringComparison.OrdinalIgnoreCase));

            if (match == null)
            {
                match = _allStudents.Find(s => s.RegNumber.StartsWith(input, StringComparison.OrdinalIgnoreCase));
            }

            if (match != null)
            {
                _selectedStudent = match;
                lblStudentInfo.Text = $"✓ Student: {match.RegNumber} ({match.FirstName} {match.LastName})";
                lblStudentInfo.ForeColor = Color.DarkGreen;
            }
            else
            {
                _selectedStudent = null;
                lblStudentInfo.Text = "Invalid Student ID.";
                lblStudentInfo.ForeColor = Color.Crimson;
            }
        }

        private void LoadFeesGrid()
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        SELECT 
                            f.FeeID AS [Fee ID],
                            s.RegNumber AS [Student Reg No],
                            s.FirstName + ' ' + s.LastName AS [Student Name],
                            f.Amount AS [Amount (LKR)],
                            f.PaymentDate AS [Payment Date],
                            f.Status AS [Status],
                            f.CreatedAt AS [Recorded At]
                        FROM Fees f
                        INNER JOIN Students s ON f.StudentID = s.StudentID
                        ORDER BY f.PaymentDate DESC, f.FeeID DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFees.DataSource = dt;

                        if (dgvFees.Columns["Amount (LKR)"] != null)
                        {
                            dgvFees.Columns["Amount (LKR)"].DefaultCellStyle.Format = "N2";
                        }
                        if (dgvFees.Columns["Payment Date"] != null)
                        {
                            dgvFees.Columns["Payment Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load fee records: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please enter or select a valid Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a fee status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Fees (StudentID, Amount, PaymentDate, Status) VALUES (@StudentID, @Amount, @PaymentDate, @Status)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", _selectedStudent.StudentID);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Fee payment record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadFeesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save fee record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtStudentID.Clear();
            txtAmount.Clear();
            dtpPaymentDate.Value = DateTime.Today;
            cmbStatus.SelectedIndex = 0;
            _selectedStudent = null;
            lblStudentInfo.Text = "Enter Student ID...";
            lblStudentInfo.ForeColor = Color.DimGray;
            txtStudentID.Focus();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}

