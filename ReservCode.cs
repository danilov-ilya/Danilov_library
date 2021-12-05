using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danilov_library
{
    public partial class ReservCode : Form
    {
        library_danilovEntities db;

        public ReservCode()
        {
            InitializeComponent();
            db = new library_danilovEntities();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ReservCode_Load(object sender, EventArgs e)
        {
            BookBindingSource.DataSource = db.books.ToList();
            ReaderBindingSource.DataSource = db.students.ToList();


        }

        private void librarydanilovEntitiesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void CB_Reader_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
