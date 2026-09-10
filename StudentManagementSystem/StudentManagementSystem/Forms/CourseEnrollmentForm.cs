using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Exceptions;
using StudentManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class CourseEnrollmentForm : Form
    {
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly StudentRepository _studentRepository;
        private readonly CourseRepository _courseRepository;
        private List<Student> _allStudents = new List<Student>();
        private Student _selectedStudent = null;

        public CourseEnrollmentForm()
        {
            InitializeComponent();
            _enrollmentRepository = new EnrollmentRepository();
            _studentRepository = new StudentRepository();
            _courseRepository = new CourseRepository();
        }

        private void CourseEnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadEnrollments();
        }

        private void LoadDropdowns()
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

                var courses = _courseRepository.GetAllCourses();
                cmbCourses.DataSource = null;
                cmbCourses.DataSource = courses;
                cmbCourses.DisplayMember = "CourseName";
                cmbCourses.ValueMember = "CourseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadEnrollments()
        {
            try
            {
                DataTable dt = _enrollmentRepository.GetAllEnrollmentsView();
                dgvEnrollments.DataSource = dt;
                FormatGridColumns();
            }
            catch (DatabaseException dbEx)
            {
                MessageBox.Show($"Database Error: {dbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load enrollments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridColumns()
        {
            if (dgvEnrollments.Columns["EnrollmentID"] != null)
                dgvEnrollments.Columns["EnrollmentID"].Visible = false;

            if (dgvEnrollments.Columns["StudentID"] != null)
                dgvEnrollments.Columns["StudentID"].Visible = false;

            if (dgvEnrollments.Columns["CourseID"] != null)
                dgvEnrollments.Columns["CourseID"].Visible = false;

            if (dgvEnrollments.Columns["RegNumber"] != null)
                dgvEnrollments.Columns["RegNumber"].HeaderText = "Reg No";

            if (dgvEnrollments.Columns["StudentName"] != null)
                dgvEnrollments.Columns["StudentName"].HeaderText = "Student Name";

            if (dgvEnrollments.Columns["CourseCode"] != null)
                dgvEnrollments.Columns["CourseCode"].HeaderText = "Course Code";

            if (dgvEnrollments.Columns["CourseName"] != null)
                dgvEnrollments.Columns["CourseName"].HeaderText = "Course Title";

            if (dgvEnrollments.Columns["EnrollmentDate"] != null)
                dgvEnrollments.Columns["EnrollmentDate"].HeaderText = "Enrollment Date";

            if (dgvEnrollments.Columns["Status"] != null)
                dgvEnrollments.Columns["Status"].HeaderText = "Status";
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please enter a valid Student ID.", "Student Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchStudent.Focus();
                return;
            }

            if (cmbCourses.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.", "Course Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = _selectedStudent.StudentID;
            int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

            try
            {
                _enrollmentRepository.EnrollStudent(studentId, courseId);

                MessageBox.Show("Student successfully enrolled in course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSearchStudent.Clear();
                _selectedStudent = null;
                lblStudentInfo.Text = "Enter Student ID...";
                lblStudentInfo.ForeColor = Color.DimGray;

                LoadEnrollments();
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show(valEx.Message, "Enrollment Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DatabaseException dbEx)
            {
                MessageBox.Show($"Database Error: {dbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to enroll student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an enrollment record from the table to drop.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRow = (DataRowView)dgvEnrollments.SelectedRows[0].DataBoundItem;
            int studentId = Convert.ToInt32(selectedRow["StudentID"]);
            int courseId = Convert.ToInt32(selectedRow["CourseID"]);
            string studentName = selectedRow["StudentName"].ToString();
            string courseCode = selectedRow["CourseCode"].ToString();

            var confirm = MessageBox.Show($"Are you sure you want to drop course '{courseCode}' for student '{studentName}'?",
                "Confirm Course Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                _enrollmentRepository.UnenrollStudent(studentId, courseId);

                MessageBox.Show("Student successfully dropped from course.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEnrollments();
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show(valEx.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DatabaseException dbEx)
            {
                MessageBox.Show($"Database Error: {dbEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to drop course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
