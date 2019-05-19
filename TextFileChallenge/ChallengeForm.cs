using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        private readonly BindingList<UserModel> users = new BindingList<UserModel>();

        public ChallengeForm()
        {
            InitializeComponent();

            WireUpDropDown();
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
        }

        private void SaveListButton_Click(object sender, EventArgs e)
        {
        }
    }
}