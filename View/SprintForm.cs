using pr74_scrum_app.Controller;
using pr74_scrum_app.Model;
using pr74_scrum_app.View.Components;
using pr74_scrum_app.View.ProjectViewSubForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace pr74_scrum_app.View
{
    public partial class SprintForm : Form
    {
        Sprint sprint;
        Control movingUserStory;
        ListPanel listSource;
        Member member;
        
        public SprintForm(int memberId, int sprintId)
        {
            InitializeComponent();
            SprintController sprintController = new SprintController();
            UserController uc = new UserController();
            sprint = sprintController.FetchSprintById(sprintId);
            if(sprint == null)
            {
                MessageBox.Show("404 : Sprint not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            projectNameLabel.Text = sprint.Name;
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
            member = uc.GetMemberById(memberId);
            if(member.Role != "SM")
            {
                archiveButton.Visible = false;
            }

            NavBar navBar = new NavBar(member.User);
            SideBar sideBar = new SideBar(member.User);
            Controls.Add(navBar);
            Controls.Add(sideBar);
        }
        private void GenerateUserStoryPanels(List<UserStory> userStories)
        {
            ClearLists();
            foreach (UserStory us in userStories)
            {
                UserStoryPanel usp = new UserStoryPanel(us);
                usp.MouseDown += new MouseEventHandler(UserStory_MouseDown);
                usp.AddFuncToPriorityBadge(ListPanelElement_MouseDown);
                usp.AddFuncToLink(UserStory_Click);
                switch (us.State){
                    case "TODO" : todoList.Add(usp); break;
                    case "PROGRESS" : inProgressList.Add(usp); break;
                    case "REVIEW" : inReviewList.Add(usp); break;
                    case "DONE" : doneList.Add(usp); break;
                }
            }
            RefreshBadges();
        }
        private void ResetSprint()
        {
            SprintController sprintController = new SprintController();
            sprint = sprintController.FetchSprintById(sprint.Id);
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
        }
        private List<UserStory> Search(string query)
        {
            List<UserStory> selected = null;
            if (query.Length > 0)
            {
                List<UserStory> querySearch = sprint.Backlog.SearchBy(query);
                if (selected == null) selected = querySearch;
                selected = sprint.Backlog.Intersect(selected, querySearch);
            }
            if (MyTaskCheckBox.Checked) 
            {
                List<UserStory> myTasksSearch = sprint.Backlog.SearchBy(member);
                if (selected == null) selected = myTasksSearch;
                selected = sprint.Backlog.Intersect(selected, myTasksSearch);
            }
            if (GetPriorityFromRadioButtons() != 0)
            {
                List<UserStory> prioritySearch = sprint.Backlog.SearchBy(GetPriorityFromRadioButtons());
                if (selected == null) selected = prioritySearch;
                selected = sprint.Backlog.Intersect(selected, prioritySearch);
            }
            if (selected == null) selected = sprint.Backlog.UserStories;
            return selected;
        }
        private int GetPriorityFromRadioButtons()
        {
            if (highPriorityRadioButton.Checked) return 1;
            else if (mediumPriorityRadioButton.Checked) return 2;
            else if (lowPriorityRadioButton.Checked) return 3;
            else return 0;
        }
        private void ClearLists() {
            todoList.Clear();
            inProgressList.Clear();
            inReviewList.Clear();
            doneList.Clear();
        }
        private void UpdateSprint()
        {
            UserStoryController userStoryController = new UserStoryController();
            foreach (UserStoryPanel c in todoList.Controls)
            {
                c.UserStory.State = "TODO";
                userStoryController.UpdateState(c.UserStory);
            }
            foreach (UserStoryPanel c in inProgressList.Controls)
            {
                c.UserStory.State = "PROGRESS";
                userStoryController.UpdateState(c.UserStory);
            }
            foreach (UserStoryPanel c in inReviewList.Controls)
            {
                c.UserStory.State = "REVIEW";
                userStoryController.UpdateState(c.UserStory);
            }
            foreach (UserStoryPanel c in doneList.Controls)
            {
                c.UserStory.State = "DONE";
                userStoryController.UpdateState(c.UserStory);
            }
        }
        private void RefreshBadges()
        {
            todoBadge.Text = "" + todoList.Count();
            inProgressBadge.Text = "" + inProgressList.Count();
            inReviewBadge.Text = "" + inReviewList.Count();
            doneBadge.Text = "" + doneList.Count();
        }
        private bool IsSearching()
        {
            return (searchBar.Text.Length > 0) || MyTaskCheckBox.Checked || !allPriorityRadioButton.Checked;
        }
        private void UserStory_MouseDown(object sender, MouseEventArgs e)
        {
            movingUserStory = sender as Control; 
            listSource = movingUserStory.Parent as ListPanel;
            listSource.DoDragDrop(movingUserStory.Text, DragDropEffects.Move);
        }
        private void ListPanelElement_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            movingUserStory = control.Parent;
            listSource = movingUserStory.Parent as ListPanel;
            listSource.DoDragDrop(control.Text, DragDropEffects.Move);
        }
        private void ListPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void ListPanel_DragEnter(object sender, DragEventArgs e)
        {
            ListPanel actuel = sender as ListPanel;
            if (actuel != listSource)
            {
                actuel.Add(movingUserStory);
                actuel.RefreshControls();
                listSource.Remove(movingUserStory);
                listSource.RefreshControls();
                listSource = actuel;
                RefreshBadges();
                UpdateSprint();
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
            if (IsSearching())
            {
                cancelSearchButton.Visible = true;
                string query = searchBar.Text;
                GenerateUserStoryPanels(Search(query));
            }
        }
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            cancelSearchButton.Visible = false;
            searchBar.Text = "";
            allPriorityRadioButton.Checked = true;
            MyTaskCheckBox.Checked= false;
            GenerateUserStoryPanels(sprint.Backlog.UserStories);
        }
        private void UserStory_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel l = sender as LinkLabel;
            UserStoryPanel usp = l.Parent as UserStoryPanel;
            UserStoryForm usf = new UserStoryForm(usp.UserStory, member);
            usf.ShowDialog();
            ResetSprint();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            SprintController sc = new SprintController();
            ConfirmationForm cf = new ConfirmationForm("Voulez-vous vraiment archiver le sprint ? Il ne sera plus consultable après confirmation.");
            cf.ShowDialog();
            if (cf.Confirmation)
            {
                sc.ArchiverSprint(sprint);
                this.Close();
            }
        }
    }
}
