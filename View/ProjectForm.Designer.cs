namespace pr74_scrum_app
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addToSprintsButton = new System.Windows.Forms.Button();
            this.addToBacklogButton = new System.Windows.Forms.Button();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.membersIcon = new System.Windows.Forms.PictureBox();
            this.sprintsIcon = new System.Windows.Forms.PictureBox();
            this.backlogIcon = new System.Windows.Forms.PictureBox();
            this.projectDescription = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.sprintsLabel = new System.Windows.Forms.Label();
            this.membersLabel = new System.Windows.Forms.Label();
            this.backlogLabel = new System.Windows.Forms.Label();
            this.searchBarComboBox = new System.Windows.Forms.ComboBox();
            this.addToMembersButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.backlogNoneLabel = new System.Windows.Forms.Label();
            this.sprintsNoneLabel = new System.Windows.Forms.Label();
            this.membersNoneLabel = new System.Windows.Forms.Label();
            this.archiveProjectButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.separator = new pr74_scrum_app.View.Components.Separator();
            this.membersList = new pr74_scrum_app.View.ListPanel();
            this.exempleMembre = new pr74_scrum_app.View.RoundButton();
            this.sprintsList = new pr74_scrum_app.View.ListPanel();
            this.exempleSprint = new pr74_scrum_app.View.RoundButton();
            this.backlogList = new pr74_scrum_app.View.ListPanel();
            this.exempleUserStory = new pr74_scrum_app.View.RoundButton();
            this.ProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogIcon)).BeginInit();
            this.membersList.SuspendLayout();
            this.sprintsList.SuspendLayout();
            this.backlogList.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToSprintsButton
            // 
            this.addToSprintsButton.Location = new System.Drawing.Point(836, 231);
            this.addToSprintsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addToSprintsButton.Name = "addToSprintsButton";
            this.addToSprintsButton.Size = new System.Drawing.Size(116, 42);
            this.addToSprintsButton.TabIndex = 15;
            this.addToSprintsButton.Text = "+ Ajouter";
            this.addToSprintsButton.UseVisualStyleBackColor = true;
            this.addToSprintsButton.Click += new System.EventHandler(this.addToSprintsButton_Click);
            // 
            // addToBacklogButton
            // 
            this.addToBacklogButton.Location = new System.Drawing.Point(327, 228);
            this.addToBacklogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addToBacklogButton.Name = "addToBacklogButton";
            this.addToBacklogButton.Size = new System.Drawing.Size(116, 42);
            this.addToBacklogButton.TabIndex = 12;
            this.addToBacklogButton.Text = "+ Ajouter";
            this.addToBacklogButton.UseVisualStyleBackColor = true;
            this.addToBacklogButton.Click += new System.EventHandler(this.addToBacklogButton_Click);
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectPanel.Controls.Add(this.membersIcon);
            this.ProjectPanel.Controls.Add(this.sprintsIcon);
            this.ProjectPanel.Controls.Add(this.backlogIcon);
            this.ProjectPanel.Controls.Add(this.separator);
            this.ProjectPanel.Controls.Add(this.membersList);
            this.ProjectPanel.Controls.Add(this.sprintsList);
            this.ProjectPanel.Controls.Add(this.backlogList);
            this.ProjectPanel.Controls.Add(this.projectDescription);
            this.ProjectPanel.Controls.Add(this.projectNameLabel);
            this.ProjectPanel.Controls.Add(this.sprintsLabel);
            this.ProjectPanel.Controls.Add(this.membersLabel);
            this.ProjectPanel.Controls.Add(this.backlogLabel);
            this.ProjectPanel.Controls.Add(this.searchBarComboBox);
            this.ProjectPanel.Controls.Add(this.addToMembersButton);
            this.ProjectPanel.Controls.Add(this.addToSprintsButton);
            this.ProjectPanel.Controls.Add(this.addToBacklogButton);
            this.ProjectPanel.Controls.Add(this.searchTextBox);
            this.ProjectPanel.Controls.Add(this.backlogNoneLabel);
            this.ProjectPanel.Controls.Add(this.sprintsNoneLabel);
            this.ProjectPanel.Controls.Add(this.membersNoneLabel);
            this.ProjectPanel.Controls.Add(this.archiveProjectButton);
            this.ProjectPanel.Location = new System.Drawing.Point(448, 238);
            this.ProjectPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(1556, 872);
            this.ProjectPanel.TabIndex = 16;
            // 
            // membersIcon
            // 
            this.membersIcon.Location = new System.Drawing.Point(1124, 242);
            this.membersIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.membersIcon.Name = "membersIcon";
            this.membersIcon.Size = new System.Drawing.Size(30, 33);
            this.membersIcon.TabIndex = 31;
            this.membersIcon.TabStop = false;
            // 
            // sprintsIcon
            // 
            this.sprintsIcon.Location = new System.Drawing.Point(594, 242);
            this.sprintsIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprintsIcon.Name = "sprintsIcon";
            this.sprintsIcon.Size = new System.Drawing.Size(30, 33);
            this.sprintsIcon.TabIndex = 29;
            this.sprintsIcon.TabStop = false;
            // 
            // backlogIcon
            // 
            this.backlogIcon.Location = new System.Drawing.Point(86, 238);
            this.backlogIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backlogIcon.Name = "backlogIcon";
            this.backlogIcon.Size = new System.Drawing.Size(30, 33);
            this.backlogIcon.TabIndex = 2;
            this.backlogIcon.TabStop = false;
            // 
            // projectDescription
            // 
            this.projectDescription.BackColor = System.Drawing.Color.White;
            this.projectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectDescription.Location = new System.Drawing.Point(44, 91);
            this.projectDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.projectDescription.Multiline = true;
            this.projectDescription.Name = "projectDescription";
            this.projectDescription.ReadOnly = true;
            this.projectDescription.Size = new System.Drawing.Size(938, 94);
            this.projectDescription.TabIndex = 25;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(36, 27);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(362, 45);
            this.projectNameLabel.TabIndex = 24;
            this.projectNameLabel.Text = "Nom du projet";
            // 
            // sprintsLabel
            // 
            this.sprintsLabel.AutoSize = true;
            this.sprintsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintsLabel.Location = new System.Drawing.Point(630, 239);
            this.sprintsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sprintsLabel.Name = "sprintsLabel";
            this.sprintsLabel.Size = new System.Drawing.Size(124, 37);
            this.sprintsLabel.TabIndex = 23;
            this.sprintsLabel.Text = "Sprints";
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLabel.Location = new System.Drawing.Point(1149, 239);
            this.membersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(156, 37);
            this.membersLabel.TabIndex = 22;
            this.membersLabel.Text = "Membres";
            // 
            // backlogLabel
            // 
            this.backlogLabel.AutoSize = true;
            this.backlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogLabel.Location = new System.Drawing.Point(114, 236);
            this.backlogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backlogLabel.Name = "backlogLabel";
            this.backlogLabel.Size = new System.Drawing.Size(138, 37);
            this.backlogLabel.TabIndex = 21;
            this.backlogLabel.Text = "Backlog";
            // 
            // searchBarComboBox
            // 
            this.searchBarComboBox.Enabled = false;
            this.searchBarComboBox.FormattingEnabled = true;
            this.searchBarComboBox.Items.AddRange(new object[] {
            "Backlog",
            "Sprints",
            "Membres"});
            this.searchBarComboBox.Location = new System.Drawing.Point(1144, 38);
            this.searchBarComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBarComboBox.Name = "searchBarComboBox";
            this.searchBarComboBox.Size = new System.Drawing.Size(120, 33);
            this.searchBarComboBox.TabIndex = 20;
            // 
            // addToMembersButton
            // 
            this.addToMembersButton.Location = new System.Drawing.Point(1362, 228);
            this.addToMembersButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addToMembersButton.Name = "addToMembersButton";
            this.addToMembersButton.Size = new System.Drawing.Size(116, 42);
            this.addToMembersButton.TabIndex = 16;
            this.addToMembersButton.Text = "+ Ajouter";
            this.addToMembersButton.UseVisualStyleBackColor = true;
            this.addToMembersButton.Click += new System.EventHandler(this.addToMembersButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Location = new System.Drawing.Point(1270, 38);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(234, 31);
            this.searchTextBox.TabIndex = 7;
            // 
            // backlogNoneLabel
            // 
            this.backlogNoneLabel.AutoSize = true;
            this.backlogNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogNoneLabel.Location = new System.Drawing.Point(98, 323);
            this.backlogNoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backlogNoneLabel.Name = "backlogNoneLabel";
            this.backlogNoneLabel.Size = new System.Drawing.Size(250, 33);
            this.backlogNoneLabel.TabIndex = 1;
            this.backlogNoneLabel.Text = "Aucune user story";
            // 
            // sprintsNoneLabel
            // 
            this.sprintsNoneLabel.AutoSize = true;
            this.sprintsNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintsNoneLabel.Location = new System.Drawing.Point(692, 323);
            this.sprintsNoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sprintsNoneLabel.Name = "sprintsNoneLabel";
            this.sprintsNoneLabel.Size = new System.Drawing.Size(177, 33);
            this.sprintsNoneLabel.TabIndex = 2;
            this.sprintsNoneLabel.Text = "Aucun sprint";
            // 
            // membersNoneLabel
            // 
            this.membersNoneLabel.AutoSize = true;
            this.membersNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersNoneLabel.Location = new System.Drawing.Point(1244, 323);
            this.membersNoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.membersNoneLabel.Name = "membersNoneLabel";
            this.membersNoneLabel.Size = new System.Drawing.Size(213, 33);
            this.membersNoneLabel.TabIndex = 3;
            this.membersNoneLabel.Text = "Aucun membre";
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.BackColor = System.Drawing.Color.Gray;
            this.archiveProjectButton.ForeColor = System.Drawing.Color.White;
            this.archiveProjectButton.Location = new System.Drawing.Point(406, 31);
            this.archiveProjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(132, 47);
            this.archiveProjectButton.TabIndex = 8;
            this.archiveProjectButton.Text = "Archiver";
            this.archiveProjectButton.UseVisualStyleBackColor = false;
            this.archiveProjectButton.Click += new System.EventHandler(this.archiveProjectButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(452, 194);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(112, 36);
            this.returnButton.TabIndex = 32;
            this.returnButton.Text = "< Retour";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.White;
            this.separator.isVertical = false;
            this.separator.Location = new System.Drawing.Point(40, 195);
            this.separator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1466, 36);
            this.separator.TabIndex = 17;
            this.separator.Text = "separator";
            this.separator.Thickness = 1;
            // 
            // membersList
            // 
            this.membersList.AutoScroll = true;
            this.membersList.Controls.Add(this.exempleMembre);
            this.membersList.ElementsHigh = 40;
            this.membersList.Location = new System.Drawing.Point(1120, 281);
            this.membersList.Margin = new System.Windows.Forms.Padding(6);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(357, 562);
            this.membersList.SpaceBetweenElements = 20;
            this.membersList.TabIndex = 28;
            // 
            // exempleMembre
            // 
            this.exempleMembre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.exempleMembre.FlatAppearance.BorderSize = 0;
            this.exempleMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exempleMembre.ForeColor = System.Drawing.Color.Black;
            this.exempleMembre.Location = new System.Drawing.Point(9, 31);
            this.exempleMembre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exempleMembre.Name = "exempleMembre";
            this.exempleMembre.Size = new System.Drawing.Size(344, 62);
            this.exempleMembre.TabIndex = 3;
            this.exempleMembre.Text = "exemple membre";
            this.exempleMembre.UseVisualStyleBackColor = false;
            // 
            // sprintsList
            // 
            this.sprintsList.AutoScroll = true;
            this.sprintsList.Controls.Add(this.exempleSprint);
            this.sprintsList.ElementsHigh = 40;
            this.sprintsList.Location = new System.Drawing.Point(594, 281);
            this.sprintsList.Margin = new System.Windows.Forms.Padding(6);
            this.sprintsList.Name = "sprintsList";
            this.sprintsList.Size = new System.Drawing.Size(357, 562);
            this.sprintsList.SpaceBetweenElements = 20;
            this.sprintsList.TabIndex = 28;
            // 
            // exempleSprint
            // 
            this.exempleSprint.BackColor = System.Drawing.Color.LightSlateGray;
            this.exempleSprint.FlatAppearance.BorderSize = 0;
            this.exempleSprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exempleSprint.ForeColor = System.Drawing.Color.White;
            this.exempleSprint.Location = new System.Drawing.Point(9, 31);
            this.exempleSprint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exempleSprint.Name = "exempleSprint";
            this.exempleSprint.Size = new System.Drawing.Size(344, 62);
            this.exempleSprint.TabIndex = 2;
            this.exempleSprint.Text = "exemple de sprint";
            this.exempleSprint.UseVisualStyleBackColor = false;
            // 
            // backlogList
            // 
            this.backlogList.AutoScroll = true;
            this.backlogList.Controls.Add(this.exempleUserStory);
            this.backlogList.ElementsHigh = 40;
            this.backlogList.Location = new System.Drawing.Point(86, 281);
            this.backlogList.Margin = new System.Windows.Forms.Padding(6);
            this.backlogList.Name = "backlogList";
            this.backlogList.Size = new System.Drawing.Size(357, 562);
            this.backlogList.SpaceBetweenElements = 20;
            this.backlogList.TabIndex = 27;
            // 
            // exempleUserStory
            // 
            this.exempleUserStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.exempleUserStory.FlatAppearance.BorderSize = 0;
            this.exempleUserStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exempleUserStory.ForeColor = System.Drawing.Color.Black;
            this.exempleUserStory.Location = new System.Drawing.Point(9, 31);
            this.exempleUserStory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exempleUserStory.Name = "exempleUserStory";
            this.exempleUserStory.Size = new System.Drawing.Size(344, 62);
            this.exempleUserStory.TabIndex = 0;
            this.exempleUserStory.Text = "exemple de user story";
            this.exempleUserStory.UseVisualStyleBackColor = false;
            this.exempleUserStory.Click += new System.EventHandler(this.UserStory_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2022, 1127);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ProjectPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectViewForm";
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogIcon)).EndInit();
            this.membersList.ResumeLayout(false);
            this.sprintsList.ResumeLayout(false);
            this.backlogList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addToSprintsButton;
        private System.Windows.Forms.Button addToBacklogButton;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Button addToMembersButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button archiveProjectButton;
        private System.Windows.Forms.ComboBox searchBarComboBox;
        private System.Windows.Forms.Label sprintsLabel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.Label backlogLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectDescription;
        private View.Components.Separator separator;
        private View.ListPanel membersList;
        private View.ListPanel sprintsList;
        private System.Windows.Forms.Label membersNoneLabel;
        private System.Windows.Forms.Label sprintsNoneLabel;
        private System.Windows.Forms.Label backlogNoneLabel;
        private View.RoundButton exempleMembre;
        private View.RoundButton exempleSprint;
        private View.ListPanel backlogList;
        private View.RoundButton exempleUserStory;
        private System.Windows.Forms.PictureBox membersIcon;
        private System.Windows.Forms.PictureBox sprintsIcon;
        private System.Windows.Forms.PictureBox backlogIcon;
        private System.Windows.Forms.Button returnButton;
    }
}