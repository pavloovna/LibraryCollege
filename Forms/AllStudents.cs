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
    enum RowStateStudent
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class AllStudents : Form
    {
        private SqlConnection sqlConnection = null;
        int selectedRow;
        public AllStudents()
        {
            InitializeComponent();
        }
        private void CreatedColumns()
        {
            dataGridViewStudents.Columns.Add("IdStudent", "Код студента");
            dataGridViewStudents.Columns.Add("Group", "Группа");
            dataGridViewStudents.Columns.Add("Surname", "Фамилия");
            dataGridViewStudents.Columns.Add("Name", "Имя");
            dataGridViewStudents.Columns.Add("Patronymic", "Отчество");
            dataGridViewStudents.Columns.Add("Phone", "Телефон");
            dataGridViewStudents.Columns.Add("Empty", String.Empty);
            DataGridViewColumn column0 = dataGridViewStudents.Columns[0];
            column0.Width = 100;
            DataGridViewColumn column1 = dataGridViewStudents.Columns[1];
            column1.Width = 100;
            DataGridViewColumn column2 = dataGridViewStudents.Columns[2];
            column2.Width = 300;
            DataGridViewColumn column3 = dataGridViewStudents.Columns[3];
            column3.Width = 200;
            DataGridViewColumn column4 = dataGridViewStudents.Columns[4];
            column4.Width = 200;
            DataGridViewColumn column5 = dataGridViewStudents.Columns[5];
            column5.Width = 180;
        }
        private void ReadSingleRows(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowStateStudent.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string queryString = $"SELECT * FROM ReaderTable";
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dataGrid, reader);
            }
            reader.Close();
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_LibraryCollegeDataSet.ReaderTable". При необходимости она может быть перемещена или удалена.
            this.readerTableTableAdapter.Fill(this.dB_LibraryCollegeDataSet.ReaderTable);
            CreatedColumns();
            RefreshDataGrid(dataGridViewStudents);

            dataGridViewStudents.Columns[6].Visible = false;
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStudents.Rows[selectedRow];
                txtIdStudent.Text = row.Cells[0].Value.ToString();
                txtGroup.Text = row.Cells[1].Value.ToString();
                txtSurname.Text = row.Cells[2].Value.ToString();
                txtName.Text = row.Cells[3].Value.ToString();
                txtPatronymic.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewStudents);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents();
            addStudents.Show();
        }

        private void DeleteRow()
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) { 
            int index = dataGridViewStudents.CurrentCell.RowIndex;
            dataGridViewStudents.Rows[index].Visible = false;
            if (dataGridViewStudents.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewStudents.Rows[index].Cells[6].Value = RowStateStudent.Deleted;
                return;
            }
            dataGridViewStudents.Rows[index].Cells[6].Value = RowStateStudent.Deleted;
            }
        }

        private void Update()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            for (int index = 0; index < dataGridViewStudents.Rows.Count; index++)
            {
                var rowStateStudent = (RowStateStudent)dataGridViewStudents.Rows[index].Cells[6].Value;

                if (rowStateStudent == RowStateStudent.Existed)
                    continue;
                if (rowStateStudent == RowStateStudent.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewStudents.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM ReaderTable  WHERE IdStudent = '{id}'";
                    var command = new SqlCommand(deleteQuery, sqlConnection);
                    command.ExecuteNonQuery();
                }

                if (rowStateStudent == RowStateStudent.Modified)
                {
                    var idStudent = dataGridViewStudents.Rows[index].Cells[0].Value.ToString();
                    var group = dataGridViewStudents.Rows[index].Cells[1].Value.ToString();
                    var surname = dataGridViewStudents.Rows[index].Cells[2].Value.ToString();
                    var name = dataGridViewStudents.Rows[index].Cells[3].Value.ToString();
                    var patronymic = dataGridViewStudents.Rows[index].Cells[4].Value.ToString();
                    var phone = dataGridViewStudents.Rows[index].Cells[5].Value.ToString();
                    var changeQuery = $"UPDATE ReaderTable SET ReaderTable.[Group] = N'{group}', Surname = N'{surname}', Name = N'{name}', Patronymic = N'{patronymic}', Phone = N'{phone}' " +
                        $"WHERE IdStudent ='{idStudent}'";
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
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewStudents.CurrentCell.RowIndex;
            var idStudent = txtIdStudent.Text;
            var group = txtGroup.Text;
            var surname = txtSurname.Text;
            var name = txtName.Text;
            var patronymic = txtPatronymic.Text;
            var phone = txtPhone.Text;

            if (dataGridViewStudents.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridViewStudents.Rows[selectedRow].SetValues(idStudent, group, surname, name, patronymic, phone);
                dataGridViewStudents.Rows[selectedRow].Cells[6].Value = RowStateStudent.Modified;
            }

            txtIdStudent.Text = "";
            txtGroup.Text = "";
            txtSurname.Text = "";
            txtName.Text = "";
            txtPatronymic.Text = "";
            txtPhone.Text = "";
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
            string searchString = $"SELECT * FROM ReaderTable WHERE CONCAT (IdStudent, ReaderTable.[Group], Surname, Name, Patronymic, Phone) LIKE N'%" + txtSearch.Text + "%'";
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
            Search(dataGridViewStudents);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewStudents);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (rbtIdStudent.Checked)
            {
                dataGridViewStudents.Sort(dataGridViewStudents.Columns[0], ListSortDirection.Ascending);
            }
            else if (rbtGroup.Checked)
            {
                dataGridViewStudents.Sort(dataGridViewStudents.Columns[1], ListSortDirection.Ascending);
            }
            else if (rbtSurname.Checked)
            {
                dataGridViewStudents.Sort(dataGridViewStudents.Columns[2], ListSortDirection.Ascending);
            }
            else if (rbtName.Checked)
            {
                dataGridViewStudents.Sort(dataGridViewStudents.Columns[3], ListSortDirection.Ascending);
            }
            else if (rbtPatronymic.Checked)
            {
                dataGridViewStudents.Sort(dataGridViewStudents.Columns[4], ListSortDirection.Ascending);
            }
            else if (rbtPhone.Checked)
            {
                dataGridViewStudents.Sort(dataGridViewStudents.Columns[5], ListSortDirection.Ascending);
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLibrarian mainLibrarian = new MainLibrarian();
            this.Hide();
            mainLibrarian.ShowDialog();
            this.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            this.Hide();
            books.ShowDialog();
            this.Show();
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            this.Hide();
            journal.ShowDialog();
            this.Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программный продукт создан студентом: Коршикова Эльвина, группа: ИП-20-3", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Filter(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LibraryCollege"].ConnectionString);
            sqlConnection.Open();
            string surname = cmbCriteria.Text;
            string flterString = $"SELECT * FROM ReaderTable WHERE Surname = N'{surname}'";
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
            Filter(dataGridViewStudents);
        }
    }
}
