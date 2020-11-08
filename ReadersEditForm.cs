using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danilov_library
{
    public partial class ReadersEditForm : Form
    {
        bool isEdit;
        string readersId, firstName, middleName, lastName, groupName, studID;
        DateTime birthdate;

        private void btAddorEdit_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.MainConnectionString);
            OleDbCommand com = new OleDbCommand("",conn);
            int groupID=-1;
            Random ran = new Random();
            com.CommandText = "select ID from groups where UPPER(group_name)='" + tbGroupName.Text.Trim().ToUpper() + "'";
            conn.Open();
            object ob = com.ExecuteScalar();
            if (ob != null)
            {
                groupID = int.Parse(ob.ToString());
                if (!isEdit)
                {
                    com.CommandText = "insert into students(stud_card_number, lib_card_number,first_name,middle_name,last_name,birth_date,group_id) values( '" +
                         ran.Next(10,9999).ToString().PadLeft(4,'0') + "','" + tb_readersId.Text + "','" + tbFirstName.Text + "','" + tbMiddleName.Text + "','" + tbLastName.Text + "','" +
                         DateTime.Parse(tbBirthDate.Text) + "'," + groupID + " " +
                        ")";
                    
                }
                else
                {
                    com.CommandText = "update students set " +
                        "lib_card_number = '"+tb_readersId.Text+"', " +
                        "first_name='"+tbFirstName.Text+"', " +
                        "middle_name='"+tbMiddleName.Text+"', " +
                        "last_name='"+tbLastName.Text+"', " +
                        "birth_date='"+DateTime.Parse(tbBirthDate.Text)+"', " +
                        "group_id="+groupID +" " +
                        "where stud_card_number = '"+studID+"'";
                }
                int rowsAffected = com.ExecuteNonQuery();
                MessageBox.Show("Успешно сохранено. Строк задействовано: " + rowsAffected.ToString());
            }
            else
            {
                MessageBox.Show("Указанная группа не найдена. Проверьте имя группы", "Ошибка", MessageBoxButtons.OK);
            }
            
        }

        public ReadersEditForm()
        {
            InitializeComponent();
            isEdit = false;
            readersId = firstName = middleName = lastName = groupName = studID = string.Empty;
            birthdate = DateTime.MinValue;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadersEditForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchReader sr = new SearchReader();
            if (sr.ShowDialog() == DialogResult.OK)
            {
                isEdit = true;
                readersId = sr.pReadersId;
                studID = sr.pStudID;
                firstName = sr.pFirstName;
                middleName = sr.pMiddleName;
                lastName = sr.pLastName;
                groupName = sr.pGroupName;
                birthdate = sr.pBirthDate;
                btAddorEdit.Text = "Редактировать";

                tbBirthDate.Text = birthdate.ToString("dd.MM.yyyy");
                tbFirstName.Text = firstName;
                tbMiddleName.Text = middleName;
                tbLastName.Text = lastName;
                tb_readersId.Text = readersId;
                tbGroupName.Text = groupName;
            }
            else
            {
                isEdit = false;
                btAddorEdit.Text = "Добавить";
                tbBirthDate.Text = "";
                tbFirstName.Text = "";
                tbMiddleName.Text = "";
                tbLastName.Text = "";
                tb_readersId.Text = "";
                tbGroupName.Text = "";
            }
        }
    }
}
