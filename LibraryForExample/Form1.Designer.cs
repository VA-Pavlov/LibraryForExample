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
            lblBookTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            btnAdd = new Button();
            dgvBooks = new DataGridView();
            lblCount = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(63, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Мини-библиотека";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(98, 205);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(69, 19);
            lblBookTitle.TabIndex = 1;
            lblBookTitle.Text = "Название";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(63, 86);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(254, 25);
            txtTitle.TabIndex = 2;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(368, 205);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 19);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Автор";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(342, 86);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(284, 25);
            txtAuthor.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(63, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(563, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить книгу";
            btnAdd.UseVisualStyleBackColor = true;
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
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvBooks.Size = new Size(563, 265);
            dgvBooks.TabIndex = 6;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(53, 534);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(90, 19);
            lblCount.TabIndex = 7;
            lblCount.Text = "\tВсего книг: 0";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 534);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 26);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить выбранную";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(697, 596);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(dgvBooks);
            Controls.Add(btnAdd);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblBookTitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мини-библиотека";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblBookTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Button btnAdd;
        private DataGridView dgvBooks;
        private Label lblCount;
        private Button btnDelete;
    }
}
