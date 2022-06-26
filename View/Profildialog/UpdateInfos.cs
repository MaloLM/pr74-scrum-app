using pr74_scrum_app.Controller;
using System;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    public partial class UpdateInfos : Form
    {
        private User user;
        UserController usercontroller = new UserController();
        public UpdateInfos(User user)
        {
            InitializeComponent();
            firstnameText.Text = user.FirstName;
            lastnameText.Text = user.LastName;
            emailText.Text = user.Email;
            passwordText.Text = "12345678";
            this.user = user;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstnameText.Text) || string.IsNullOrWhiteSpace(lastnameText.Text))
            {
                ErrorLabel.Visible = true;
            }
            else
            {
                this.user.FirstName = firstnameText.Text;
                this.user.LastName=lastnameText.Text;
                usercontroller.UpdateInfos(firstnameText.Text, lastnameText.Text,emailText.Text, this.user.Id);
                ErrorLabel.Visible = false;
                this.Close();
            }
        }
    }
}
