using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCollege.Forms
{
    public partial class MainLibrarian : Form
    {
        public MainLibrarian()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            AllStudents allStudents = new AllStudents();
            this.Hide();
            allStudents.ShowDialog();
            this.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.menuStrip2.Visible = false;
            this.Hide();
            books.ShowDialog();
            this.Show();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            this.Hide();
            journal.ShowDialog();
            this.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.menuStrip2.Visible = false;
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
    }
}
