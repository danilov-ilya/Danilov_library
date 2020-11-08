using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danilov_library
{
    public partial class searchBooks : Form
    {
        public int pBookID { get; set; }
        public string pIsbn{ get; set; }
        public string pAuthor { get; set; }
        public string pTitle { get; set; }
        public string pYear { get; set; }
        public int pBooksAmount { get; set; }
        public searchBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet books = new DataSet();
            string booksSQL = "select isbn, author \"Автор\", title \"Название\", DATEPART(YEAR,publish_year) \"Год издания\", b.ID, ba.amount " +
                "from books b " +
                "inner join books_available ba on b.ID = ba.book_id " +
                "where 1 = 1 " +
                (tb_author.Text.Trim() != "" ? " and UPPER(b.author) LIKE '%" + tb_author.Text.Trim().ToUpper() + "%'" : "") + " " +
                (tb_title.Text.Trim() != "" ? " and UPPER(b.title) LIKE '%" + tb_title.Text.Trim().ToUpper() + "%'" : "") + " " +
                (tb_year.Text.Trim() != "" ? " and DATEPART(YEAR,b.publish_year) = " + tb_year.Text.Trim()+ "" : "") + " " +
                "order by author, title, publish_year desc";
            OleDbDataAdapter ad1 = new OleDbDataAdapter
                (booksSQL, Properties.Settings.Default.MainConnectionString);
            ad1.Fill(books);
            dgv_books.DataSource = books.Tables[0];
            dgv_books.Columns["ID"].Visible = false;
            dgv_books.Columns["amount"].Visible = false;
            dgv_books.Refresh();
        }

        private void dgv_books_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvtmp = (DataGridView)(sender);
            pAuthor = dgvtmp.SelectedRows[0].Cells["Автор"].Value.ToString();
            pTitle = dgvtmp.SelectedRows[0].Cells["Название"].Value.ToString();
            pYear = dgvtmp.SelectedRows[0].Cells["Год издания"].Value.ToString();
            pIsbn = dgvtmp.SelectedRows[0].Cells["isbn"].Value.ToString();
            pBookID = int.Parse(dgvtmp.SelectedRows[0].Cells["ID"].Value.ToString());
            pBooksAmount = int.Parse(dgvtmp.SelectedRows[0].Cells["amount"].Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void searchBooks_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
