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
    public partial class Form1 : Form
    {
        int currentUser = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshUser();
        }

        void refreshUser()
        {
            var context = new TestDBEntities();

            var transUser = from user in context.Library_user
                            select new
                            {
                                userName = user.Name,
                                userID = user.ID_Library_user
                            };

            usersDataGrid.DataSource = transUser.ToList();
            usersDataGrid.Columns[1].Visible = false;
        }

        void refreshBookmark()
        {
            var context = new TestDBEntities();
            int userID = (int)usersDataGrid.CurrentRow.Cells[1].Value;
            

            var transBookAuthr = from user in context.Library_user
                                 join u_book in context.User_Book on user.ID_Library_user equals u_book.ID_Library_user
                                 join b_author in context.Author_Book on u_book.ID_Book equals b_author.ID_Book
                                 join book in context.Book on u_book.ID_Book equals book.ID_Book
                                 join author in context.Author on b_author.ID_Author equals author.ID_Author
                                 join bookmark in context.Bookmark on user.ID_Library_user equals bookmark.ID_Library_user
                                 where user.ID_Library_user == userID && book.ID_Book == bookmark.ID_Book
                                 select new
                                 {
                                     Book_of_Author = book.Name + ", " + author.Name,
                                     PageBookmark = bookmark.Page,
                                     userId = bookmark.ID_Library_user,
                                     bookId = bookmark.ID_Book,
                                     bookmarkId = bookmark == null ? -1 : bookmark.ID_Bookmark
                                 };
            currentUser = userID;
            bookmarkDataGrid.DataSource = transBookAuthr.ToList();
            bookmarkDataGrid.Columns[2].Visible = false;
            bookmarkDataGrid.Columns[3].Visible = false;
            //bookmarkDataGrid.Columns[4].Visible = false;
        }

        private void removeUserBt_Click(object sender, EventArgs e)
        {
            TestDBEntities context = new TestDBEntities();
            int currentUser = Convert.ToInt32(
                usersDataGrid.Rows[usersDataGrid.CurrentRow.Index].Cells[1].Value);

            Library_user library_User = context.Library_user
                .Where(o => o.ID_Library_user == currentUser)
                .FirstOrDefault();

            List<Bookmark> bookmarks = context.Bookmark
                .Where(o => o.ID_Library_user == library_User.ID_Library_user)
                .ToList();

            List<User_Book> user_book = context.User_Book
                .Where(o => o.ID_Library_user == library_User.ID_Library_user)
                .ToList();

            for (int i = 0; i < bookmarks.Count; i++)
            {
                context.Bookmark.Remove(bookmarks[i]);
            }
            for (int i = 0; i < user_book.Count; i++)
            {
                context.User_Book.Remove(user_book[i]);
            }
            context.Library_user.Remove(library_User);

            context.SaveChanges();

            refreshUser();
            refreshBookmark();
        }

        private void addUserBt_Click(object sender, EventArgs e)
        {
            AddUserForm userForm = new AddUserForm(Convert.ToInt32(usersDataGrid.Rows[usersDataGrid.RowCount - 1].Cells[1].Value));

            if (userForm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("OK");
                refreshUser();
            }
            else
                MessageBox.Show("Canceled");
        }

        private void addBookmarkBt_Click(object sender, EventArgs e)
        {
            try
            {
                AddBookmarkForm userForm = new AddBookmarkForm(currentUser);

                if (userForm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                    refreshBookmark();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("У пользователя нет книг. Добавте книгу");
            }
        }

        private void removeBookmarkBt_Click(object sender, EventArgs e)
        {
            try
            {
                TestDBEntities context = new TestDBEntities();
                int currentBookmark = (int)bookmarkDataGrid.CurrentRow.Cells[4].Value;

                Bookmark bookmarks = context.Bookmark.Find(currentBookmark);

                context.Bookmark.Remove(bookmarks);
                context.SaveChanges();

                refreshBookmark();
            }
            catch (Exception)
            {
                MessageBox.Show("У пользователя нет книг. Добавте книгу");
            }
        }

        private void usersDataGrid_DoubleClick(object sender, EventArgs e)
        {
            refreshBookmark();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            int userId = (int)usersDataGrid.CurrentRow.Cells[1].Value;
            AddBookForm userForm = new AddBookForm(userId);

            if (userForm.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("OK");
                refreshBookmark();
            }
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            int bookmarkId = (int)bookmarkDataGrid.CurrentRow.Cells[4].Value;
            EditBookmarkForm f = new EditBookmarkForm(bookmarkId);

            if (f.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("OK");
                refreshBookmark();
            }
        }
    }
}
