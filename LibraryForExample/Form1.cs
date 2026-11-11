using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryForExample
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();

            books.Add(new Book
            {
                Title = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 1967
            });

            books.Add(new Book
            {
                Title = "Преступление и наказание",
                Author = "Фёдор Достоевский",
                Year = 1866
            });

            books.Add(new Book
            {
                Title = "Евгений Онегин",
                Author = "Александр Пушкин",
                Year = 1833
            });
            RefreshTable();
        }

        private void RefreshTable()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = books;
            UpdateStatistics();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
        string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Введите название и автора!");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Год должен быть числом!");
                return;
            }

            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Year = year
            };

            books.Add(newBook);

            RefreshTable();

            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите книгу!");
                return;
            }

            Book? selectedBook =
                dgvBooks.CurrentRow.DataBoundItem as Book;

            if (selectedBook == null)
                return;

            DialogResult result = MessageBox.Show(
                "Удалить выбранную книгу?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                books.Remove(selectedBook);
                RefreshTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            List<Book> foundBooks = books
                .Where(book => book.Title.Contains(
                    searchText,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = foundBooks;
        }

        private void UpdateStatistics()
        {
            lblTotalBooks.Text = books.Count.ToString();
        }
    }
}
