using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class FeesForm : Form
    {
        public FeesForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter both Student ID and Amount.");
                return;
            }
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True";
            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(conString))
            {
                string query = "INSERT INTO Fees (StudentID, Amount, PaymentDate, Status) VALUES (@StudentID, @Amount, @PaymentDate, @Status)";
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentID", int.Parse(txtStudentID.Text));
                    cmd.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Fee record saved successfully!");
                }
            }
        }
    }
}
