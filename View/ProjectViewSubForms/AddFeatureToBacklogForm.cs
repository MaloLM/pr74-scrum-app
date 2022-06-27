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
    public partial class AddFeatureToBacklogForm : Form
    {
        Controller.ProjectController pc = new Controller.ProjectController();
        private int projectId;
        public AddFeatureToBacklogForm(int currentProjectId)
        {
            this.projectId = currentProjectId; 
            InitializeComponent();
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFeatureToBacklogForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            // get form data
            string name = backlogFeatureTitleTextBox.Text;
            string priority = priorityComboBox.Text;
            decimal decimalComplexity = complexityLevelNumericUpDown.Value;
            int complexity = ((int)decimalComplexity);
            string description = featureDescription.Text;

            if (!string.IsNullOrWhiteSpace(name)
                 && !string.IsNullOrWhiteSpace(priority)
                  && !string.IsNullOrWhiteSpace(description))
            {
                erreurLabel.Visible = false;

                int priorityLevel = 3;
                switch (priority)
                {
                    case "Haute":
                        priorityLevel = 1;
                        break;
                    case "Moyenne":
                        priorityLevel = 2;
                        break;
                    case "Basse":
                        priorityLevel = 3;
                        break;
                    default:
                        break;
                }

                // add data to DB and close
                pc.PersistProductBacklogUserStory(name, priorityLevel, complexity, description, this.projectId);
                this.Close();
            }
            else
            {
                erreurLabel.Text = "Certains champs sont vides.";
                erreurLabel.Visible = true;
            }
        }
    }
}
