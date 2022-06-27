using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    public partial class AddNewSprintForm : Form
    {
        Controller.ProjectController pc = new Controller.ProjectController();
        private int projectId;
        public AddNewSprintForm(int currentProjectId)
        {
            this.projectId = currentProjectId;
            InitializeComponent();
        }

        private void AddNewSprintForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            // get form data
            string sprintName = sprintNameTextBox.Text;
            string startingDate = startingDateTimePicker.Text;
            string endingDate = endingDateTimePicker.Text;

            if (!string.IsNullOrWhiteSpace(sprintName))
            {
                erreurLabel.Visible = false;
                var cultureInfo = new CultureInfo("fr-FR");
                var parsedStartingDate = DateTime.Parse(startingDate, cultureInfo);
                var parsedEndingDate = DateTime.Parse(endingDate, cultureInfo);

                // compare the 2 dates
                if (parsedStartingDate <= parsedEndingDate)
                {
                    erreurLabel.Visible = false;
                    // add data to DB and close
                    pc.PersistNewSprint(sprintName, parsedStartingDate, parsedEndingDate, this.projectId);
                    this.Close();
                } else {
                    erreurLabel.Text = "La date de fin doit être supérieure ou égale à la date de début.";
                    erreurLabel.Visible = true;
                }
            } else {
                erreurLabel.Text = "Complétez le nom du sprint.";
                erreurLabel.Visible = true;
            }
        }
    }
}
