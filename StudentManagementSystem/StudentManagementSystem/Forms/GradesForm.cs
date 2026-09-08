using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace StudentManagementSystem.Forms
{
    public partial class GradesForm : Form
    {
        // Setup the connection string
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";

        public GradesForm()
        {
            InitializeComponent();
            LoadDropdownData();
            LoadGradesData();
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
                    cmbStudent.DisplayMember = "StudentID";
                    cmbStudent.ValueMember = "StudentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdowns: " + ex.Message);
            }
        }

        private void LoadGradesData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Grades", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGrades.DataSource = dt; // Binds the table to your UI Grid
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
                    string query = "INSERT INTO Grades (StudentID, CourseID, GradeValue, Remarks) VALUES (@StudentID, @CourseID, @GradeValue, @Remarks)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Grab values from your UI controls
                    cmd.Parameters.AddWithValue("@StudentID", cmbStudent.SelectedValue);
                    cmd.Parameters.AddWithValue("@CourseID", cmbCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@GradeValue", txtGradeValue.Text);
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grade recorded successfully!");

                    // Clear inputs and refresh the grid to show the new entry instantly
                    txtGradeValue.Clear();
                    txtRemarks.Clear();
                    LoadGradesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message);
            }
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
