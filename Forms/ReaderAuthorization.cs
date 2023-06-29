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
    public partial class ReaderAuthorization : Form
    {
        private SqlConnection sqlConnection = null;
        public ReaderAuthorization()
        {
            InitializeComponent();
        }


        private void ReaderAuthorization_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            txtLogin.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            var loginReader = txtLogin.Text;
            var passwordReader = txtPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT IdReader, LoginReader, PasswordReader FROM ReaderAuthorizationTable WHERE LoginReader = '{loginReader}' AND PasswordReader = '{passwordReader}'";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainReader mainReader = new MainReader();
                this.Hide();
                mainReader.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Внимание!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            sqlConnection.Close();
        }

        private void linkLabelReader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationReader registrationReader = new RegistrationReader();
            this.Hide();
            registrationReader.ShowDialog();
            this.Show();
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
