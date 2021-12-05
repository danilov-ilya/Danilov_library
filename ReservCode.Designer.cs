
namespace Danilov_library
{
    partial class ReservCode
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_Book = new System.Windows.Forms.ComboBox();
            this.BookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_Reader = new System.Windows.Forms.ComboBox();
            this.ReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet3 = new Danilov_library.DataSet3();
            this.booksreservedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.books_reservedTableAdapter = new Danilov_library.DataSet3TableAdapters.books_reservedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksreservedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Резерв";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CB_Book
            // 
            this.CB_Book.DataSource = this.BookBindingSource;
            this.CB_Book.DisplayMember = "title";
            this.CB_Book.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Book.FormattingEnabled = true;
            this.CB_Book.Location = new System.Drawing.Point(231, 29);
            this.CB_Book.Name = "CB_Book";
            this.CB_Book.Size = new System.Drawing.Size(180, 24);
            this.CB_Book.TabIndex = 1;
            this.CB_Book.ValueMember = "isbn";
            this.CB_Book.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BookBindingSource
            // 
            this.BookBindingSource.DataSource = typeof(Danilov_library.books);
            // 
            // CB_Reader
            // 
            this.CB_Reader.DataSource = this.ReaderBindingSource;
            this.CB_Reader.DisplayMember = "last_name";
            this.CB_Reader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Reader.FormattingEnabled = true;
            this.CB_Reader.Location = new System.Drawing.Point(12, 29);
            this.CB_Reader.Name = "CB_Reader";
            this.CB_Reader.Size = new System.Drawing.Size(178, 24);
            this.CB_Reader.TabIndex = 3;
            this.CB_Reader.ValueMember = "lib_card_number";
            this.CB_Reader.SelectedIndexChanged += new System.EventHandler(this.CB_Reader_SelectedIndexChanged);
            // 
            // ReaderBindingSource
            // 
            this.ReaderBindingSource.DataSource = typeof(Danilov_library.students);
            this.ReaderBindingSource.CurrentChanged += new System.EventHandler(this.librarydanilovEntitiesBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Книга";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Читатель";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksreservedBindingSource
            // 
            this.booksreservedBindingSource.DataMember = "books_reserved";
            this.booksreservedBindingSource.DataSource = this.dataSet3;
            // 
            // books_reservedTableAdapter
            // 
            this.books_reservedTableAdapter.ClearBeforeFill = true;
            // 
            // ReservCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 134);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Reader);
            this.Controls.Add(this.CB_Book);
            this.Controls.Add(this.button1);
            this.Name = "ReservCode";
            this.Text = "ReservCode";
            this.Load += new System.EventHandler(this.ReservCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksreservedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_Book;
        private System.Windows.Forms.ComboBox CB_Reader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource booksreservedBindingSource;
        private DataSet3TableAdapters.books_reservedTableAdapter books_reservedTableAdapter;
        private System.Windows.Forms.BindingSource BookBindingSource;
        private System.Windows.Forms.BindingSource ReaderBindingSource;
    }
}