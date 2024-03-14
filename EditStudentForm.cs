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
    public partial class EditStudentForm : Form
    {
        private int studentId;
        public EditStudentForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentData(studentId);
        }

        private void LoadStudentData(int studentId)
        {
            string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students WHERE student_id = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lastNameTextBox.Text = reader["last_name"].ToString();
                    firstNameTextBox.Text = reader["first_name"].ToString();
                    ageTextBox.Text = reader["age"].ToString();
                    gradeTextBox.Text = reader["dojo"].ToString();
                }
                reader.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);
            string dojo = gradeTextBox.Text;
           

            UpdateStudent(studentId, lastName, firstName, age, dojo);

            this.Close();
        }

        private void UpdateStudent(int studentId, string lastName, string firstName, int age, string dojo)
        {
            string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Students " +
                               "SET last_name = @LastName, first_name = @FirstName, age = @Age, dojo = @Dojo WHERE student_id = @StudentId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Dojo", dojo);
                command.Parameters.AddWithValue("@StudentId", studentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}