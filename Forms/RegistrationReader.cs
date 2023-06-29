using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryCollege.Forms
{
    public partial class RegistrationReader : Form
    {
        private SqlConnection sqlConnection = null;
        public RegistrationReader()
        {
            InitializeComponent();
        }

        private void RegistrationReader_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();

            var loginReader = txtLogin.Text;
            var passwordReader = txtPassword.Text;

            string queryString = $"INSERT INTO ReaderAuthorizationTable (LoginReader, PasswordReader) VALUES ('{loginReader}', '{passwordReader}')";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReaderAuthorization reader = new ReaderAuthorization();
                this.Hide();
                reader.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка! Повторите попытку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlConnection.Close();
        }

        private Boolean checkReader()
        {
            var loginReader = txtLogin.Text;
            var passwordReader = txtPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"SELECT IdReader, LoginReader, PasswordReader FROM ReaderAuthorizationTable WHERE LoginReader = '{loginReader}' AND PasswordReader = '{passwordReader}'";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }
    }
}
