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
    public partial class ArchiveProjectConfirmationForm : Form
    {
        Controller.ProjectController pc = new Controller.ProjectController();
        private int projectId;

        public ArchiveProjectConfirmationForm(int currentProjectId)
        {
            this.projectId = currentProjectId;
            InitializeComponent();
        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            pc.ArchiveProject(this.projectId);
            this.Close();
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
