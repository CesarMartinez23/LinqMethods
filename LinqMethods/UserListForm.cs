using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqMethods
{
    public partial class UserListForm : Form
    {
        private UserStub _userData;
        //private List<string> _users;
        public UserListForm()
        {
            _userData = new UserStub();
            //_users = new List<string>() { "test", "Test", "Juan" };
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            _userData.Users.ForEach(u =>
            {
                UserList.Items.Add(u);
            });
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            UserList.Items.Clear();
            var textBox = (TextBox)sender;
            string searchText = textBox.Text;
            
            //var selectedUsers = _users.Where(u =>u.Contains(searchText)).ToList();
            var selectedUsers = _userData.Users.Where(u => u.Contains(searchText)).Select(su => {
                var userSearchId = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
                var user = $"{userSearchId} - {su}";
                return user;
            }).ToArray();

            //selectedUsers.ForEach(su => {
            //    UserList.Items.Add(su);
            //});
            UserList.Items.AddRange(selectedUsers);


        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(UserList.SelectedItem.ToString(), "..:: Search Info ::..", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
