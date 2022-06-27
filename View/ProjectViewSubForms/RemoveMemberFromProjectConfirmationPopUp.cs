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

namespace pr74_scrum_app
{
    public partial class RemoveMemberFromProjectConfirmationPopUp : Form
    {
        Controller.ProjectController pc = new Controller.ProjectController();
        private int memberId;
        private int projectId;
        private string message;
        public RemoveMemberFromProjectConfirmationPopUp(Member membre, int projectId)
        {
            this.memberId = membre.Id;
            this.projectId = projectId;
            this.message = $"Voulez-vous enlever {membre.User.FirstName} {membre.User.LastName} du projet ?";
            InitializeComponent();
            messageLabel.Text = this.message;
        }

        private void RemoveMemberFromProjectConfirmationPopUp_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            Project project = pc.FetchProjectById(projectId);
            pc.RemoveMember(project, this.memberId);
            this.Close();
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
