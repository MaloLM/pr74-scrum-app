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
    public partial class CreatePojetForm : Form
    {
        private User user;
        UserController usercontroller = new UserController();
        private ProfilForm profilForm;

        public CreatePojetForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public CreatePojetForm(User user, ProfilForm profilForm) : this(user)
        {
            this.profilForm = profilForm;
        }
        private void CreateValidedButton_Click(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Length<250 && NameProjetText.Text.Length < 30)
            {
                TailleDescriptionLabel.Visible = false;
                MaxnameLabel.Visible = false;
                if (string.IsNullOrWhiteSpace(NameProjetText.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                {
                    ErrorLabel.Visible = true;
                }
                else
                {
                    usercontroller.CreateProjet(NameProjetText.Text,DescriptionTextBox.Text,this.user.Id);
                    ErrorLabel.Visible = false;

                    //this.profilForm.SetVarShow_Form(false);
                    //this.profilForm.Close();
                    
                    //ProfilForm pro = new ProfilForm(user)
                    //{
                    //    StartPosition = FormStartPosition.CenterScreen
                    //};
                    //pro.Show();
                    this.Close();
                }
            }
            else
            {
                if (DescriptionTextBox.Text.Length > 250)
                {
                    TailleDescriptionLabel.Visible = true;
                }
                if (NameProjetText.Text.Length > 30)
                {
                    MaxnameLabel.Visible = true;
                }
            }
        }
    }
}
