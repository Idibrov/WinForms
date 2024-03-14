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
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);
            string rank = rankTextBox.Text;
            int rankValue = Convert.ToInt32(rankValueTextBox.Text);
            string sensei = senseiTextBox.Text;
            string dojo = dojoTextBox.Text;

            AddMemberToDatabase(lastName, firstName, age, rank, rankValue, sensei, dojo);

            this.Close();
        }

        private void AddMemberToDatabase(string lastName, string firstName, int age, string rank, int rankValue, string sensei, string dojo)
        {
            string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Members (last_name, first_name, age, rank, rank_value, sensei, dojo) " +
                               "VALUES (@LastName, @FirstName, @Age, @Rank, @RankValue, @Sensei, @Dojo)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Rank", rank);
                command.Parameters.AddWithValue("@RankValue", rankValue);
                command.Parameters.AddWithValue("@Sensei", sensei);
                command.Parameters.AddWithValue("@Dojo", dojo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
