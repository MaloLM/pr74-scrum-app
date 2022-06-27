using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    public partial class AddNewMemberForm : Form
    {

        private int projectId;
        public AddNewMemberForm(int currentProjectId)
        {
            InitializeComponent();
            this.projectId = currentProjectId;
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            Controller.ProjectController pc = new Controller.ProjectController();
            // get form data
            string memberEmail = memberEmailAddressTextBox.Text;
            string memberRole = roleSelectionComboBox.Text;

            if (memberEmail != string.Empty && memberRole != string.Empty)
            {
                erreurLabel.Visible = false;
                if (Regex.IsMatch(memberEmail.Trim(), @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    erreurLabel.Visible = false;
                    int userId = pc.FetchUserIdByEmail(memberEmail);
                    
                    if (userId > -1)
                    {
                        Member member = pc.FetchMember(this.projectId, userId);
                        if (member == null)
                        {
                            switch (memberRole)
                            {
                                case "Scrum master":
                                    memberRole = "SM";
                                    break;
                                case "Product owner":
                                    memberRole = "PO";
                                    break;
                                case "Membre":
                                    memberRole = "DEV";
                                    break;
                                default:
                                    memberRole = "DEV";
                                    break;
                            }
                            // add data to DB
                            pc.PersistMember(this.projectId, memberEmail, memberRole); // TODO ??? insert real project ID

                            // close form
                            this.Close();
                        }
                        else
                        {
                            erreurLabel.Text = "Cet utilisateur est déjà lié au projet.";
                            erreurLabel.Visible = true;
                        }
                    }
                    else
                    {
                        erreurLabel.Text = "L'adresse e-mail fournie n'est pas lié a un compte existant.";
                        erreurLabel.Visible = true;
                    }
                }
                else
                {
                    erreurLabel.Text = "Le format de l'adresse e-mail est incorrect.";
                    erreurLabel.Visible = true;
                }
            }
            else
            {
                erreurLabel.Text = "Certains champs sont vides.";
                erreurLabel.Visible = true;
            }

            
        }

    }
}
