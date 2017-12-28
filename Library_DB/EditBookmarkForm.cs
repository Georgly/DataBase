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
    public partial class EditBookmarkForm : Form
    {
        int bookmarkId = 0;
        
        public EditBookmarkForm(int id)
        {
            bookmarkId = id;
            InitializeComponent();
        }

        private void EditBookmarkForm_Load(object sender, EventArgs e)
        {
            var context = new TestDBEntities();

            Bookmark bookmark = context.Bookmark.Find(bookmarkId);
            var trans = from bmark in context.Bookmark
                        join book in context.Book on bmark.ID_Book equals book.ID_Book
                        join b_author in context.Author_Book on book.ID_Book equals b_author.ID_Book
                        join author in context.Author on b_author.ID_Author equals author.ID_Author
                        where bmark.ID_Bookmark == bookmarkId
                        select new
                        {
                            Book = book.Name,
                            Author = author.Name
                        };
            pageTB.Text = bookmark.Page.ToString();
            dataGridView1.DataSource = trans.ToList();
        }

        private void okBt_Click(object sender, EventArgs e)
        {
            try
            {
                int page = Convert.ToInt32(pageTB.Text);
                if (page < 0)
                {
                    MessageBox.Show("Введите корректный номер страницы");
                    return;
                }

                var context = new TestDBEntities();
                Bookmark bookmark = context.Bookmark.Find(bookmarkId);

                List<Bookmark> list = context.Bookmark
                    .Where(o => o.ID_Book == bookmark.ID_Book &&
                                o.ID_Library_user == bookmark.ID_Library_user &&
                                o.Page == page).ToList();
                if (list.Count == 0)
                {
                    bookmark.Page = page;
                    context.Bookmark.Attach(bookmark);
                    context.Entry(bookmark).Property(o => o.Page).IsModified = true;
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
    }
}
