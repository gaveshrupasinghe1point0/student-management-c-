using StudentManagementSystem.Core.Data;
using StudentManagementSystem.Core.Exceptions;
using StudentManagementSystem.Core.Models;
using System;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly UserRepository _userRepository;

        public RegisterForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();

            if (cmbAccountType.Items.Count > 0)
                cmbAccountType.SelectedIndex = 1; // Default Student

            if (cmbGender.Items.Count > 0)
                cmbGender.SelectedIndex = 0; // Default Male
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Email domain check for students
            if (!string.IsNullOrEmpty(txtEmail.Text) &&
                !txtEmail.Text.EndsWith("@students.nsbm.ac.lk") &&
                cmbAccountType.SelectedItem != null &&
                cmbAccountType.SelectedItem.ToString() == "Student")
            {
                MessageBox.Show("Student email must end with @students.nsbm.ac.lk",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic field validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse age safely
            int? age = null;
            if (!string.IsNullOrWhiteSpace(txtAge.Text))
            {
                if (int.TryParse(txtAge.Text.Trim(), out int parsedAge))
                    age = parsedAge;
                else
                {
                    MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                var user = new User
                {
                    Username = txtUsername.Text.Trim(),
                    FullName = txtName.Text.Trim(),
                    Email    = txtEmail.Text.Trim(),
                    IdNumber = txtIdNumber.Text.Trim(),
                    Role     = cmbAccountType.SelectedItem?.ToString() ?? "Student",
                    Age      = age,
                    Gender   = cmbGender.SelectedItem?.ToString(),
                    Phone    = txtPhone.Text.Trim()
                };

                _userRepository.RegisterUser(user, txtPassword.Text);

                MessageBox.Show(
                    $"Account for '{user.FullName}' registered successfully!\nYou can now log in.",
                    "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Go back to login
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show(valEx.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void LinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

