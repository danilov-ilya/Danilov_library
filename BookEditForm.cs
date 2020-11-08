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
    public partial class BookEditForm : Form
    {
        int bookId;
        bool isEdit;
        public BookEditForm()
        {
            InitializeComponent();
            bookId = -1;
            isEdit = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchBooks sb = new searchBooks();
            if (sb.ShowDialog() == DialogResult.OK)
            {
                isEdit = true;
                btAddorEdit.Text = "Редактировать";

                tbAuthor.Text = sb.pAuthor;
                tbTitle.Text = sb.pTitle;
                tbYear.Text = sb.pYear;
                tbIsbn.Text = sb.pIsbn;
                bookId = sb.pBookID;
            }
            else
            {
                isEdit = false;
                btAddorEdit.Text = "Добавить";

                tbAuthor.Text = "";
                tbTitle.Text = "";
                tbYear.Text = "";
                tbIsbn.Text = "";
            }
        }

        private void btAddorEdit_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.MainConnectionString);
            OleDbCommand com = new OleDbCommand("", conn);
            conn.Open();
            if (!isEdit)
            {
                com.CommandText = "insert into books(isbn, author,title,publish_year) values(" +
                    "'"+tbIsbn.Text+"','"+tbAuthor.Text+"','"+tbTitle.Text+ "',DATEFROMPARTS("+tbYear.Text+",1,1));";

            }
            else
            {
                com.CommandText = "update books set " +
                    "isbn = '"+tbIsbn.Text+"', " +
                    "title='"+tbTitle.Text+"', " +
                    "author='"+tbAuthor.Text+"', " +
                    "publish_year = DATEFROMPARTS("+tbYear.Text+",1,1) " +
                    "where ID = " + bookId;
            }
            int rowsAffected = com.ExecuteNonQuery();
            MessageBox.Show("Успешно сохранено. Строк задействовано: " + rowsAffected.ToString());

        }
    }
}
