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
    public partial class AddBookmarkForm : Form
    {
        int currentUser = 0;
        public AddBookmarkForm(int userId)
        {
            currentUser = userId;
            InitializeComponent();
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            try
            {
                int currentBook = (int)booksDataGrid.CurrentRow.Cells[2].Value;
                int page = Convert.ToInt32(pageTB.Text);
                if (page < 0)
                {
                    MessageBox.Show("Введите корректный номер страницы");
                    return;
                }

                var context = new TestDBEntities();

                List<Bookmark> list = context.Bookmark
                    .Where(o => o.ID_Book == currentBook &&
                                o.ID_Library_user == currentUser &&
                                o.Page == page).ToList();
                if (list.Count == 0)
                {
                    int bookmarkId = context.Bookmark.Count() != 0 ?
                        context.Bookmark.Max(p => p.ID_Bookmark) + 1 : 1;

                    Bookmark bookmark = new Bookmark
                    {
                        ID_Bookmark = bookmarkId,
                        ID_Book = currentBook,
                        ID_Library_user = currentUser,
                        Page = page
                    };

                    context.Bookmark.Add(bookmark);
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Закладка на этой странице уже сущетвует");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите номер страницы");
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddBookmarkForm_Load(object sender, EventArgs e)
        {
            var context = new TestDBEntities();

            var trans = from user in context.Library_user
                                 join u_book in context.User_Book on user.ID_Library_user equals u_book.ID_Library_user
                                 join b_author in context.Author_Book on u_book.ID_Book equals b_author.ID_Book
                                 join book in context.Book on u_book.ID_Book equals book.ID_Book
                                 join author in context.Author on b_author.ID_Author equals author.ID_Author
                                 where user.ID_Library_user == currentUser
                                 select new
                                 {
                                     Book = book.Name,
                                     Author = author.Name,
                                     bookId = book.ID_Book
                                 };
            booksDataGrid.DataSource = trans.ToList();
            booksDataGrid.Columns[2].Visible = false;
        }
    }
}
