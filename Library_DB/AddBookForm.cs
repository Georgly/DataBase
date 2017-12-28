using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_DB
{
    public partial class AddBookForm : Form
    {
        int userId = 0;
        public AddBookForm(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            var context = new TestDBEntities();

            var transUser = from book in context.Book
                            select new
                            {
                                Name = book.Name,
                                Genre = book.Gener,
                                id = book.ID_Book
                            };

            bookDataGrid.DataSource = transUser.ToList();
            bookDataGrid.Columns[2].Visible = false;
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void bookDataGrid_DoubleClick(object sender, EventArgs e)
        {
            int currentBookId = (int)bookDataGrid.CurrentRow.Cells[2].Value;

            var context = new TestDBEntities();

            List<User_Book> user_Book = context.User_Book
                .Where(o => o.ID_Book == currentBookId && o.ID_Library_user == userId).ToList();

            if (user_Book.Count == 0)
            {
                User_Book u_b = new User_Book
                {
                    ID_Library_user = userId,
                    ID_Book = currentBookId,
                    Limit_day = (new Random()).Next(100)
                };
                context.User_Book.Add(u_b);

                int bookmarkId = context.Bookmark.Max(p => p.ID_Bookmark) + 1;
                Bookmark bookmark = new Bookmark
                {
                    ID_Bookmark = bookmarkId,
                    ID_Library_user = userId,
                    ID_Book = currentBookId,
                    Page = 0
                };
                context.Bookmark.Add(bookmark);
                context.SaveChanges();
                MessageBox.Show("Книга добавлена!");
            }
            else
            {
                MessageBox.Show("Пользователь уже читает данную книгу!");
            }
        }
    }
}
