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
    public partial class AddStudents : Form
    {
        private SqlConnection sqlConnection = null;
        public AddStudents()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();

            var group = txtGroup.Text;
            var surname = txtSurname.Text;
            var name = txtName.Text;
            var patronymic = txtPatronymic.Text;
            var phone = txtPhone.Text;

                var addQuery = $"INSERT INTO ReaderTable VALUES (N'{group}', N'{surname}', N'{name}', N'{patronymic}',N'{phone}')";
                SqlCommand command = new SqlCommand(addQuery, sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();
        }
    }
}
