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
    public partial class EditMemberForm : Form
    {
        private int memberId;
        public EditMemberForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            LoadMemberData(memberId);
        }
        private void LoadMemberData(int memberId)
        {
            string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Members WHERE member_id = @MemberId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberId", memberId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lastNameTextBox.Text = reader["last_name"].ToString();
                    firstNameTextBox.Text = reader["first_name"].ToString();
                    ageTextBox.Text = reader["age"].ToString();
                    rankTextBox.Text = reader["rank"].ToString();
                    rankValueTextBox.Text = reader["rank_value"].ToString();
                    senseiTextBox.Text = reader["sensei"].ToString();
                    dojoTextBox.Text = reader["dojo"].ToString();
                }
                reader.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);
            string rank = rankTextBox.Text;
            int rankValue = Convert.ToInt32(rankValueTextBox.Text);
            string sensei = senseiTextBox.Text;
            string dojo = dojoTextBox.Text;

            UpdateMember(memberId, lastName, firstName, age, rank, rankValue, sensei, dojo);

            this.Close();
        }

        private void UpdateMember(int memberId, string lastName, string firstName, int age, string rank, int rankValue, string sensei, string dojo)
        {
            string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Members " +
                               "SET last_name = @LastName, first_name = @FirstName, age = @Age, rank = @Rank, " +
                               "rank_value = @RankValue, sensei = @Sensei, dojo = @Dojo " +
                               "WHERE member_id = @MemberId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Rank", rank);
                command.Parameters.AddWithValue("@RankValue", rankValue);
                command.Parameters.AddWithValue("@Sensei", sensei);
                command.Parameters.AddWithValue("@Dojo", dojo);
                command.Parameters.AddWithValue("@MemberId", memberId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}