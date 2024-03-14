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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=DESKTOP-9AGJHD1\\SERVER;Initial Catalog=Karate;Integrated Security=True;TrustServerCertificate=True";


        public Form1()
        {
            InitializeComponent();
        }
        private void LoadMembersData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable membersTable = new DataTable();
                adapter.Fill(membersTable);
                membersDataGridView.DataSource = membersTable;
            }
        }

        private void LoadStudentsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable studentsTable = new DataTable();
                adapter.Fill(studentsTable);
                studentsDataGridView.DataSource = studentsTable;
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.FormClosed += AddMemberForm_FormClosed;
            addMemberForm.ShowDialog();
        }

        private void AddMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadMembersData(); 
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.FormClosed += AddStudentForm_FormClosed;
            addStudentForm.ShowDialog();
        }

        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadStudentsData();
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(membersDataGridView.SelectedRows[0].Cells[0].Value);
                DeleteRecord("Members", memberId);
                LoadMembersData();
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells[0].Value);
                DeleteRecord("Students", studentId);
                LoadStudentsData();
            }
        }

        private void DeleteRecord(string tableName, int recordId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string idColumnName = tableName.ToLower().Contains("member") ? "member_id" : "student_id";
                string query = $"DELETE FROM {tableName} WHERE {idColumnName} = @RecordId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RecordId", recordId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count > 0)
            {
                int memberId = Convert.ToInt32(membersDataGridView.SelectedRows[0].Cells[0].Value);
                EditMemberForm editMemberForm = new EditMemberForm(memberId);
                editMemberForm.ShowDialog();
                LoadMembersData();
            }
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells[0].Value);
                EditStudentForm editStudentForm = new EditStudentForm(studentId);
                editStudentForm.ShowDialog();
                LoadStudentsData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "karateDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.karateDataSet1.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "karateDataSet.Members". При необходимости она может быть перемещена или удалена.
            this.membersTableAdapter.Fill(this.karateDataSet.Members);


        }
    }
}