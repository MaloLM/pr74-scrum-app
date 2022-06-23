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
    public partial class ProfilForm : Form
    {
        private readonly User user;
        private Boolean show=true;
        List<Project> projects;
        List<Sprint> sprints;
        List<UserStory> tasks;

        public ProfilForm(User User)
        {
            InitializeComponent();
            EmailtextBox.Text = User.Email;
            this.user = User;

            //projets
            projectLabels = new List<Label>();
            projectLabels.Add(ProjectLabel1);
            projectLabels.Add(ProjectLabel2);
            projectLabels.Add(ProjectLabel3);
            projectLabels.Add(ProjectLabel4);
            roudboutonProjects = new List<View.RoundButton>();
            roudboutonProjects.Add(ProjectRoundButton1);
            roudboutonProjects.Add(ProjectRoundButton2);
            roudboutonProjects.Add(ProjectRoundButton3);
            roudboutonProjects.Add(ProjectRoundButton4);
            ProjectPictureBoxs= new List<PictureBox>();
            ProjectPictureBoxs.Add(ProjectPictureBox1);
            ProjectPictureBoxs.Add(ProjectPictureBox2);
            ProjectPictureBoxs.Add(ProjectPictureBox3);
            ProjectPictureBoxs.Add(ProjectPictureBox4);

            //sprint
            Sprintlabels = new List<Label>();
            Sprintlabels.Add(SprintLabel1);
            Sprintlabels.Add(SprintLabel2);
            Sprintlabels.Add(SprintLabel3);
            Sprintlabels.Add(SprintLabel4);
            roudboutonSprints = new List<View.RoundButton>();
            roudboutonSprints.Add(roundButtonSprint1);
            roudboutonSprints.Add(roundButtonSprint2);
            roudboutonSprints.Add(roundButtonSprint3);
            roudboutonSprints.Add(roundButtonSprint4);
            SprintPictureBoxs = new List<PictureBox>();
            SprintPictureBoxs.Add(SprintpictureBox1);
            SprintPictureBoxs.Add(SprintpictureBox2);
            SprintPictureBoxs.Add(SprintpictureBox3);
            SprintPictureBoxs.Add(SprintpictureBox4);

            //stack
            tasklabels = new List<Label>();
            tasklabels.Add(Tasklabel1);
            tasklabels.Add(Tasklabel2);
            tasklabels.Add(Tasklabel3);
            tasklabels.Add(Tasklabel4);
            Tasksroudboutons = new List<View.RoundButton>();
            Tasksroudboutons.Add(TaskroundButton1);
            Tasksroudboutons.Add(TaskroundButton2);
            Tasksroudboutons.Add(TaskroundButton3);
            Tasksroudboutons.Add(TaskroundButton4);
            TaskPictureBoxs = new List<PictureBox>();
            TaskPictureBoxs.Add(TaskpictureBox1);
            TaskPictureBoxs.Add(TaskpictureBox2);
            TaskPictureBoxs.Add(TaskpictureBox3);
            TaskPictureBoxs.Add(TaskpictureBox4);

            LoadData();
        }

        private void PictureProfilBox_Click(object sender, EventArgs e)
        {
            ProfilListBox.Visible = true;
        }

        private Boolean ShowHome_Form()
        {
            return show;
        }
        //st the close form condiition
        public void SetVarShow_Form(Boolean show)
        {
            this.show = show;
        }

        //when bouton close form is click this show the home form
        private void ProfilViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ShowHome_Form())
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

        private void ProfilListBox_MouseHover(object sender, EventArgs e)
        {
            ProfilListBox.Visible = true;
        }

        private void ProfilListBox_MouseLeave(object sender, EventArgs e)
        {
            ProfilListBox.Visible = false;
        }

        //if i click on an item proffil list box i ave 2 choices
        private void ProfilListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProfilListBox.SelectedItem != null)
            {
                if(ProfilListBox.SelectedItem.ToString()=="Mon profil")
                {
                    UpdateInfos update = new UpdateInfos(user);
                    update.ShowDialog();
                }
                if(ProfilListBox.SelectedItem.ToString() == "Déconnexion")
                {
                    MessageBoxButtons conf = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnection", conf);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
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
        }

        private void CreateProjetButton_Click(object sender, EventArgs e)
        {
            CreatePojetForm create = new CreatePojetForm(user,this);
            create.Show();
        }

        public void LoadData()
        {
            UserController userController=new UserController();
            projects =userController.ReloadProjet(this.user.Id);
            sprints = userController.ReloadSprint(this.user.Id);
            tasks = userController.ReloadTask(this.user.Id);
            if(!projects.Any()) //hide all projet composent and show no projet
            {
                for(int i = 1; i < 4; i++)
                {
                    roudboutonProjects[i].Visible = false;
                    ProjectPictureBoxs[i].Visible = false;
                    projectLabels[i].Visible = false;
                }
                NoProjectLabel.Visible = true;
            }
            else
            {
                int i = 0;
                foreach (var item in projects)
                {
                    Label label = projectLabels[i];
                    View.RoundButton button = roudboutonProjects[i];
                    PictureBox picture = ProjectPictureBoxs[i];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    i++;
                }
            }
            if (!sprints.Any())
            {
                for (int i = 1; i < 4; i++)
                {
                    roudboutonSprints[i].Visible = false;
                    SprintPictureBoxs[i].Visible = false;
                    Sprintlabels[i].Visible = false;
                }
                NoSprintLabel.Visible = true;
            }
            else
            {
                int j = 0;
                foreach (var item in sprints)
                {
                    Label label = Sprintlabels[j];
                    View.RoundButton button = roudboutonSprints[j];
                    PictureBox picture = SprintPictureBoxs[j];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    j++;
                }
            }
            if (!tasks.Any())
            {
                for (int i = 1; i < 4; i++)
                {
                    Tasksroudboutons[i].Visible = false;
                    TaskPictureBoxs[i].Visible = false;
                    tasklabels[i].Visible = false;
                }
                NoTaskLabel.Visible = true; ;
            }
            else
            {
                int k = 0;
                foreach (var item in tasks)
                {
                    Label label = tasklabels[k];
                    View.RoundButton button = Tasksroudboutons[k];
                    PictureBox picture = TaskPictureBoxs[k];
                    label.Visible = true;
                    button.Visible = true;
                    picture.Visible = true;
                    label.Text = item.Name;
                    k++;
                }
            }
        }

        //action when user click on one project 
        private void OnItemProjectLabel_click(object sender)
        {
            Label controler = sender as Label;
            int i = projectLabels.IndexOf(controler);
            Console.WriteLine("label " + projects[i].Name + " " + projects[i].Id);
        }
        private void OnItemProjectBouton_click(object sender)
        {
            View.RoundButton controler = sender as View.RoundButton;
            int i = roudboutonProjects.IndexOf(controler);
            Console.WriteLine("roundBouton " + projects[i].Name + " " + projects[i].Id);
        }
        private void OnItemProjectPic_click(object sender)
        {
            PictureBox controler = sender as PictureBox;
            int i = ProjectPictureBoxs.IndexOf(controler);
            Console.WriteLine("pic " + projects[i].Name + " " + projects[i].Id);
        }
        private void ProjectLabel1_Click(object sender, EventArgs e){OnItemProjectLabel_click(sender);}
        private void ProjectRoundButton1_Click(object sender, EventArgs e){OnItemProjectBouton_click(sender);}
        private void ProjectPictureBox1_Click(object sender, EventArgs e){OnItemProjectPic_click(sender);}
        private void ProjectPictureBox2_Click(object sender, EventArgs e){OnItemProjectPic_click(sender);}
        private void ProjectRoundButton2_Click(object sender, EventArgs e){OnItemProjectBouton_click(sender);}
        private void ProjectLabel2_Click(object sender, EventArgs e){ OnItemProjectLabel_click(sender);}
        private void ProjectPictureBox3_Click(object sender, EventArgs e){ OnItemProjectPic_click(sender);}
        private void ProjectRoundButton3_Click(object sender, EventArgs e){OnItemProjectBouton_click(sender);}
        private void ProjectLabel3_Click(object sender, EventArgs e){OnItemProjectLabel_click(sender);}
        private void ProjectRoundButton4_Click(object sender, EventArgs e){ OnItemProjectBouton_click(sender);}
        private void ProjectPictureBox4_Click(object sender, EventArgs e){OnItemProjectPic_click(sender);}
        private void ProjectLabel4_Click(object sender, EventArgs e){OnItemProjectLabel_click(sender);}

        //action when user click on one sprint
        private void OnItemSprintLabel_click(object sender)
        {
            Label controler = sender as Label;
            int i = Sprintlabels.IndexOf(controler);
            Console.WriteLine("label " + sprints[i].Name + " " + sprints[i].Id);
        }
        private void OnItemSprintBouton_click(object sender)
        {
            View.RoundButton controler = sender as View.RoundButton;
            int i = roudboutonSprints.IndexOf(controler);
            Console.WriteLine("roundBouton " + sprints[i].Name + " " + sprints[i].Id);
        }
        private void OnItemSprintPic_click(object sender)
        {
            PictureBox controler = sender as PictureBox;
            int i = SprintPictureBoxs.IndexOf(controler);
            Console.WriteLine("pic " + sprints[i].Name + " " + sprints[i].Id);
        }
        private void SprintpictureBox1_Click(object sender, EventArgs e) { OnItemSprintPic_click(sender); }
        private void SprintpictureBox2_Click(object sender, EventArgs e) { OnItemSprintPic_click(sender); }
        private void SprintpictureBox3_Click(object sender, EventArgs e) { OnItemSprintPic_click(sender); }
        private void SprintpictureBox4_Click(object sender, EventArgs e) { OnItemSprintPic_click(sender); }
        private void roundButtonSprint1_Click(object sender, EventArgs e) { OnItemSprintBouton_click(sender); }
        private void roundButtonSprint2_Click(object sender, EventArgs e) { OnItemSprintBouton_click(sender); }
        private void roundButtonSprint3_Click(object sender, EventArgs e) { OnItemSprintBouton_click(sender); }
        private void roundButtonSprint4_Click(object sender, EventArgs e) { OnItemSprintBouton_click(sender); }
        private void SprintLabel1_Click(object sender, EventArgs e) { OnItemSprintLabel_click(sender); }
        private void SprintLabel2_Click(object sender, EventArgs e) { OnItemSprintLabel_click(sender); }
        private void SprintLabel3_Click(object sender, EventArgs e) { OnItemSprintLabel_click(sender); }
        private void SprintLabel4_Click(object sender, EventArgs e) { OnItemSprintLabel_click(sender); }

        //action when user click on one Task
        private void OnItemTaskLabel_click(object sender)
        {
            Label controler = sender as Label;
            int i = tasklabels.IndexOf(controler);
            Console.WriteLine("label " + tasks[i].Name + " " + tasks[i].Id);
        }
        private void OnItemTaskBouton_click(object sender)
        {
            View.RoundButton controler = sender as View.RoundButton;
            int i = Tasksroudboutons.IndexOf(controler);
            Console.WriteLine("roundBouton " + tasks[i].Name + " " + tasks[i].Id);
        }
        private void OnItemTaskPic_click(object sender)
        {
            PictureBox controler = sender as PictureBox;
            int i = TaskPictureBoxs.IndexOf(controler);
            Console.WriteLine("pic " + tasks[i].Name + " " + tasks[i].Id);
        }
        private void Tasklabel1_Click(object sender, EventArgs e) { OnItemTaskLabel_click(sender); }
        private void Tasklabel2_Click(object sender, EventArgs e) { OnItemTaskLabel_click(sender); }
        private void Tasklabel3_Click(object sender, EventArgs e) { OnItemTaskLabel_click(sender); }
        private void Tasklabel4_Click(object sender, EventArgs e) { OnItemTaskLabel_click(sender); }
        private void TaskpictureBox1_Click(object sender, EventArgs e) { OnItemTaskPic_click(sender); }
        private void TaskpictureBox2_Click(object sender, EventArgs e) { OnItemTaskPic_click(sender); }
        private void TaskpictureBox3_Click(object sender, EventArgs e) { OnItemTaskPic_click(sender); }
        private void TaskpictureBox4_Click(object sender, EventArgs e) { OnItemTaskPic_click(sender); 
    }
        private void TaskroundButton1_Click(object sender, EventArgs e) { OnItemTaskBouton_click(sender); }
        private void TaskroundButton2_Click(object sender, EventArgs e) { OnItemTaskBouton_click(sender); }
        private void TaskroundButton3_Click(object sender, EventArgs e) { OnItemTaskBouton_click(sender); }
        private void TaskroundButton4_Click(object sender, EventArgs e) { OnItemTaskBouton_click(sender); }
    }
}