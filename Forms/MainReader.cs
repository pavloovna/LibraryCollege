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
    public partial class MainReader : Form
    {
        public MainReader()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.groupBox1.Visible = false;
            books.menuStrip1.Visible = false;
            this.Hide();
            books.ShowDialog();
            this.Show();
        }
    }
}
