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
    public partial class LibrarianAuthorization : Form
    {
        private SqlConnection sqlConnection = null;
        public LibrarianAuthorization()
        {
            InitializeComponent();
        }

        private void LibrarianAuthorization_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            txtLogin.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }

        private void txtEnter_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            var loginLibrarian = txtLogin.Text;
            var passwordLibratian = txtPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT IdLibrarian, LoginLibrarian, PasswordLibrarian FROM LibrarianAuthorizationTable WHERE LoginLibrarian = '{loginLibrarian}' AND PasswordLibrarian = '{passwordLibratian}'";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainLibrarian mainLibrarian = new MainLibrarian();
                this.Hide();
                mainLibrarian.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Внимание!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            sqlConnection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
