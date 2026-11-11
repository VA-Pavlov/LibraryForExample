namespace LibraryForExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            btnAdd = new Button();
            dgvBooks = new DataGridView();
            lblTotalTitle = new Label();
            btnDelete = new Button();
            txtYear = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblTotalBooks = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(63, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Мини-библиотека";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(63, 89);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(254, 25);
            txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(342, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(284, 25);
            txtAuthor.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(190, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(436, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить книгу";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(63, 236);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(563, 265);
            dgvBooks.TabIndex = 6;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(53, 534);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(78, 19);
            lblTotalTitle.TabIndex = 7;
            lblTotalTitle.Text = "Всего книг:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 534);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 26);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить выбранную";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(63, 135);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(111, 25);
            txtYear.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(63, 196);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 25);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(342, 195);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 26);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.ForeColor = Color.RoyalBlue;
            lblTotalBooks.Location = new Point(129, 534);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(17, 19);
            lblTotalBooks.TabIndex = 12;
            lblTotalBooks.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(697, 596);
            Controls.Add(lblTotalBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtYear);
            Controls.Add(btnDelete);
            Controls.Add(lblTotalTitle);
            Controls.Add(dgvBooks);
            Controls.Add(btnAdd);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мини-библиотека";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Button btnAdd;
        private DataGridView dgvBooks;
        private Label lblTotalTitle;
        private Button btnDelete;
        private TextBox txtYear;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblTotalBooks;
    }
}
