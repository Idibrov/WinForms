using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);
            string dojo = gradeTextBox.Text;
            

            AddStudentToDatabase(lastName, firstName, age, dojo);

            this.Close();
        }

        private void AddStudentToDatabase(string lastName, string firstName, int age, string dojo)
        {
            string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (last_name, first_name, age, dojo) " +
                               "VALUES (@LastName, @FirstName, @Age, @Dojo)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Dojo", dojo);
                

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}