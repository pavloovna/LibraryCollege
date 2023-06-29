using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryCollege.Forms
{
    //состояние строки
    enum RowStateJournal
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Journal : Form
    {
        private SqlConnection sqlConnection = null;
        int selectedRow;
        public Journal()
        {
            InitializeComponent();
        }
        //создание столбцов
        private void CreatedColumns()
        {
            dataGridViewJournal.Columns.Add("IdTaking", "Код записи");
            dataGridViewJournal.Columns.Add("IdStudents", "Код студента");
            dataGridViewJournal.Columns.Add("IdBooks", "Код книги");
            dataGridViewJournal.Columns.Add("NumInstances", "Кол-во взятых экзмепляров");
            dataGridViewJournal.Columns.Add("WhereRead", "Абонемент/чит зал");
            dataGridViewJournal.Columns.Add("DateBegin", "Дата выдачи");
            dataGridViewJournal.Columns.Add("DateEnd", "Дата возврата");
            dataGridViewJournal.Columns.Add("Passed", "Сдано/не сдано");
            dataGridViewJournal.Columns.Add("Empty", String.Empty);
            DataGridViewColumn column0 = dataGridViewJournal.Columns[0];
            column0.Width = 100;
            DataGridViewColumn column1 = dataGridViewJournal.Columns[1];
            column1.Width = 100;
            DataGridViewColumn column2 = dataGridViewJournal.Columns[2];
            column2.Width = 100;
            DataGridViewColumn column3 = dataGridViewJournal.Columns[3];
            column3.Width = 150;
            DataGridViewColumn column4 = dataGridViewJournal.Columns[4];
            column4.Width = 200;
            DataGridViewColumn column5 = dataGridViewJournal.Columns[5];
            column5.Width = 180;
            DataGridViewColumn column6 = dataGridViewJournal.Columns[6];
            column6.Width = 180;
            DataGridViewColumn column7 = dataGridViewJournal.Columns[7];
            column7.Width = 200;
        }
        private void ReadSingleRows(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), RowStateJournal.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string queryString = $"SELECT * FROM UseTable";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dataGrid, reader);
            }
            reader.Close();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.BooksTable". При необходимости она может быть перемещена или удалена.
            this.booksTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.BooksTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.ReaderTable". При необходимости она может быть перемещена или удалена.
            this.readerTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.ReaderTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.UseTable". При необходимости она может быть перемещена или удалена.
            this.useTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.UseTable);
            CreatedColumns();
            RefreshDataGrid(dataGridViewJournal);
            dataGridViewJournal.Columns[8].Visible = false;
        }

        private void dataGridViewJournal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewJournal.Rows[selectedRow];
                txtIdTaking.Text = row.Cells[0].Value.ToString();
                cmbIdStudents.Text = row.Cells[1].Value.ToString();
                cmbIdBooks.Text = row.Cells[2].Value.ToString();
                txtNumInstances.Text = row.Cells[3].Value.ToString();
                cmbWhereRead.Text = row.Cells[4].Value.ToString();
                txtDateBegin.Text = row.Cells[5].Value.ToString();
                txtDateEnd.Text = row.Cells[6].Value.ToString();
                cmbPassed.Text = row.Cells[7].Value.ToString();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewJournal);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddJournal addJournal = new AddJournal();
            addJournal.Show();
        }
        private void DeleteRow()
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                int index = dataGridViewJournal.CurrentCell.RowIndex;
                dataGridViewJournal.Rows[index].Visible = false;
                if (dataGridViewJournal.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridViewJournal.Rows[index].Cells[8].Value = RowStateJournal.Deleted;
                    return;
                }
                dataGridViewJournal.Rows[index].Cells[8].Value = RowStateJournal.Deleted;
            }
        }
        private void Update()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            for (int index = 0; index < dataGridViewJournal.Rows.Count; index++)
            {
                var rowStateJournal = (RowStateJournal)dataGridViewJournal.Rows[index].Cells[8].Value;

                if (rowStateJournal == RowStateJournal.Existed)
                    continue;
                if (rowStateJournal == RowStateJournal.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewJournal.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM UseTable WHERE IdTaking = '{id}'";
                    var command = new SqlCommand(deleteQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }

                if (rowStateJournal == RowStateJournal.Modified)
                {
                    var idTaking = dataGridViewJournal.Rows[index].Cells[0].Value.ToString();
                    var idStudents = dataGridViewJournal.Rows[index].Cells[1].Value;
                    var idBooks = dataGridViewJournal.Rows[index].Cells[2].Value;
                    var numInstances = dataGridViewJournal.Rows[index].Cells[3].Value.ToString();
                    var whereRead = dataGridViewJournal.Rows[index].Cells[4].Value;
                    var dateBegin = dataGridViewJournal.Rows[index].Cells[5].Value.ToString();
                    var dateEnd = dataGridViewJournal.Rows[index].Cells[6].Value.ToString();
                    var passed = dataGridViewJournal.Rows[index].Cells[7].Value;
                    var changeQuery = $"UPDATE UseTable SET IdStudents = '{idStudents}', IdBooks = '{idBooks}', NumInstances = '{numInstances}', WhereRead = '{whereRead}', DateBegin = '{dateBegin}', DateEnd = '{dateEnd}', Passed = '{passed}' " +
                        $"WHERE IdTaking ='{idTaking}'";
                    var command = new SqlCommand(changeQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }
            }
            
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
          /*  sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            var queryString = $"SELECT DISTINCT Passed FROM UseTable";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                cmbCriteria.Items.Add(read[0]);
            }
            sqlConnection.Close();*/
        }
        private void Change()
        {
            var selectedRowIndex = dataGridViewJournal.CurrentCell.RowIndex;
            var idTaking = txtIdTaking.Text;
            var idStudents = cmbIdStudents.SelectedValue;
            var idBooks = cmbIdBooks.SelectedValue;
            var numInstances = txtNumInstances.Text;
            var whereRead = cmbWhereRead.SelectedValue;
            var dateBegin = txtDateBegin.Text;
            var dateEnd = txtDateEnd.Text;
            var passed = cmbPassed.SelectedValue;

            if (dataGridViewJournal.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewJournal.Rows[selectedRow].SetValues(idTaking, idStudents, idBooks, numInstances, whereRead, dateBegin, dateEnd, passed);
                dataGridViewJournal.Rows[selectedRow].Cells[8].Value = RowStateJournal.Modified;
            }

            txtIdTaking.Text = "";
            cmbIdStudents.Text = "";
            cmbIdBooks.Text = "";
            txtNumInstances.Text = "";
            cmbWhereRead.Text = "";
            txtDateBegin.Text = "";
            txtDateEnd.Text = "";
            cmbPassed.Text = "";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }
        private void Search(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string searchString = $"SELECT * FROM UseTable WHERE CONCAT (IdTaking, IdStudents, IdBooks, NumInstances, WhereRead, DateBegin, DateEnd, Passed) LIKE N'%" + txtSearch.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, sqlConnection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRows(dataGrid, read);
            }
            read.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewJournal);
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            journal.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            this.Hide();
            books.ShowDialog();
            this.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (rbtIdTaking.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[0], ListSortDirection.Ascending);
            }
            else if (rbtIdStudent.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[1], ListSortDirection.Ascending);
            }
            else if (rbtBook.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[2], ListSortDirection.Ascending);
            }
            else if (rbtNum.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[3], ListSortDirection.Ascending);
            }
            else if (rbtWhere.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[4], ListSortDirection.Ascending);
            }
            else if (rbtDateBegin.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[5], ListSortDirection.Ascending);
            }
            else if (rbtDataEnd.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[6], ListSortDirection.Ascending);
            }
            else if (rbtPassed.Checked)
            {
                dataGridViewJournal.Sort(dataGridViewJournal.Columns[7], ListSortDirection.Ascending);
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLibrarian mainLibrarian = new MainLibrarian();
            this.Hide();
            mainLibrarian.ShowDialog();
            this.Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllStudents allStudents = new AllStudents();
            this.Hide();
            allStudents.ShowDialog();
            this.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программный продукт создан студентом: Коршикова Эльвина, группа: ИП-20-3", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 40;
            xlSheet = (Excel.Worksheet)wBook.Sheets[1];
            xlSheet.Name = "Журнал записей";
            xlApp.Cells[1, 1] = "Код записи";
            xlApp.Cells[1, 2] = "Код студента";
            xlApp.Cells[1, 3] = "Код книги";
            xlApp.Cells[1, 4] = "Кол-во взятых экзмепляров";
            xlApp.Cells[1, 5] = "Абонемент/чит зал";
            xlApp.Cells[1, 6] = "Дата выдачи";
            xlApp.Cells[1, 7] = "Дата возврата";
            xlApp.Cells[1, 8] = "Сдано/не сдано";

            for (int i = 0; i < dataGridViewJournal.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewJournal.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dataGridViewJournal.Rows[i].Cells[j].Value.ToString();
                    xlSheet.Cells.HorizontalAlignment = 3;
                    xlApp.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter(dataGridViewJournal);
        }

        private void Filter(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string passed = cmbCriteria.Text;
            string flterString = $"SELECT * FROM UseTable WHERE Passed = N'{passed}'";
            SqlCommand comm = new SqlCommand(flterString, sqlConnection);
            SqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRows(dataGrid, read);
            }
            read.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewJournal);
        }

        private void cmbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
