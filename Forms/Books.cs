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
    //состояние строки
    enum RowStateBook
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Books : Form
    {
        private SqlConnection sqlConnection = null;
        int selectedRow;
        public Books()
        {
            InitializeComponent();
        }
        //создание столбцов
        private void CreatedColumns()
        {
            dataGridViewBook.Columns.Add("IdBook", "Код книги");
            dataGridViewBook.Columns.Add("Title", "Название");
            dataGridViewBook.Columns.Add("Author", "Автор");
            dataGridViewBook.Columns.Add("Direction", "Направление");
            dataGridViewBook.Columns.Add("Instance", "Кол-во экземпляров");
            dataGridViewBook.Columns.Add("Empty", String.Empty);
            DataGridViewColumn column0 = dataGridViewBook.Columns[0];
            column0.Width = 120;
            DataGridViewColumn column1 = dataGridViewBook.Columns[1];
            column1.Width = 350;
            DataGridViewColumn column2 = dataGridViewBook.Columns[2];
            column2.Width = 350;
            DataGridViewColumn column3 = dataGridViewBook.Columns[3];
            column3.Width = 250;
            DataGridViewColumn column4 = dataGridViewBook.Columns[4];
            column4.Width = 150;
        }
        //чтение строк
        private void ReadSingleRows(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowStateBook.ModifiedNew);
        }
        //обновление таблицы
        private void RefreshDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string queryString = $"SELECT * FROM BooksTable";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dataGrid, reader);
            }
            reader.Close();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.BooksTable". При необходимости она может быть перемещена или удалена.
            this.booksTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.BooksTable);
            CreatedColumns();
            RefreshDataGrid(dataGridViewBook);

            dataGridViewBook.Columns[5].Visible = false;
        }

        //выбор строки
        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBook.Rows[selectedRow];
                txtIdBook.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtAuthor.Text = row.Cells[2].Value.ToString();
                cmbDiraction.Text = row.Cells[3].Value.ToString();
                txtInstance.Text = row.Cells[4].Value.ToString();
            }
        }

        //обновление
        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewBook);
        }

        //кнопка добавления
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }
        //удаление строки
        private void DeleteRow()
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                int index = dataGridViewBook.CurrentCell.RowIndex;
                dataGridViewBook.Rows[index].Visible = false;
                if (dataGridViewBook.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridViewBook.Rows[index].Cells[5].Value = RowStateBook.Deleted;
                    return;
                }
                dataGridViewBook.Rows[index].Cells[5].Value = RowStateBook.Deleted;
            }
        }
        //обновление бд
        private void Update() 
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            for (int index = 0; index < dataGridViewBook.Rows.Count; index++)
            {
                var rowStateBook = (RowStateBook)dataGridViewBook.Rows[index].Cells[5].Value;

                if (rowStateBook == RowStateBook.Existed)
                    continue;

                if (rowStateBook == RowStateBook.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewBook.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM BooksTable WHERE IdBook = '{id}'";
                    var command = new SqlCommand(deleteQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }

                if (rowStateBook == RowStateBook.Modified)
                {
                    var idbook = dataGridViewBook.Rows[index].Cells[0].Value.ToString();
                    var title = dataGridViewBook.Rows[index].Cells[1].Value.ToString();
                    var author = dataGridViewBook.Rows[index].Cells[2].Value.ToString(); 
                    var direction = dataGridViewBook.Rows[index].Cells[3].Value;
                    var instance = dataGridViewBook.Rows[index].Cells[4].Value.ToString();
                    var changeQuery = $"UPDATE BooksTable SET Title = N'{title}', Author = N'{author}', Direction = N'{direction}', Instance = N'{instance}' WHERE IdBook ='{idbook}'";
                    var command = new SqlCommand(changeQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
        }

        //кнопка удаления
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        //кнопка сохранения
        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }
        //изменение в таблице
        private void Change()
        {
            var selectedRowIndex = dataGridViewBook.CurrentCell.RowIndex;

            var idbook = txtIdBook.Text;
            var title = txtTitle.Text;
            var author = txtAuthor.Text;
            var direction = cmbDiraction.Text;
            var instanse = txtInstance.Text;

            if (dataGridViewBook.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewBook.Rows[selectedRow].SetValues(idbook, title, author, direction, instanse);
                dataGridViewBook.Rows[selectedRow].Cells[5].Value = RowStateBook.Modified;
            }

            txtIdBook.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            cmbDiraction.Text = "";
            txtInstance.Text = "";
        }
        //кнопка редактирования
        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }
        //поиск
        private void Search(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string searchString = $"SELECT * FROM BooksTable WHERE CONCAT (IdBook, Title, Author, Direction, Instance) LIKE N'%" + txtSearch.Text + "%'";
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
            Search(dataGridViewBook);
        }

        //фильтр по критерию
        private void Filter(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string title = cmbCriteria.Text;
            string flterString = $"SELECT * FROM BooksTable WHERE Title = N'{title}'";
            SqlCommand comm = new SqlCommand(flterString, sqlConnection);
            SqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRows(dataGrid, read);
            }
            read.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter(dataGridViewBook);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewBook); 
        }

        private void listBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllStudents allStudents = new AllStudents();
            this.Hide();
            allStudents.ShowDialog(); 
            this.Show();
        }

        //сортировка
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (rbtIdBook.Checked)
            {
                dataGridViewBook.Sort(dataGridViewBook.Columns[0], ListSortDirection.Ascending);
            }
            else if (rbtTitle.Checked)
            {
                dataGridViewBook.Sort(dataGridViewBook.Columns[1], ListSortDirection.Ascending);
            }
            else if (rbtAuthor.Checked)
            {
                dataGridViewBook.Sort(dataGridViewBook.Columns[2], ListSortDirection.Ascending);
            }
            else if (rbtDirection.Checked)
            {
                dataGridViewBook.Sort(dataGridViewBook.Columns[3], ListSortDirection.Ascending);
            }
            else if (rbtInstance.Checked)
            {
                dataGridViewBook.Sort(dataGridViewBook.Columns[4], ListSortDirection.Ascending);
            }
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            this.Hide();
            journal.ShowDialog();
            this.Show();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLibrarian mainLibrarian = new MainLibrarian();
            this.Hide();
            mainLibrarian.ShowDialog();
            this.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программный продукт создан студентом: Коршикова Эльвина, группа: ИП-20-3", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainLibrarian mainLibrarian = new MainLibrarian();
            this.Hide();
            mainLibrarian.ShowDialog();
            this.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программный продукт создан студентом: Коршикова Эльвина, группа: ИП-20-3", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbCriteria_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabelBooks.Text = "Выберите название книги для фильтрации";
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabelBooks.Text = "Введите текст для поиска";
        }

        private void rbtIdBook_MouseClick(object sender, MouseEventArgs e)
        {
            toolStripLabelBooks.Text = "После выбора пункта, нажмите Сортировать";
        }

        private void btnChange_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabelBooks.Text = "После редактирования, нажмите сохранить";
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabelBooks.Text = "После удаления, нажмите сохранить";
        }

        private void Refresh_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabelBooks.Text = "Нажмите, если хотите обновить";
        }

        private void Books_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabelBooks.Text = "";
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Программный продукт создан студентом: Коршикова Эльвина, группа: ИП-20-3", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMain_Click_1(object sender, EventArgs e)
        {
            MainReader mainReader = new MainReader();
            this.Hide();
            mainReader.ShowDialog();
            this.Show();
        }
    }
}
