namespace Danilov_library
{
    partial class SearchReader
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
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_middlename = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_group = new System.Windows.Forms.TextBox();
            this.dgv_studs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studs)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(9, 35);
            this.tb_firstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(88, 20);
            this.tb_firstname.TabIndex = 0;
            this.tb_firstname.TextChanged += new System.EventHandler(this.tb_firstname_TextChanged);
            // 
            // tb_middlename
            // 
            this.tb_middlename.Location = new System.Drawing.Point(114, 35);
            this.tb_middlename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_middlename.Name = "tb_middlename";
            this.tb_middlename.Size = new System.Drawing.Size(88, 20);
            this.tb_middlename.TabIndex = 0;
            this.tb_middlename.TextChanged += new System.EventHandler(this.tb_middlename_TextChanged);
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(221, 35);
            this.tb_lastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(88, 20);
            this.tb_lastName.TabIndex = 0;
            this.tb_lastName.TextChanged += new System.EventHandler(this.tb_lastName_TextChanged);
            // 
            // tb_group
            // 
            this.tb_group.Location = new System.Drawing.Point(321, 35);
            this.tb_group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_group.Name = "tb_group";
            this.tb_group.Size = new System.Drawing.Size(88, 20);
            this.tb_group.TabIndex = 0;
            this.tb_group.TextChanged += new System.EventHandler(this.tb_group_TextChanged);
            // 
            // dgv_studs
            // 
            this.dgv_studs.AllowUserToAddRows = false;
            this.dgv_studs.AllowUserToDeleteRows = false;
            this.dgv_studs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studs.Location = new System.Drawing.Point(9, 65);
            this.dgv_studs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_studs.Name = "dgv_studs";
            this.dgv_studs.ReadOnly = true;
            this.dgv_studs.RowHeadersWidth = 51;
            this.dgv_studs.RowTemplate.Height = 24;
            this.dgv_studs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_studs.Size = new System.Drawing.Size(582, 291);
            this.dgv_studs.TabIndex = 1;
            this.dgv_studs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studs_CellContentClick);
            this.dgv_studs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studs_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Группа";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SearchReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_studs);
            this.Controls.Add(this.tb_group);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_middlename);
            this.Controls.Add(this.tb_firstname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchReader";
            this.Text = "SearchReader";
            this.Load += new System.EventHandler(this.SearchReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_middlename;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_group;
        private System.Windows.Forms.DataGridView dgv_studs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}