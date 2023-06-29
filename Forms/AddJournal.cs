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
    public partial class AddJournal : Form
    {
        private SqlConnection sqlConnection = null;
        public AddJournal()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();

            var idStudents = cmbIdStudents.Text;
            var idBooks = cmbIdBooks.Text;
            int numInstances;
            var whereRead = cmbWhereRead.Text;
            var dateBegin = txtDateBegin.Text;
            var dateEnd = txtDateEnd.Text;
            var passed = cmbPassed.Text;

            if (int.TryParse(txtNumInstances.Text, out numInstances))
            {
                var addQuery = $"INSERT INTO UseTable VALUES (N'{idStudents}', N'{idBooks}', N'{numInstances}', N'{whereRead}', N'{dateBegin}', N'{dateEnd}', N'{passed}')";
                SqlCommand command = new SqlCommand(addQuery, sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не удалось создать! Две последние записи должны иметь числовой формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlConnection.Close();
        }

        private void AddJournal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.ReaderTable". При необходимости она может быть перемещена или удалена.
            this.readerTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.ReaderTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.BooksTable". При необходимости она может быть перемещена или удалена.
            this.booksTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.BooksTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.ReaderTable". При необходимости она может быть перемещена или удалена.
          //  this.readerTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.ReaderTable);

        }
    }
}
