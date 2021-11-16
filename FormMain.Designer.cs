namespace Danilov_library
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_todayReturns = new System.Windows.Forms.DataGridView();
            this.книгаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todayBooksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new Danilov_library.DataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_overdue = new System.Windows.Forms.DataGridView();
            this.книгаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_readerEdit = new System.Windows.Forms.Button();
            this.bt_bookOper = new System.Windows.Forms.Button();
            this.bt_bookEdit = new System.Windows.Forms.Button();
            this.todayBooksTableAdapter1 = new Danilov_library.DataSet3TableAdapters.todayBooksTableAdapter();
            this.overdueBooksTableAdapter = new Danilov_library.DataSet3TableAdapters.overdueBooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todayReturns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayBooksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_overdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Книги к сдаче сегодня";
            // 
            // dgv_todayReturns
            // 
            this.dgv_todayReturns.AllowUserToAddRows = false;
            this.dgv_todayReturns.AllowUserToDeleteRows = false;
            this.dgv_todayReturns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_todayReturns.AutoGenerateColumns = false;
            this.dgv_todayReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todayReturns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.книгаDataGridViewTextBoxColumn,
            this.студентDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn});
            this.dgv_todayReturns.DataSource = this.todayBooksBindingSource1;
            this.dgv_todayReturns.Location = new System.Drawing.Point(12, 42);
            this.dgv_todayReturns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_todayReturns.Name = "dgv_todayReturns";
            this.dgv_todayReturns.ReadOnly = true;
            this.dgv_todayReturns.RowHeadersWidth = 51;
            this.dgv_todayReturns.RowTemplate.Height = 24;
            this.dgv_todayReturns.Size = new System.Drawing.Size(608, 288);
            this.dgv_todayReturns.TabIndex = 1;
            // 
            // книгаDataGridViewTextBoxColumn
            // 
            this.книгаDataGridViewTextBoxColumn.DataPropertyName = "Книга";
            this.книгаDataGridViewTextBoxColumn.HeaderText = "Книга";
            this.книгаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.книгаDataGridViewTextBoxColumn.Name = "книгаDataGridViewTextBoxColumn";
            this.книгаDataGridViewTextBoxColumn.ReadOnly = true;
            this.книгаDataGridViewTextBoxColumn.Width = 125;
            // 
            // студентDataGridViewTextBoxColumn
            // 
            this.студентDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.студентDataGridViewTextBoxColumn.DataPropertyName = "Студент";
            this.студентDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.студентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.студентDataGridViewTextBoxColumn.Name = "студентDataGridViewTextBoxColumn";
            this.студентDataGridViewTextBoxColumn.ReadOnly = true;
            this.студентDataGridViewTextBoxColumn.Width = 6;
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            this.датаВозвратаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаВозвратаDataGridViewTextBoxColumn.Width = 124;
            // 
            // todayBooksBindingSource1
            // 
            this.todayBooksBindingSource1.DataMember = "todayBooks";
            this.todayBooksBindingSource1.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Просроченные книги";
            // 
            // dgv_overdue
            // 
            this.dgv_overdue.AllowUserToAddRows = false;
            this.dgv_overdue.AllowUserToDeleteRows = false;
            this.dgv_overdue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_overdue.AutoGenerateColumns = false;
            this.dgv_overdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_overdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.книгаDataGridViewTextBoxColumn1,
            this.студентDataGridViewTextBoxColumn1,
            this.датаВозвратаDataGridViewTextBoxColumn1});
            this.dgv_overdue.DataSource = this.overdueBooksBindingSource;
            this.dgv_overdue.Location = new System.Drawing.Point(685, 42);
            this.dgv_overdue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_overdue.Name = "dgv_overdue";
            this.dgv_overdue.ReadOnly = true;
            this.dgv_overdue.RowHeadersWidth = 51;
            this.dgv_overdue.Size = new System.Drawing.Size(696, 288);
            this.dgv_overdue.TabIndex = 1;
            // 
            // книгаDataGridViewTextBoxColumn1
            // 
            this.книгаDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.книгаDataGridViewTextBoxColumn1.DataPropertyName = "Книга";
            this.книгаDataGridViewTextBoxColumn1.HeaderText = "Книга";
            this.книгаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.книгаDataGridViewTextBoxColumn1.Name = "книгаDataGridViewTextBoxColumn1";
            this.книгаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.книгаDataGridViewTextBoxColumn1.Width = 75;
            // 
            // студентDataGridViewTextBoxColumn1
            // 
            this.студентDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.студентDataGridViewTextBoxColumn1.DataPropertyName = "Студент";
            this.студентDataGridViewTextBoxColumn1.HeaderText = "Студент";
            this.студентDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.студентDataGridViewTextBoxColumn1.Name = "студентDataGridViewTextBoxColumn1";
            this.студентDataGridViewTextBoxColumn1.ReadOnly = true;
            this.студентDataGridViewTextBoxColumn1.Width = 91;
            // 
            // датаВозвратаDataGridViewTextBoxColumn1
            // 
            this.датаВозвратаDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.датаВозвратаDataGridViewTextBoxColumn1.DataPropertyName = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn1.HeaderText = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.датаВозвратаDataGridViewTextBoxColumn1.Name = "датаВозвратаDataGridViewTextBoxColumn1";
            this.датаВозвратаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.датаВозвратаDataGridViewTextBoxColumn1.Width = 124;
            // 
            // overdueBooksBindingSource
            // 
            this.overdueBooksBindingSource.DataMember = "overdueBooks";
            this.overdueBooksBindingSource.DataSource = this.dataSet3;
            // 
            // bt_readerEdit
            // 
            this.bt_readerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_readerEdit.Location = new System.Drawing.Point(424, 336);
            this.bt_readerEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_readerEdit.Name = "bt_readerEdit";
            this.bt_readerEdit.Size = new System.Drawing.Size(371, 36);
            this.bt_readerEdit.TabIndex = 2;
            this.bt_readerEdit.Text = "Добавление читательского билета";
            this.bt_readerEdit.UseVisualStyleBackColor = true;
            this.bt_readerEdit.Click += new System.EventHandler(this.bt_readerEdit_Click);
            // 
            // bt_bookOper
            // 
            this.bt_bookOper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_bookOper.Location = new System.Drawing.Point(424, 410);
            this.bt_bookOper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bookOper.Name = "bt_bookOper";
            this.bt_bookOper.Size = new System.Drawing.Size(371, 33);
            this.bt_bookOper.TabIndex = 3;
            this.bt_bookOper.Text = "Сдача/выдача книг";
            this.bt_bookOper.UseVisualStyleBackColor = true;
            this.bt_bookOper.Click += new System.EventHandler(this.bt_bookOper_Click);
            // 
            // bt_bookEdit
            // 
            this.bt_bookEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_bookEdit.Location = new System.Drawing.Point(424, 375);
            this.bt_bookEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bookEdit.Name = "bt_bookEdit";
            this.bt_bookEdit.Size = new System.Drawing.Size(371, 30);
            this.bt_bookEdit.TabIndex = 4;
            this.bt_bookEdit.Text = "Добавление книги";
            this.bt_bookEdit.UseVisualStyleBackColor = true;
            this.bt_bookEdit.Click += new System.EventHandler(this.bt_bookEdit_Click);
            // 
            // todayBooksTableAdapter1
            // 
            this.todayBooksTableAdapter1.ClearBeforeFill = true;
            // 
            // overdueBooksTableAdapter
            // 
            this.overdueBooksTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 446);
            this.Controls.Add(this.bt_bookEdit);
            this.Controls.Add(this.bt_bookOper);
            this.Controls.Add(this.bt_readerEdit);
            this.Controls.Add(this.dgv_overdue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_todayReturns);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Основное меню";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todayReturns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayBooksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_overdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_todayReturns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_overdue;
        private System.Windows.Forms.Button bt_readerEdit;
        private System.Windows.Forms.Button bt_bookOper;
        private System.Windows.Forms.Button bt_bookEdit;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource todayBooksBindingSource1;
        private DataSet3TableAdapters.todayBooksTableAdapter todayBooksTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn книгаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn студентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource overdueBooksBindingSource;
        private DataSet3TableAdapters.overdueBooksTableAdapter overdueBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn книгаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn студентDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn1;
    }
}