using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Exceptions;
using StudentManagementSystem.Core.Models;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both your username and password.",
                    "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = _userRepository.Authenticate(username, password);

                if (user.Role == "Admin")
                {
                    // Signal Program.cs that login succeeded → MainMenuForm will open
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Student account → open Student Profile Form
                    this.Hide();
                    StudentProfileForm profileForm = new StudentProfileForm(user);
                    profileForm.ShowDialog();
                    this.Close();
                }
            }
            catch (AuthenticationException authEx)
            {
                MessageBox.Show(authEx.Message, "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            catch (DatabaseException dbEx)
            {
                MessageBox.Show($"Database Error: {dbEx.Message}\n\n{dbEx.InnerException?.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string targetUrl = "https://www.nsbm.ac.lk/";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = targetUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }
    }
}
