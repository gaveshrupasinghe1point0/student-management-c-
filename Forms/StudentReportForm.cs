using System;
using System.Windows.Forms;
using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Exceptions;

namespace StudentManagementSystem.Forms
{
    /// <summary>
    /// Owned by: Member 8 (Report Card Export module).
    ///
    /// Purpose: given a student ID, pull together their attendance %,
    /// grades/GPA, and fee balance from the other modules' tables into
    /// one summary view - and let the user export/print it.
    ///
    /// This is intentionally the LAST module to build - it only works
    /// once Attendance (Member 4), Grades (Member 5), and Fees (Member 6)
    /// have real data in the database.
    /// </summary>
    public class StudentReportForm : Form
    {
        private TextBox _studentIdInput;
        private TextBox _reportOutput;
        private Button _generateButton;
        private Button _exportButton;

        public StudentReportForm()
        {
            Text = "Student Report Card";
            Width = 500;
            Height = 500;

            var idLabel = new Label { Text = "Student ID:", Top = 20, Left = 20, Width = 80 };
            _studentIdInput = new TextBox { Top = 20, Left = 110, Width = 150 };

            _generateButton = new Button { Text = "Generate", Top = 18, Left = 280, Width = 90 };
            _generateButton.Click += GenerateButton_Click;

            _reportOutput = new TextBox
            {
                Top = 60,
                Left = 20,
                Width = 440,
                Height = 340,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            _exportButton = new Button { Text = "Export as PDF / Print", Top = 415, Left = 20, Width = 200 };
            _exportButton.Click += ExportButton_Click;

            Controls.Add(idLabel);
            Controls.Add(_studentIdInput);
            Controls.Add(_generateButton);
            Controls.Add(_reportOutput);
            Controls.Add(_exportButton);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(_studentIdInput.Text);

                // TODO (Member 8): replace these three calls with real queries
                // against the tables Member 2/4/5/6 already created.
                var studentName = GetStudentName(studentId);
                var attendancePercent = GetAttendancePercent(studentId);
                var gpa = GetGpa(studentId);
                var feeBalance = GetFeeBalance(studentId);

                _reportOutput.Text =
                    $"STUDENT REPORT CARD\n" +
                    $"====================\n\n" +
                    $"Name: {studentName}\n" +
                    $"Student ID: {studentId}\n\n" +
                    $"Attendance: {attendancePercent:F1}%\n" +
                    $"GPA: {gpa:F2}\n" +
                    $"Outstanding fee balance: {feeBalance:C}\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Student ID.");
            }
            catch (RecordNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_reportOutput.Text))
            {
                MessageBox.Show("Generate a report first.");
                return;
            }

            // TODO (Member 8): write _reportOutput.Text to a PDF using a library
            // like iTextSharp / QuestPDF, or just export as .txt for a simpler version.
            MessageBox.Show("Export not implemented yet - start with a .txt file, upgrade to PDF if time allows.");
        }

        // ---- Stub data-access methods: replace each with a real DatabaseHelper query ----

        private string GetStudentName(int studentId)
        {
            // Example real version:
            // var result = DatabaseHelper.ExecuteScalar(
            //     "SELECT FullName FROM Students WHERE Id = @id",
            //     new SqlParameter("@id", studentId));
            // if (result == null) throw new RecordNotFoundException($"No student with ID {studentId}.");
            // return result.ToString();
            return "TODO: query Students table";
        }

        private double GetAttendancePercent(int studentId)
        {
            // TODO: query AttendanceRecords table, calculate (present / total) * 100
            return 0.0;
        }

        private double GetGpa(int studentId)
        {
            // TODO: query Grades table, average all grades for this student
            return 0.0;
        }

        private decimal GetFeeBalance(int studentId)
        {
            // TODO: query Students table's OutstandingBalance column
            return 0m;
        }
    }
}
