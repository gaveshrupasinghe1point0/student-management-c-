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
    public partial class AttendanceForm : Form
    {
        private List<Student> _allStudents = new List<Student>();
        private Student _selectedStudent = null;

        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadDropdownData();
            LoadAttendanceData();
            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }
        }

        private void LoadDropdownData()
        {
            try
            {
                // Populate Students for Search Autocomplete
                StudentRepository studentRepo = new StudentRepository();
                _allStudents = studentRepo.GetAllStudents();

                var autoSource = new AutoCompleteStringCollection();
                foreach (var s in _allStudents)
                {
                    autoSource.Add(s.RegNumber);
                    autoSource.Add(s.StudentID.ToString());
                }
                txtSearchStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearchStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearchStudent.AutoCompleteCustomSource = autoSource;

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Populate Course Dropdown
                    string courseQuery = "SELECT CourseID, (CourseCode + ' - ' + CourseName) AS DisplayText FROM Courses WHERE IsActive = 1 ORDER BY CourseCode";
                    SqlDataAdapter daCourses = new SqlDataAdapter(courseQuery, conn);
                    DataTable dtCourses = new DataTable();
                    daCourses.Fill(dtCourses);
                    cmbCourse.DataSource = dtCourses;
                    cmbCourse.DisplayMember = "DisplayText";
                    cmbCourse.ValueMember = "CourseID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            ResolveSelectedStudent();
        }

        private void ResolveSelectedStudent()
        {
            string input = txtSearchStudent.Text.Trim();
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
                lblStudentInfo.Text = $"✓ Student ID: {match.RegNumber}";
                lblStudentInfo.ForeColor = Color.DarkGreen;
            }
            else
            {
                _selectedStudent = null;
                lblStudentInfo.Text = "Invalid Student ID.";
                lblStudentInfo.ForeColor = Color.Crimson;
            }
        }

        private void LoadAttendanceData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                                        a.AttendanceID AS [ID],
                                        s.RegNumber AS [Student Reg No],
                                        (s.FirstName + ' ' + s.LastName) AS [Student Name],
                                        c.CourseCode AS [Course Code],
                                        c.CourseName AS [Course Title],
                                        CONVERT(VARCHAR(10), a.Date, 120) AS [Date],
                                        a.Status AS [Status]
                                     FROM Attendance a
                                     INNER JOIN Students s ON a.StudentID = s.StudentID
                                     INNER JOIN Courses c ON a.CourseID = c.CourseID
                                     ORDER BY a.Date DESC, a.AttendanceID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAttendance.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please enter a valid Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchStudent.Focus();
                return;
            }

            if (cmbCourse.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.SelectedItem == null || string.IsNullOrWhiteSpace(cmbStatus.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select attendance status (Present, Absent, Late).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Attendance (StudentID, CourseID, Date, Status) VALUES (@StudentID, @CourseID, @Date, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@StudentID", _selectedStudent.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", Convert.ToInt32(cmbCourse.SelectedValue));
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString().Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Attendance recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSearchStudent.Clear();
                    _selectedStudent = null;
                    lblStudentInfo.Text = "Enter Student ID...";
                    lblStudentInfo.ForeColor = Color.DimGray;

                    LoadAttendanceData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchStudent.Clear();
            _selectedStudent = null;
            lblStudentInfo.Text = "Enter Student ID...";
            lblStudentInfo.ForeColor = Color.DimGray;
            if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;
        }
    }
}

