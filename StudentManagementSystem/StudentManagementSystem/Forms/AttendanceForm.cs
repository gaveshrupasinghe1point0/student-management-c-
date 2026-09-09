using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementSystem.Forms
{
    public partial class AttendanceForm : Form
    {
        // 1. Setup the connection string to the local database you created
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";

        public AttendanceForm()
        {
            InitializeComponent();
            LoadDropdownData();
            LoadAttendanceData();
        }

        private void LoadDropdownData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Populate Course Dropdown
                    SqlDataAdapter daCourses = new SqlDataAdapter("SELECT CourseID, CourseName FROM Courses", conn);
                    DataTable dtCourses = new DataTable();
                    daCourses.Fill(dtCourses);
                    cmbCourse.DataSource = dtCourses;
                    cmbCourse.DisplayMember = "CourseName";
                    cmbCourse.ValueMember = "CourseID";

                    // Populate Student Dropdown
                    SqlDataAdapter daStudents = new SqlDataAdapter("SELECT StudentID FROM Students", conn);
                    DataTable dtStudents = new DataTable();
                    daStudents.Fill(dtStudents);
                    cmbStudent.DataSource = dtStudents;
                    cmbStudent.DisplayMember = "StudentID"; // Assuming Gavesh used StudentID as the primary column
                    cmbStudent.ValueMember = "StudentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database missing Courses/Students to load: " + ex.Message);
            }
        }

        private void LoadAttendanceData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Attendance", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAttendance.DataSource = dt; // Binds the table to your UI Grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Attendance (StudentID, CourseID, Date, Status) VALUES (@StudentID, @CourseID, @Date, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Grab values from your UI controls
                    cmd.Parameters.AddWithValue("@StudentID", cmbStudent.SelectedValue);
                    cmd.Parameters.AddWithValue("@CourseID", cmbCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance recorded successfully!");

                    // Refresh the grid to show the new entry instantly
                    LoadAttendanceData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message);
            }
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

