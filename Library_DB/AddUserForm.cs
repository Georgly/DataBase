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
    public partial class AddUserForm : Form
    {
        int currentId = 0;
        public AddUserForm(int id)
        {
            InitializeComponent();
            currentId += id;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastname = textBoxLastname.Text;
            string midname = textBoxMidname.Text;

            TestDBEntities context = new TestDBEntities();
            Library_user user = context.Library_user.Add(
                                                         new Library_user
                                                         {
                                                             Name = name + " " + lastname + " " + midname,
                                                             ID_Library_user = currentId + 1
                                                         });
            context.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
