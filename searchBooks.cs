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
            string booksSQL = "select isbn, author , title , DATEPART(YEAR,publish_year) publish_year, b.ID, ba.amount, author + ' \n ' + title + ' \n ' + CAST(publish_year as varchar) as full_data, book_image " +
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
            dgv_books.Columns["isbn"].Visible = false;
            dgv_books.Columns["author"].Visible = false;
            dgv_books.Columns["publish_year"].Visible = false;
            dgv_books.Columns["title"].Visible = false;
            dgv_books.Columns["book_image"].Visible = false;
            dgv_books.Columns["full_data"].HeaderText = "Данные книги";
            dgv_books.Columns.Insert(0,new DataGridViewImageColumn() { Name = "image", HeaderText = "Обложка", Width = 50, ImageLayout = DataGridViewImageCellLayout.Zoom });
            
            foreach (DataGridViewRow rw in dgv_books.Rows)
            {
                if (rw.Cells["book_image"].Value.ToString() == string.Empty)
                {
                    rw.Cells["image"].Value = Image.FromFile(@"C:\Users\jakob\source\repos\Danilov_library3\img\no_image.png");
                }
            }
        }

        private void dgv_books_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvtmp = (DataGridView)(sender);
            pAuthor = dgvtmp.SelectedRows[0].Cells["author"].Value.ToString();
            pTitle = dgvtmp.SelectedRows[0].Cells["title"].Value.ToString();
            pYear = dgvtmp.SelectedRows[0].Cells["publish_year"].Value.ToString();
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
