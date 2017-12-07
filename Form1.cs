using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
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

        private void usersDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new TestDBEntities();
            int userID = (int)usersDataGrid.CurrentRow.Cells[1].Value;

            authorBookGrid.Visible = true;

            var transBookAuthr = from user in context.Library_user
                                 where user.ID_Library_user == userID
                                 join u_book in context.User_Book on user.ID_Library_user equals u_book.ID_Library_user
                                 join b_author in context.Author_Book on u_book.ID_Book equals b_author.ID_Book
                                 join book in context.Book on u_book.ID_Book equals book.ID_Book
                                 join author in context.Author on b_author.ID_Author equals author.ID_Author
                                 join bookmark in context.Bookmark on user.ID_Library_user equals bookmark.ID_Library_user
                                 //where book.ID_Book == bookmark.ID_Book
                                 select new
                                 {
                                     Book_of_Author = book.Name + ", " + author.Name,
                                     PageBookmark = bookmark.Page
                                 };

            authorBookGrid.DataSource = transBookAuthr.ToList();
        }
    }
}
