using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app.View.ProjectViewSubForms
{
    public partial class DisplayMemberInfo : Form
    {
        Controller.ProjectController pc = new Controller.ProjectController();
        private Member member;
        private int projectId;
        public DisplayMemberInfo(int userId, int projectId)
        {   

            Member m = pc.FetchMember(projectId, userId);
            InitializeComponent();
            if (m == null)
            {
                
                errorLabel.Visible = true;
                removeButton.Visible = false;
                emailInsertion.Visible = false;
                firstnameInsertion.Visible = false;
                lastnameInsertion.Visible = false;
                roleInsertion.Visible = false;
                emailLabel.Visible = false;
                firstnameLabel.Visible = false;
                lastnameLabel.Visible = false;
                roleLabel.Visible = false;
            } else {
                this.member = m;
                this.projectId = projectId;
                errorLabel.Visible = false;
                firstnameInsertion.Text = this.member.User.FirstName;
                lastnameInsertion.Text = this.member.User.LastName;
                emailInsertion.Text = this.member.User.Email;
                switch (this.member.Role)
                {
                    case "SM":
                        roleInsertion.Text = "Scrum Master";
                        break;
                    case "PO":
                        roleInsertion.Text = "Product owner";
                        break;
                    case "DEV":
                        roleInsertion.Text = "Membre";
                        break;
                    default:
                        break;
                } 
            }
        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveMemberFromProjectConfirmationPopUp form = new RemoveMemberFromProjectConfirmationPopUp(this.member, this.projectId);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.ShowDialog();
            this.Close();
        }
    }
}
