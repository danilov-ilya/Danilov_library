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
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.MainConnectionString);
            OleDbCommand com = new OleDbCommand("", conn);
            com.CommandText = "select can_edit_students*8+can_edit_books*4+can_give_books*2+can_take_books*1 mask " +
                "from library_users lu " +
                "inner join roles r on lu.role_id = r.role_name " +
                "where log_in = '" + tb_login.Text.Trim() +"' " +
                "and passwrd = '"+tb_password.Text.Trim() +"' ";
            conn.Open();
            object res = com.ExecuteScalar();
            if (res == null)
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
            else
            {
                byte mask = byte.Parse(res.ToString());
                FormMain fm = new FormMain(mask);
                fm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            if (tb_login.Text.Trim() != string.Empty && tb_password.Text.Trim() != string.Empty)
                bt_enter.Enabled = true;
            else bt_enter.Enabled = false;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_login.Text.Trim() != string.Empty && tb_password.Text.Trim() != string.Empty)
                bt_enter.Enabled = true;
            else bt_enter.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
