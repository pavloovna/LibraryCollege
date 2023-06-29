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
    public partial class AddBooks : Form
    {
        private SqlConnection sqlConnection = null;
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();

            var title = txtTitle.Text;
            var author = txtAuthor.Text;
            var direction = cmbDirection.Text;
            int instance;

            if (int.TryParse(txtInstance.Text, out instance))
            {
                var addQuery = $"INSERT INTO BooksTable (Title, Author, Direction, Instance) " +
                    $"VALUES (N'{title}', N'{author}', N'{direction}', N'{instance}')";
                SqlCommand command = new SqlCommand(addQuery, sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не удалось создать! Будьте внимательны при заполнении полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlConnection.Close();
        }
    }
}
