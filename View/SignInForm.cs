﻿using pr74_scrum_app.Controller;
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
            if (login.UserLogin(signinpasswordText.Text.Trim(), signiemailText.Text.Trim()))
            {
                this.Hide();
                MainForm mp = new MainForm(login.GetUserEmail(),login.GetUserId());
                mp.ShowDialog();
            }
        }
        //when click open signup form and hide the actual form
        private void SigninLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm sup = new SignUpForm();
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
    }
}
  