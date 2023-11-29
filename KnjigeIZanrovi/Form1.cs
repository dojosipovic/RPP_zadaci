using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnjigeIZanrovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            FillGenres();
            Genre genre = dgvGenres.CurrentRow.DataBoundItem as Genre;
            FillBooks(genre);
        }

        private void FillBooks(Genre genre)
        {
            dgvBooks.DataSource = GetBooks(genre);
            dgvBooks.Columns["IdGenres"].Visible = false;
            dgvBooks.Columns["Genre"].Visible = false;
        }

        private object GetBooks(Genre genre)
        {
            List<Book> books = new List<Book>();
            using(var context = new EF_DBEntities())
            {
                books = context.Books.ToList();
                return books.FindAll(x => x.Genre.Id == genre.Id);
            }
        }

        private void FillGenres()
        {
            dgvGenres.DataSource = GetGenres();
            dgvGenres.Columns["Books"].Visible = false;
        }

        private object GetGenres()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Genres.ToList();
            }
        }

        private void dgvGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Genre genre = dgvGenres.CurrentRow.DataBoundItem as Genre;
            FillBooks(genre);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Genre genre = dgvGenres.CurrentRow.DataBoundItem as Genre;
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int pages;

            bool success = int.TryParse(txtPages.Text, out pages);
            if (!success) return;

            Book book = new Book
            {
                Title = title,
                NumOfPages = pages,
                MainAuthor = author,
                IdGenres = genre.Id,
            };

            using(var context = new EF_DBEntities())
            {
                context.Genres.Attach(genre);
                context.Books.Attach(book);

                context.Books.Add(book);

                context.SaveChanges();
            }

            RefreshGUI();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Book book = dgvBooks.CurrentRow.DataBoundItem as Book;
            using(var context = new EF_DBEntities())
            {
                context.Books.Attach(book);
                context.Books.Remove(book);
                context.SaveChanges();
            }

            RefreshGUI();
        }
    }
}
