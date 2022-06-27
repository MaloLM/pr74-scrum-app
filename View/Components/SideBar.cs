using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pr74_scrum_app.View.Components
{
    internal class SideBar : Panel
    {
        private User user;
        private Label SideBarLabel;
        public Dictionary<int, string> pinnedProjects;
        public Dictionary<int, string> myProjects;
        private int currentProjectId; 

        public SideBar(User user)
        {
            this.user = user;
            RefreshProjects();
            InitializeComponent();

            //Add pinned project list
            GenerateProjectList( pinnedProjects, 55, "../../Ressources/pin.ico");

            //Add Separator
            Separator sep = new Separator();
            sep.Size = new Size(180, 20);
            sep.Left = 0;
            sep.Top = pinnedProjects.Count() * 30 + 100;
            Controls.Add(sep);

            //Add Title
            Label project = new Label();
            project.Text = "Autre projets";
            project.Left = 5;
            project.Font = SideBarLabel.Font;
            project.Size = new Size(160, 20);
            project.Top = pinnedProjects.Count() * 30 + 130;
            Controls.Add(project);

            //Add other projects list
            GenerateProjectList(myProjects, pinnedProjects.Count() * 30 + 140, "../../Ressources/proj.ico");
        }
        private void InitializeComponent()
        {  
            SideBarLabel = new Label();
            SuspendLayout();
            //SuspendLayout();
            // 
            // sideBarPanel
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            Controls.Add(this.SideBarLabel);
            Location = new System.Drawing.Point(0, 70);
            Margin = new Padding(3, 2, 3, 2);
            Name = "sideBarPanel";
            Size = new System.Drawing.Size(180, 635);
            TabIndex = 25;
            // 
            // SideBarLabel
            // 
            SideBarLabel.AutoSize = true;
            SideBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            SideBarLabel.Location = new System.Drawing.Point(7, 45);
            SideBarLabel.Name = "SideBarLabel";
            SideBarLabel.Size = new System.Drawing.Size(180, 24);
            SideBarLabel.TabIndex = 26;
            SideBarLabel.Text = "Projets épinglés";

            //this.sideBarPanel.ResumeLayout(false);
            //this.sideBarPanel.PerformLayout();

        }
        public int CurrentProjectId { get { return currentProjectId; } set { currentProjectId = value; } }
        public void RefreshProjects()
        {
            SidebarController controller = new SidebarController();
            pinnedProjects = controller.GetProjects(user.Id, true);
            myProjects = controller.GetProjects(user.Id, false);
        }
        private void GenerateProjectList(Dictionary<int, string> projects,int top, string imgLink)
        {
            for (int i = 0; i < projects.Count(); i++)
            {
                //Add icon
                PictureBox pictureBox = new PictureBox();
                pictureBox.Load(imgLink);
                pictureBox.Size = new Size(20, 20);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Left = 10;
                pictureBox.Top = top - 3 + (i + 1) * 30;

                //Add project name
                LinkLabel label = new LinkLabel();
                label.Text = String.Format("{0}", projects.Values.ElementAt(i));
                label.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                label.LinkColor = Color.FromArgb(0, 0, 0);//(R, G, B) (0, 0, 0 = black) System.Drawing.Color.Black;
                label.Left = 35;
                label.Top = top + (i + 1) * 30;
                int projectID = projects.Keys.ElementAt(i);
                //Add click event to send to project page
                label.Click += (sender, EventArgs) => { GoToProject(sender, EventArgs, projectID); };


                //Add controls to form
                Controls.Add(label);
                Controls.Add(pictureBox);

            }
        }
        private void GoToProject(object sender, EventArgs e, int projectID)
        {
            if(projectID != currentProjectId)
            {
                Parent.Hide();
                currentProjectId = projectID;
                ProjectForm home = new ProjectForm(projectID, user.Id);
                home.ShowDialog();
                Parent.Show();
            }
        }
    }
}
