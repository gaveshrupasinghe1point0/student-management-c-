using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class ReportCardForm : Form
    {
        private readonly StudentRepository _studentRepository;
        private List<Student> _allStudents = new List<Student>();
        private Student _selectedStudent = null;
        private DataTable _gradesTable = null;
        private DataTable _attendanceTable = null;
        private DataTable _coursesTable = null;

        public ReportCardForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
        }

        public ReportCardForm(Student student) : this()
        {
            _selectedStudent = student;
        }

        private void ReportCardForm_Load(object sender, EventArgs e)
        {
            if (_selectedStudent != null)
            {
                // Student POV: locked to logged-in student, hide search panel entirely
                grpSearch.Visible = false;
                this.Text = "My Academic Report Card";
                lblHeader.Text = "My Academic Report Card";
                grpPreview.Top = grpSearch.Top;
                grpPreview.Height = this.ClientSize.Height - grpPreview.Top - 20;
                GenerateReportCard();
            }
            else
            {
                // Admin POV: enable search by Student ID
                LoadStudentSearchData();
                rtbReportPreview.Text = "Please enter or select a Student ID above to view the report card.";
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
                MessageBox.Show($"Error loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            ResolveStudent();
        }

        private void ResolveStudent()
        {
            string input = txtSearchStudent.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                _selectedStudent = null;
                lblStudentInfo.Text = "Enter Student ID...";
                lblStudentInfo.ForeColor = Color.DimGray;
                rtbReportPreview.Text = "Please enter or select a Student ID above to view the report card.";
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
                GenerateReportCard();
            }
            else
            {
                _selectedStudent = null;
                lblStudentInfo.Text = "Invalid Student ID.";
                lblStudentInfo.ForeColor = Color.Crimson;
                rtbReportPreview.Text = "No student found with the provided Student ID.";
            }
        }

        private void GenerateReportCard()
        {
            if (_selectedStudent == null) return;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    // 1. Enrolled Courses
                    string courseQuery = @"
                        SELECT c.CourseCode, c.CourseName, c.Credits, c.Department, sc.Status
                        FROM StudentCourses sc
                        INNER JOIN Courses c ON sc.CourseID = c.CourseID
                        WHERE sc.StudentID = @StudentID
                        ORDER BY c.CourseCode";

                    using (SqlDataAdapter da = new SqlDataAdapter(courseQuery, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@StudentID", _selectedStudent.StudentID);
                        _coursesTable = new DataTable();
                        da.Fill(_coursesTable);
                    }

                    // 2. Grades
                    string gradesQuery = @"
                        SELECT c.CourseCode, c.CourseName, g.GradeValue, g.Remarks, g.RecordedDate
                        FROM Grades g
                        INNER JOIN Courses c ON g.CourseID = c.CourseID
                        WHERE g.StudentID = @StudentID
                        ORDER BY c.CourseCode";

                    using (SqlDataAdapter da = new SqlDataAdapter(gradesQuery, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@StudentID", _selectedStudent.StudentID);
                        _gradesTable = new DataTable();
                        da.Fill(_gradesTable);
                    }

                    // 3. Attendance Summary
                    string attendanceQuery = @"
                        SELECT 
                            c.CourseCode,
                            COUNT(*) AS TotalSessions,
                            SUM(CASE WHEN a.Status = 'Present' THEN 1 ELSE 0 END) AS PresentCount,
                            SUM(CASE WHEN a.Status = 'Late' THEN 1 ELSE 0 END) AS LateCount,
                            SUM(CASE WHEN a.Status = 'Absent' THEN 1 ELSE 0 END) AS AbsentCount
                        FROM Attendance a
                        INNER JOIN Courses c ON a.CourseID = c.CourseID
                        WHERE a.StudentID = @StudentID
                        GROUP BY c.CourseCode";

                    using (SqlDataAdapter da = new SqlDataAdapter(attendanceQuery, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@StudentID", _selectedStudent.StudentID);
                        _attendanceTable = new DataTable();
                        da.Fill(_attendanceTable);
                    }
                }

                // Render text preview
                RenderTextReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate report card: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderTextReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================================================================");
            sb.AppendLine("                         NSBM GREEN UNIVERSITY - STUDENT REPORT CARD                      ");
            sb.AppendLine("=========================================================================================");
            sb.AppendLine($"Generated Date : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"Student ID     : {_selectedStudent.RegNumber}");
            sb.AppendLine($"Student Name   : {_selectedStudent.FirstName} {_selectedStudent.LastName}");
            sb.AppendLine($"Email Address  : {_selectedStudent.Email}");
            sb.AppendLine($"Contact Phone  : {(string.IsNullOrWhiteSpace(_selectedStudent.Phone) ? "N/A" : _selectedStudent.Phone)}");
            sb.AppendLine($"Enrollment Date: {_selectedStudent.EnrollmentDate:yyyy-MM-dd}");
            sb.AppendLine("-----------------------------------------------------------------------------------------");
            sb.AppendLine();
            sb.AppendLine("1. ACADEMIC GRADES & PERFORMANCE");
            sb.AppendLine("-----------------------------------------------------------------------------------------");
            sb.AppendLine(string.Format("{0,-12} | {1,-35} | {2,-8} | {3,-20}", "Course Code", "Course Name", "Grade", "Remarks"));
            sb.AppendLine("-----------------------------------------------------------------------------------------");

            if (_gradesTable != null && _gradesTable.Rows.Count > 0)
            {
                foreach (DataRow row in _gradesTable.Rows)
                {
                    string code = row["CourseCode"].ToString();
                    string name = row["CourseName"].ToString();
                    if (name.Length > 33) name = name.Substring(0, 30) + "...";
                    string grade = row["GradeValue"].ToString();
                    string remarks = row["Remarks"] != DBNull.Value ? row["Remarks"].ToString() : "";
                    if (remarks.Length > 20) remarks = remarks.Substring(0, 17) + "...";

                    sb.AppendLine(string.Format("{0,-12} | {1,-35} | {2,-8} | {3,-20}", code, name, grade, remarks));
                }
            }
            else
            {
                sb.AppendLine("No academic grades recorded for this student.");
            }

            sb.AppendLine();
            sb.AppendLine("2. ATTENDANCE SUMMARY");
            sb.AppendLine("-----------------------------------------------------------------------------------------");
            sb.AppendLine(string.Format("{0,-12} | {1,-10} | {2,-10} | {3,-8} | {4,-8} | {5,-10}", "Course Code", "Sessions", "Present", "Late", "Absent", "Attendance %"));
            sb.AppendLine("-----------------------------------------------------------------------------------------");

            if (_attendanceTable != null && _attendanceTable.Rows.Count > 0)
            {
                foreach (DataRow row in _attendanceTable.Rows)
                {
                    string code = row["CourseCode"].ToString();
                    int total = Convert.ToInt32(row["TotalSessions"]);
                    int present = Convert.ToInt32(row["PresentCount"]);
                    int late = Convert.ToInt32(row["LateCount"]);
                    int absent = Convert.ToInt32(row["AbsentCount"]);
                    double pct = total > 0 ? ((double)(present + late) / total) * 100.0 : 0.0;

                    sb.AppendLine(string.Format("{0,-12} | {1,-10} | {2,-10} | {3,-8} | {4,-8} | {5,-10:F1}%", code, total, present, late, absent, pct));
                }
            }
            else
            {
                sb.AppendLine("No attendance records found for this student.");
            }

            sb.AppendLine();
            sb.AppendLine("3. ENROLLED COURSES");
            sb.AppendLine("-----------------------------------------------------------------------------------------");
            sb.AppendLine(string.Format("{0,-12} | {1,-35} | {2,-8} | {3,-15}", "Course Code", "Course Title", "Credits", "Status"));
            sb.AppendLine("-----------------------------------------------------------------------------------------");

            if (_coursesTable != null && _coursesTable.Rows.Count > 0)
            {
                foreach (DataRow row in _coursesTable.Rows)
                {
                    string code = row["CourseCode"].ToString();
                    string title = row["CourseName"].ToString();
                    if (title.Length > 33) title = title.Substring(0, 30) + "...";
                    string credits = row["Credits"].ToString();
                    string status = row["Status"].ToString();

                    sb.AppendLine(string.Format("{0,-12} | {1,-35} | {2,-8} | {3,-15}", code, title, credits, status));
                }
            }
            else
            {
                sb.AppendLine("No course enrollments found for this student.");
            }

            sb.AppendLine();
            sb.AppendLine("=========================================================================================");
            sb.AppendLine("                             END OF OFFICIAL REPORT CARD                                 ");
            sb.AppendLine("=========================================================================================");

            rtbReportPreview.Text = sb.ToString();
        }
    }
}
