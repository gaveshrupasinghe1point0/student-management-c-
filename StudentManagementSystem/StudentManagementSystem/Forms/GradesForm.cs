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
    public partial class GradesForm : Form
    {
        private readonly StudentRepository _studentRepository;
        private List<Student> _allStudents = new List<Student>();
        private Student _selectedStudent = null;

        public GradesForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            LoadCourseDropdown();
            LoadStudentSearchData();
            LoadGradesData();
        }

        private void LoadCourseDropdown()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
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
                MessageBox.Show("Error loading course options: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentSearchData()
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

                txtSearchStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearchStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearchStudent.AutoCompleteCustomSource = autoSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student search data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadGradesData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                                        g.GradeID AS [ID],
                                        s.RegNumber AS [Student Reg No],
                                        (s.FirstName + ' ' + s.LastName) AS [Student Name],
                                        c.CourseCode AS [Course Code],
                                        c.CourseName AS [Course Title],
                                        g.GradeValue AS [Grade],
                                        g.Remarks AS [Remarks],
                                        CONVERT(VARCHAR(19), g.RecordedDate, 120) AS [Recorded At]
                                     FROM Grades g
                                     INNER JOIN Students s ON g.StudentID = s.StudentID
                                     INNER JOIN Courses c ON g.CourseID = c.CourseID
                                     ORDER BY g.GradeID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGrades.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtGradeValue.Text))
            {
                MessageBox.Show("Please enter a grade value (e.g. A, B+, 85).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGradeValue.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Grades (StudentID, CourseID, GradeValue, Remarks) VALUES (@StudentID, @CourseID, @GradeValue, @Remarks)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@StudentID", _selectedStudent.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", Convert.ToInt32(cmbCourse.SelectedValue));
                    cmd.Parameters.AddWithValue("@GradeValue", txtGradeValue.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@Remarks", string.IsNullOrWhiteSpace(txtRemarks.Text) ? (object)DBNull.Value : txtRemarks.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Grade recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    LoadGradesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearchStudent.Clear();
            _selectedStudent = null;
            lblStudentInfo.Text = "Enter Student ID...";
            lblStudentInfo.ForeColor = Color.DimGray;

            if (cmbCourse.Items.Count > 0) cmbCourse.SelectedIndex = 0;
            txtGradeValue.Clear();
            txtRemarks.Clear();
            txtSearchStudent.Focus();
        }
    }
}

