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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        //button to create a new user 
        private void SignupButton_Click(object sender, EventArgs e)
        {
            UserController reg = new UserController();
            if(reg.UserRegistration(
                firstnameText.Text,
                lastnameText.Text,
                emailText.Text,passwordText.Text,
                confirmpasswordText.Text))//if true go to sign in form 
            {
                this.Hide();//hide the actuel form
                SignInForm signin = new SignInForm();
                signin.FormBorderStyle = FormBorderStyle.FixedDialog;
                signin.SizeGripStyle = SizeGripStyle.Hide;
                signin.ShowDialog();
            }
        }

        //On click on link text sign in ths open the form signin and hide the actuel form
        private void SigninLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInForm signin = new SignInForm();
            signin.FormBorderStyle = FormBorderStyle.FixedDialog;
            signin.SizeGripStyle = SizeGripStyle.Hide;
            signin.ShowDialog();
        }
        //this allow to back to the home page 
        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void SignUpForm_Load(object sender, EventArgs e)
        {

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
