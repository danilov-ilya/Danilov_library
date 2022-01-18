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
    public partial class FormMain : Form
    {
        byte mask;
        public FormMain(byte accessMask)
        {
            InitializeComponent();
            mask = accessMask;
            if ((accessMask & 0001) == 0) //не может принимать книги
            {
                bt_bookOper.Enabled = false;
            }

            bt_bookEdit.Enabled = ((accessMask & 0100) != 0);
            bt_readerEdit.Enabled = ((accessMask & 1000) != 0);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet3.overdueBooks". При необходимости она может быть перемещена или удалена.
            this.overdueBooksTableAdapter.Fill(this.dataSet3.overdueBooks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet3.todayBooks". При необходимости она может быть перемещена или удалена.
            this.todayBooksTableAdapter1.Fill(this.dataSet3.todayBooks);
            /*DataSet todayReturns = new DataSet();
            string todayReturnsSQL = "select b.title, st.first_name + ' ' + st.middle_name + ' ' + st.last_name as FIO, bt.return_date " +
                "from books_taken bt " +
                "inner join books b on b.ID = bt.book_id " +
                "inner join students st on bt.student_id = st.lib_card_number " +
                "where return_date = '20200711' ";
            OleDbDataAdapter ad1 = new OleDbDataAdapter
                (todayReturnsSQL, Properties.Settings.Default.MainConnectionString);
            ad1.Fill(todayReturns);
            dgv_todayReturns.DataSource = todayReturns.Tables[0];*/
        }

        private void bt_readerEdit_Click(object sender, EventArgs e)
        {
            ReadersEditForm rf = new ReadersEditForm();
            rf.Show();
        }

        private void bt_bookEdit_Click(object sender, EventArgs e)
        {
            BookEditForm bf = new BookEditForm();
            bf.Show();
        }

        private void bt_bookOper_Click(object sender, EventArgs e)
        {
            BookGivaTakeForm bf = new BookGivaTakeForm(mask);
            bf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservCode rf = new ReservCode();
            rf.Show();

        }

        private void Dgv_overdue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_overdue_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
