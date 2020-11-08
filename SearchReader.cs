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
    public partial class SearchReader : Form
    {
        public string pFirstName { get; set; }
        public string pMiddleName { get; set; }
        public string pLastName { get; set; }
        public DateTime pBirthDate { get; set; }
        public string pGroupName { get; set; }
        public string pStudID { get; set; }
        public string pReadersId { get; set; }
        public SearchReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet todayReturns = new DataSet();
            string todayReturnsSQL = "select lib_card_number \"Чит билет\", stud_card_number \"Студ билет\", " +
                "first_name Фамилия, middle_name Имя, last_name Отчество, birth_date \"Дата рождения\", " +
                "gr.group_name Группа "+
                "from students st "+
                "left join groups gr on st.group_id = gr.id " +
                "where 1 = 1 "+
                (tb_firstname.Text.Trim() != "" ? " and UPPER(first_name) LIKE '%" + tb_firstname.Text.Trim().ToUpper()+"%'" : "") + " " +
                (tb_middlename.Text.Trim() != "" ? " and UPPER(middle_name) LIKE '%" + tb_middlename.Text.Trim().ToUpper() + "%'" : "") + " " +
                (tb_lastName.Text.Trim() != "" ? " and UPPER(last_name) LIKE '%" + tb_lastName.Text.Trim().ToUpper() + "%'" : "") + " " +
                (tb_group.Text.Trim() != "" ? " and UPPER(gr.group_name) LIKE '%" + tb_group.Text.Trim().ToUpper() + "%'" : "") + " " +
                "order by first_name, middle_name, last_name";
            OleDbDataAdapter ad1 = new OleDbDataAdapter
                (todayReturnsSQL, Properties.Settings.Default.MainConnectionString);
            ad1.Fill(todayReturns);
            dgv_studs.DataSource = todayReturns.Tables[0];
            dgv_studs.Refresh();

        }

        private void dgv_studs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime bdate = new DateTime();
            DataGridView dgvtmp = (DataGridView)(sender);
            pStudID = dgvtmp.SelectedRows[0].Cells["Студ билет"].Value.ToString();
            pReadersId = dgvtmp.SelectedRows[0].Cells["Чит билет"].Value.ToString();
            pFirstName = dgvtmp.SelectedRows[0].Cells["Фамилия"].Value.ToString();
            pMiddleName = dgvtmp.SelectedRows[0].Cells["Имя"].Value.ToString();
            pLastName = dgvtmp.SelectedRows[0].Cells["Отчество"].Value.ToString();
            DateTime.TryParse(dgvtmp.SelectedRows[0].Cells["Дата рождения"].Value.ToString(),out bdate);
            pBirthDate = bdate;
            pGroupName = dgvtmp.SelectedRows[0].Cells["Группа"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tb_middlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_group_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_studs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SearchReader_Load(object sender, EventArgs e)
        {
            button1_Click( sender,  e);
        }
    }
}
