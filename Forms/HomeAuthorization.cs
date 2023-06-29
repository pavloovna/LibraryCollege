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
using LibraryCollege.Forms;

namespace LibraryCollege
{
    public partial class HomeAuthorization : Form
    {
        private SqlConnection sqlConnection = null;
        public HomeAuthorization()
        {
            InitializeComponent();
        }
        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            LibrarianAuthorization librarianAuthorization = new LibrarianAuthorization();
            librarianAuthorization.Show();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            ReaderAuthorization readerAuthorization = new ReaderAuthorization();
            readerAuthorization.Show();
        }
    }
}
