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
    public partial class BookGivaTakeForm : Form
    {
        string studID;
        int bookId;
        public BookGivaTakeForm(byte accessMask)
        {
            InitializeComponent();
            bt_give.Enabled = ((accessMask & 0010) != 0);
            bt_take.Enabled = ((accessMask & 0001) != 0);
            studID = "";
            bookId = -1;
        }

        private void bt_studSearch_Click(object sender, EventArgs e)
        {
            SearchReader sr = new SearchReader();
            if (sr.ShowDialog() == DialogResult.OK)
            {
                tb_studFirstName.Text = sr.pFirstName;
                tb_studMiddleName.Text = sr.pMiddleName;
                tb_studLastName.Text = sr.pLastName;
                tb_studGroup.Text = sr.pGroupName;
                studID = sr.pStudID;
            }
        }

        private void bt_searchBook_Click(object sender, EventArgs e)
        {
            searchBooks sb = new searchBooks();
            if (sb.ShowDialog() == DialogResult.OK)
            {
                tb_bookAuthor.Text = sb.pAuthor;
                tbBookTitle.Text = sb.pTitle;
                tb_bookYear.Text = sb.pYear;
                bookId = sb.pBookID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookId == -1 || studID == "")
            {
                MessageBox.Show("Необходимо выбрать книгу и студента перед выдачей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show(string.Format("Студенту {0} {1} {2} группы {3} выдается книга {4} {5}. Информация верна?",
                    tb_studFirstName.Text, tb_studMiddleName.Text, tb_studLastName.Text, tb_studGroup.Text, tb_bookAuthor.Text, tbBookTitle.Text
                    ), "Необходимо подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.MainConnectionString);
                    OleDbCommand com = new OleDbCommand("", conn);
                    conn.Open();
                    com.CommandText = "select amount from books_available where book_id = " + bookId;
                    int bookQty = int.Parse(com.ExecuteScalar().ToString());
                    if (bookQty == 0)
                    {
                        MessageBox.Show("Нет доступных книг для выдачи");
                    }
                    else
                    {
                        com.CommandText = "insert into books_taken(book_id, student_id,return_date) " +
                            "values(" + bookId + ", '" + studID + "', '" + dt_returnDate.Value.ToString("yyyMMdd") + "')";
                        int res1 = com.ExecuteNonQuery();
                        com.CommandText = "update books_available set amount=amount-1 where book_id = " + bookId;
                        int res2 = com.ExecuteNonQuery();
                        if (res1 > 0 && res2 > 0)
                        {
                            MessageBox.Show("Книга выдана успешно");
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bookId == -1 || studID == "")
            {
                MessageBox.Show("Необходимо выбрать книгу и студента перед сдачей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.MainConnectionString);
                OleDbCommand com = new OleDbCommand("", conn);
                com.CommandText = "select count(0) from books_taken where is_returned=0 and book_id = " + bookId + " and student_id = '" + studID + "'";
                conn.Open();
                int res = int.Parse(com.ExecuteScalar().ToString());
                if (res == 0)
                {
                    MessageBox.Show("За данным студентом книга не числится.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int retId;
                    bool OKtoReturn = true;
                    com.CommandText = "select return_date, ID from books_taken where is_returned=0 and book_id = " + bookId + " and student_id = '" + studID + "' order by return_date asc";
                    OleDbDataReader rd = com.ExecuteReader();
                    rd.Read();
                    DateTime retDate = DateTime.Parse(rd["return_date"].ToString());
                    retId = int.Parse(rd["ID"].ToString());
                    rd.Close();
                    if (retDate < DateTime.Now.Date)
                    {
                        if (MessageBox.Show("Студент пропустил срок сдачи книги. Штраф оплачен?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            OKtoReturn = false;
                        }
                    }
                    if (OKtoReturn)
                    {
                        com.CommandText = "update books_taken set is_returned=1 where ID= " + retId;
                        int res1 = com.ExecuteNonQuery();

                        com.CommandText = "Update books_available set amount = amount +1 where book_id = " + bookId;
                        int res2 = com.ExecuteNonQuery();

                        if (res1 == 1 && res2 == 1)
                        {
                            MessageBox.Show("Книга возвращена");
                        }
                        else
                        {
                            MessageBox.Show("Возникла ошибка. Обратитесь к разработчику");
                        }
                    }
                }
            }
        }
    }
}
