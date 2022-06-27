using pr74_scrum_app.Model;
using pr74_scrum_app.View;
using pr74_scrum_app.View.Components;
using pr74_scrum_app.View.ProjectViewSubForms;
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
    public partial class ProjectForm : Form
    {

        Controller.ProjectController pc = new Controller.ProjectController();

        private int projectId;
        private int userId;
        private Project project;
        private Member member;
        SideBar sideBar;
        NavBar navBar;

        public ProjectForm(int currentProjectId, int currentUserId)
        {
            this.projectId = currentProjectId;
            this.userId = currentUserId; 
            this.project = pc.FetchProjectById(this.projectId);
            this.member = pc.FetchMember(this.projectId, this.userId);
            
            InitializeComponent();
            projectNameLabel.Text = this.project.Name;
            projectDescription.Text = this.project.Description;
            archiveProjectButton.Visible = false;
            addToBacklogButton.Visible = false;
            addToMembersButton.Visible = false;
            addToSprintsButton.Visible = false;

            if (member.Role == "SM" || member.Role == "PO")
            {
                archiveProjectButton.Visible = true;
                addToBacklogButton.Visible = true;
                addToMembersButton.Visible = true;
                addToSprintsButton.Visible = true;
            }
            sideBar = new SideBar(member.User);
            sideBar.CurrentProjectId = project.Id;
            navBar = new NavBar(member.User);
            Controls.Add(sideBar);
            Controls.Add(navBar);
            generateButtonsForLists();
        }
        private void fetchData()
        {
            this.project = pc.FetchProjectById(this.projectId);
            this.member = pc.FetchMember(this.projectId, this.userId);
        }

        private void generateButtonsForLists()
        {
            clearLists();
            // generate user stories
            foreach (UserStory us in project.Backlog.UserStories) {
                RoundButton rb = generateRoundButton();
                rb.Text = us.Name;
                rb.Name = "" + us.Id;
                rb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
                rb.ForeColor = System.Drawing.Color.Black;
                rb.Click += new EventHandler(this.UserStory_Click);
                this.backlogList.Add(rb);
            }
            // generate sprints
            foreach (Sprint sp in project.Sprints)
            {
                RoundButton rb = generateRoundButton();
                rb.Text = sp.Name;
                rb.Name = "" + sp.Id;
                rb.BackColor = System.Drawing.Color.LightSlateGray;
                rb.Click += new EventHandler(this.Sprint_Click);
                this.sprintsList.Add(rb);
            }
            // generate members
            foreach (Member m in project.Members)
            {
                if(m.Id != member.Id)
                {
                    RoundButton rb = generateRoundButton();
                    rb.Text = m.User.FirstName[0] + "."+ m.User.LastName + " - "+m.getFullRole();
                    rb.Name = ""+m.User.Id;
                    rb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
                    rb.ForeColor = System.Drawing.Color.Black;
                    rb.Click += new EventHandler(this.Member_Click);
                    this.membersList.Add(rb);
                }
            }
            checkNone();
        }
        private void checkNone()
        {
            backlogList.Visible = backlogList.Count() > 0;
            sprintsList.Visible = sprintsList.Count() > 0;
            membersList.Visible = membersList.Count() > 0;
        }
        private void clearLists()
        {
            membersList.Clear();
            sprintsList.Clear();
            backlogList.Clear();
        }
        private void refreshForm()
        {
            fetchData();
            generateButtonsForLists();
            Controls.Remove(sideBar);
            Controls.Remove(navBar);
            sideBar = new SideBar(member.User);
            sideBar.CurrentProjectId = project.Id;
            navBar = new NavBar(member.User);
            Controls.Add(sideBar);
            Controls.Add(navBar);

        }

        private RoundButton generateRoundButton()
        {
            RoundButton roundButton = new RoundButton();
            roundButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            roundButton.FlatAppearance.BorderSize = 0;
            roundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            roundButton.ForeColor = System.Drawing.Color.White;
            roundButton.Location = new System.Drawing.Point(6, 20);
            roundButton.Size = new System.Drawing.Size(229, 40);
            roundButton.TabIndex = 0;
            roundButton.UseVisualStyleBackColor = false;

            return roundButton;
        }
        private void addToMembersButton_Click(object sender, EventArgs e)
        {
            AddNewMemberForm form = new AddNewMemberForm(this.projectId);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.ShowDialog();
            refreshForm();
        }

        private void addToSprintsButton_Click(object sender, EventArgs e)
        {
            AddNewSprintForm form = new AddNewSprintForm(this.projectId);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.ShowDialog();
            refreshForm();
        }

        private void addToBacklogButton_Click(object sender, EventArgs e)
        {
            AddFeatureToBacklogForm form = new AddFeatureToBacklogForm(this.projectId);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.ShowDialog();
            refreshForm();
        }

        private void archiveProjectButton_Click(object sender, EventArgs e)
        {
            ArchiveProjectConfirmationForm form = new ArchiveProjectConfirmationForm(this.projectId);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.ShowDialog();
            refreshForm();
        }

        private void UserStory_Click(object sender, EventArgs e)
        {
            RoundButton rb = sender as RoundButton;
            int id = int.Parse(rb.Name);
            UserStoryForm usf = new UserStoryForm(getUserStoryFromList(id), member);
            usf.FormBorderStyle = FormBorderStyle.FixedDialog;
            usf.SizeGripStyle = SizeGripStyle.Hide;
            this.Hide();
            usf.ShowDialog();
            refreshForm();
            this.Show();  
        }
        private UserStory getUserStoryFromList(int id)
        {
            foreach(UserStory us in project.Backlog.UserStories) if(us.Id == id) return us;
            return null;
        }
        private void Sprint_Click(object sender, EventArgs e)
        {
            RoundButton rb = sender as RoundButton;
            int id = int.Parse(rb.Name);
            SprintForm sf = new SprintForm(member.Id, id);
            sf.FormBorderStyle = FormBorderStyle.FixedDialog;
            sf.SizeGripStyle = SizeGripStyle.Hide;
            this.Hide();
            sf.ShowDialog();
            refreshForm();
            this.Show();
        }
        private void Member_Click(object sender, EventArgs e)
        {
            RoundButton rb = sender as RoundButton;
            int id = int.Parse(rb.Name);
            DisplayMemberInfo mf = new DisplayMemberInfo(id, project.Id);
            mf.FormBorderStyle = FormBorderStyle.FixedDialog;
            mf.SizeGripStyle = SizeGripStyle.Hide;
            mf.ShowDialog();
            refreshForm();
            this.Show();
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
