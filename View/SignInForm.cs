using pr74_scrum_app.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        //login to the app and hide the actual form
        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserController login = new UserController();
            if (login.UserLogin(signinpasswordText.Text.Trim(), signinemailText.Text.Trim()))
            {
                this.Hide();
                ProfilForm mp = new ProfilForm(login.User);
                mp.FormBorderStyle = FormBorderStyle.FixedDialog;
                mp.SizeGripStyle = SizeGripStyle.Hide;
                mp.ShowDialog();
            }
        }
        //when click open signup form and hide the actual form
        private void SigninLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm sup = new SignUpForm();
            sup.FormBorderStyle = FormBorderStyle.FixedDialog;
            sup.SizeGripStyle = SizeGripStyle.Hide;
            sup.ShowDialog();
        }
        //this allow to back to the home page
        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is HomeForm)
                {
                    oForm.Show();
                    break;
                }
            }
        }

        private void HomeButton(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.FormBorderStyle = FormBorderStyle.FixedDialog;
            home.SizeGripStyle = SizeGripStyle.Hide;
            home.ShowDialog();
        }
    }
}
  