namespace Danilov_library
{
    partial class BookGivaTakeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_give = new System.Windows.Forms.Button();
            this.bt_take = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_studFirstName = new System.Windows.Forms.TextBox();
            this.tb_studMiddleName = new System.Windows.Forms.TextBox();
            this.tb_studLastName = new System.Windows.Forms.TextBox();
            this.tb_studGroup = new System.Windows.Forms.TextBox();
            this.tb_bookAuthor = new System.Windows.Forms.TextBox();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.tb_bookYear = new System.Windows.Forms.TextBox();
            this.bt_studSearch = new System.Windows.Forms.Button();
            this.bt_searchBook = new System.Windows.Forms.Button();
            this.dt_returnDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выдача/прием книги";
            // 
            // bt_give
            // 
            this.bt_give.Location = new System.Drawing.Point(16, 253);
            this.bt_give.Margin = new System.Windows.Forms.Padding(2);
            this.bt_give.Name = "bt_give";
            this.bt_give.Size = new System.Drawing.Size(57, 20);
            this.bt_give.TabIndex = 31;
            this.bt_give.Text = "Выдать";
            this.bt_give.UseVisualStyleBackColor = true;
            this.bt_give.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_take
            // 
            this.bt_take.Location = new System.Drawing.Point(276, 253);
            this.bt_take.Margin = new System.Windows.Forms.Padding(2);
            this.bt_take.Name = "bt_take";
            this.bt_take.Size = new System.Drawing.Size(70, 20);
            this.bt_take.TabIndex = 31;
            this.bt_take.Text = "Принять";
            this.bt_take.UseVisualStyleBackColor = true;
            this.bt_take.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_studFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_studMiddleName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_studLastName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_studGroup, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_bookAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbBookTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_bookYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_studSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_searchBook, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dt_returnDate, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 192);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tb_studFirstName
            // 
            this.tb_studFirstName.Location = new System.Drawing.Point(3, 41);
            this.tb_studFirstName.Name = "tb_studFirstName";
            this.tb_studFirstName.ReadOnly = true;
            this.tb_studFirstName.Size = new System.Drawing.Size(160, 20);
            this.tb_studFirstName.TabIndex = 0;
            // 
            // tb_studMiddleName
            // 
            this.tb_studMiddleName.Location = new System.Drawing.Point(3, 79);
            this.tb_studMiddleName.Name = "tb_studMiddleName";
            this.tb_studMiddleName.ReadOnly = true;
            this.tb_studMiddleName.Size = new System.Drawing.Size(160, 20);
            this.tb_studMiddleName.TabIndex = 1;
            // 
            // tb_studLastName
            // 
            this.tb_studLastName.Location = new System.Drawing.Point(3, 117);
            this.tb_studLastName.Name = "tb_studLastName";
            this.tb_studLastName.ReadOnly = true;
            this.tb_studLastName.Size = new System.Drawing.Size(160, 20);
            this.tb_studLastName.TabIndex = 2;
            // 
            // tb_studGroup
            // 
            this.tb_studGroup.Location = new System.Drawing.Point(3, 155);
            this.tb_studGroup.Name = "tb_studGroup";
            this.tb_studGroup.ReadOnly = true;
            this.tb_studGroup.Size = new System.Drawing.Size(160, 20);
            this.tb_studGroup.TabIndex = 3;
            // 
            // tb_bookAuthor
            // 
            this.tb_bookAuthor.Location = new System.Drawing.Point(169, 41);
            this.tb_bookAuthor.Name = "tb_bookAuthor";
            this.tb_bookAuthor.ReadOnly = true;
            this.tb_bookAuthor.Size = new System.Drawing.Size(160, 20);
            this.tb_bookAuthor.TabIndex = 5;
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(169, 79);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.ReadOnly = true;
            this.tbBookTitle.Size = new System.Drawing.Size(160, 20);
            this.tbBookTitle.TabIndex = 6;
            // 
            // tb_bookYear
            // 
            this.tb_bookYear.Location = new System.Drawing.Point(169, 117);
            this.tb_bookYear.Name = "tb_bookYear";
            this.tb_bookYear.ReadOnly = true;
            this.tb_bookYear.Size = new System.Drawing.Size(160, 20);
            this.tb_bookYear.TabIndex = 7;
            // 
            // bt_studSearch
            // 
            this.bt_studSearch.Location = new System.Drawing.Point(3, 3);
            this.bt_studSearch.Name = "bt_studSearch";
            this.bt_studSearch.Size = new System.Drawing.Size(160, 23);
            this.bt_studSearch.TabIndex = 8;
            this.bt_studSearch.Text = "Студент";
            this.bt_studSearch.UseVisualStyleBackColor = true;
            this.bt_studSearch.Click += new System.EventHandler(this.bt_studSearch_Click);
            // 
            // bt_searchBook
            // 
            this.bt_searchBook.Location = new System.Drawing.Point(169, 3);
            this.bt_searchBook.Name = "bt_searchBook";
            this.bt_searchBook.Size = new System.Drawing.Size(160, 23);
            this.bt_searchBook.TabIndex = 9;
            this.bt_searchBook.Text = "Книга";
            this.bt_searchBook.UseVisualStyleBackColor = true;
            this.bt_searchBook.Click += new System.EventHandler(this.bt_searchBook_Click);
            // 
            // dt_returnDate
            // 
            this.dt_returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_returnDate.Location = new System.Drawing.Point(169, 155);
            this.dt_returnDate.Name = "dt_returnDate";
            this.dt_returnDate.Size = new System.Drawing.Size(161, 20);
            this.dt_returnDate.TabIndex = 10;
            // 
            // BookGivaTakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 284);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bt_take);
            this.Controls.Add(this.bt_give);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookGivaTakeForm";
            this.Text = "Form5";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_give;
        private System.Windows.Forms.Button bt_take;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_studFirstName;
        private System.Windows.Forms.TextBox tb_studMiddleName;
        private System.Windows.Forms.TextBox tb_studLastName;
        private System.Windows.Forms.TextBox tb_studGroup;
        private System.Windows.Forms.TextBox tb_bookAuthor;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.TextBox tb_bookYear;
        private System.Windows.Forms.Button bt_studSearch;
        private System.Windows.Forms.Button bt_searchBook;
        private System.Windows.Forms.DateTimePicker dt_returnDate;
    }
}