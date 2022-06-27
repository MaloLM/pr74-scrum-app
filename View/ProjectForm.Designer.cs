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
            this.separator = new pr74_scrum_app.View.Components.Separator();
            this.membersList = new pr74_scrum_app.View.ListPanel();
            this.exempleMembre = new pr74_scrum_app.View.RoundButton();
            this.sprintsList = new pr74_scrum_app.View.ListPanel();
            this.exempleSprint = new pr74_scrum_app.View.RoundButton();
            this.backlogList = new pr74_scrum_app.View.ListPanel();
            this.exempleUserStory = new pr74_scrum_app.View.RoundButton();
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
            this.addToSprintsButton.Location = new System.Drawing.Point(557, 148);
            this.addToSprintsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToSprintsButton.Name = "addToSprintsButton";
            this.addToSprintsButton.Size = new System.Drawing.Size(77, 27);
            this.addToSprintsButton.TabIndex = 15;
            this.addToSprintsButton.Text = "+ Ajouter";
            this.addToSprintsButton.UseVisualStyleBackColor = true;
            this.addToSprintsButton.Click += new System.EventHandler(this.addToSprintsButton_Click);
            // 
            // addToBacklogButton
            // 
            this.addToBacklogButton.Location = new System.Drawing.Point(218, 146);
            this.addToBacklogButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToBacklogButton.Name = "addToBacklogButton";
            this.addToBacklogButton.Size = new System.Drawing.Size(77, 27);
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
            this.ProjectPanel.Location = new System.Drawing.Point(299, 152);
            this.ProjectPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(1037, 558);
            this.ProjectPanel.TabIndex = 16;
            // 
            // membersIcon
            // 
            this.membersIcon.Location = new System.Drawing.Point(749, 155);
            this.membersIcon.Name = "membersIcon";
            this.membersIcon.Size = new System.Drawing.Size(20, 21);
            this.membersIcon.TabIndex = 31;
            this.membersIcon.TabStop = false;
            // 
            // sprintsIcon
            // 
            this.sprintsIcon.Location = new System.Drawing.Point(396, 155);
            this.sprintsIcon.Name = "sprintsIcon";
            this.sprintsIcon.Size = new System.Drawing.Size(20, 21);
            this.sprintsIcon.TabIndex = 29;
            this.sprintsIcon.TabStop = false;
            // 
            // backlogIcon
            // 
            this.backlogIcon.Location = new System.Drawing.Point(57, 152);
            this.backlogIcon.Name = "backlogIcon";
            this.backlogIcon.Size = new System.Drawing.Size(20, 21);
            this.backlogIcon.TabIndex = 2;
            this.backlogIcon.TabStop = false;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.White;
            this.separator.isVertical = false;
            this.separator.Location = new System.Drawing.Point(27, 125);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(977, 23);
            this.separator.TabIndex = 17;
            this.separator.Text = "separator";
            this.separator.Thickness = 1;
            // 
            // membersList
            // 
            this.membersList.AutoScroll = true;
            this.membersList.Controls.Add(this.exempleMembre);
            this.membersList.ElementsHigh = 40;
            this.membersList.Location = new System.Drawing.Point(747, 180);
            this.membersList.Margin = new System.Windows.Forms.Padding(4);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(238, 360);
            this.membersList.SpaceBetweenElements = 20;
            this.membersList.TabIndex = 28;
            // 
            // exempleMembre
            // 
            this.exempleMembre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.exempleMembre.FlatAppearance.BorderSize = 0;
            this.exempleMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exempleMembre.ForeColor = System.Drawing.Color.Black;
            this.exempleMembre.Location = new System.Drawing.Point(6, 20);
            this.exempleMembre.Name = "exempleMembre";
            this.exempleMembre.Size = new System.Drawing.Size(229, 40);
            this.exempleMembre.TabIndex = 3;
            this.exempleMembre.Text = "exemple membre";
            this.exempleMembre.UseVisualStyleBackColor = false;
            // 
            // sprintsList
            // 
            this.sprintsList.AutoScroll = true;
            this.sprintsList.Controls.Add(this.exempleSprint);
            this.sprintsList.ElementsHigh = 40;
            this.sprintsList.Location = new System.Drawing.Point(396, 180);
            this.sprintsList.Margin = new System.Windows.Forms.Padding(4);
            this.sprintsList.Name = "sprintsList";
            this.sprintsList.Size = new System.Drawing.Size(238, 360);
            this.sprintsList.SpaceBetweenElements = 20;
            this.sprintsList.TabIndex = 28;
            // 
            // exempleSprint
            // 
            this.exempleSprint.BackColor = System.Drawing.Color.LightSlateGray;
            this.exempleSprint.FlatAppearance.BorderSize = 0;
            this.exempleSprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exempleSprint.ForeColor = System.Drawing.Color.White;
            this.exempleSprint.Location = new System.Drawing.Point(6, 20);
            this.exempleSprint.Name = "exempleSprint";
            this.exempleSprint.Size = new System.Drawing.Size(229, 40);
            this.exempleSprint.TabIndex = 2;
            this.exempleSprint.Text = "exemple de sprint";
            this.exempleSprint.UseVisualStyleBackColor = false;
            // 
            // backlogList
            // 
            this.backlogList.AutoScroll = true;
            this.backlogList.Controls.Add(this.exempleUserStory);
            this.backlogList.ElementsHigh = 40;
            this.backlogList.Location = new System.Drawing.Point(57, 180);
            this.backlogList.Margin = new System.Windows.Forms.Padding(4);
            this.backlogList.Name = "backlogList";
            this.backlogList.Size = new System.Drawing.Size(238, 360);
            this.backlogList.SpaceBetweenElements = 20;
            this.backlogList.TabIndex = 27;
            // 
            // exempleUserStory
            // 
            this.exempleUserStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.exempleUserStory.FlatAppearance.BorderSize = 0;
            this.exempleUserStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exempleUserStory.ForeColor = System.Drawing.Color.Black;
            this.exempleUserStory.Location = new System.Drawing.Point(6, 20);
            this.exempleUserStory.Name = "exempleUserStory";
            this.exempleUserStory.Size = new System.Drawing.Size(229, 40);
            this.exempleUserStory.TabIndex = 0;
            this.exempleUserStory.Text = "exemple de user story";
            this.exempleUserStory.UseVisualStyleBackColor = false;
            this.exempleUserStory.Click += new System.EventHandler(this.UserStory_Click);
            // 
            // projectDescription
            // 
            this.projectDescription.BackColor = System.Drawing.Color.White;
            this.projectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectDescription.Location = new System.Drawing.Point(29, 58);
            this.projectDescription.Margin = new System.Windows.Forms.Padding(4);
            this.projectDescription.Multiline = true;
            this.projectDescription.Name = "projectDescription";
            this.projectDescription.ReadOnly = true;
            this.projectDescription.Size = new System.Drawing.Size(625, 60);
            this.projectDescription.TabIndex = 25;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(24, 17);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(241, 29);
            this.projectNameLabel.TabIndex = 24;
            this.projectNameLabel.Text = "Nom du projet";
            // 
            // sprintsLabel
            // 
            this.sprintsLabel.AutoSize = true;
            this.sprintsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintsLabel.Location = new System.Drawing.Point(420, 153);
            this.sprintsLabel.Name = "sprintsLabel";
            this.sprintsLabel.Size = new System.Drawing.Size(80, 25);
            this.sprintsLabel.TabIndex = 23;
            this.sprintsLabel.Text = "Sprints";
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLabel.Location = new System.Drawing.Point(766, 153);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(101, 25);
            this.membersLabel.TabIndex = 22;
            this.membersLabel.Text = "Membres";
            // 
            // backlogLabel
            // 
            this.backlogLabel.AutoSize = true;
            this.backlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogLabel.Location = new System.Drawing.Point(76, 151);
            this.backlogLabel.Name = "backlogLabel";
            this.backlogLabel.Size = new System.Drawing.Size(89, 25);
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
            this.searchBarComboBox.Location = new System.Drawing.Point(763, 24);
            this.searchBarComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBarComboBox.Name = "searchBarComboBox";
            this.searchBarComboBox.Size = new System.Drawing.Size(81, 24);
            this.searchBarComboBox.TabIndex = 20;
            // 
            // addToMembersButton
            // 
            this.addToMembersButton.Location = new System.Drawing.Point(908, 146);
            this.addToMembersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToMembersButton.Name = "addToMembersButton";
            this.addToMembersButton.Size = new System.Drawing.Size(77, 27);
            this.addToMembersButton.TabIndex = 16;
            this.addToMembersButton.Text = "+ Ajouter";
            this.addToMembersButton.UseVisualStyleBackColor = true;
            this.addToMembersButton.Click += new System.EventHandler(this.addToMembersButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Location = new System.Drawing.Point(847, 24);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(157, 22);
            this.searchTextBox.TabIndex = 7;
            // 
            // backlogNoneLabel
            // 
            this.backlogNoneLabel.AutoSize = true;
            this.backlogNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogNoneLabel.Location = new System.Drawing.Point(65, 207);
            this.backlogNoneLabel.Name = "backlogNoneLabel";
            this.backlogNoneLabel.Size = new System.Drawing.Size(155, 22);
            this.backlogNoneLabel.TabIndex = 1;
            this.backlogNoneLabel.Text = "Aucune user story";
            // 
            // sprintsNoneLabel
            // 
            this.sprintsNoneLabel.AutoSize = true;
            this.sprintsNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintsNoneLabel.Location = new System.Drawing.Point(461, 207);
            this.sprintsNoneLabel.Name = "sprintsNoneLabel";
            this.sprintsNoneLabel.Size = new System.Drawing.Size(110, 22);
            this.sprintsNoneLabel.TabIndex = 2;
            this.sprintsNoneLabel.Text = "Aucun sprint";
            // 
            // membersNoneLabel
            // 
            this.membersNoneLabel.AutoSize = true;
            this.membersNoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersNoneLabel.Location = new System.Drawing.Point(829, 207);
            this.membersNoneLabel.Name = "membersNoneLabel";
            this.membersNoneLabel.Size = new System.Drawing.Size(130, 22);
            this.membersNoneLabel.TabIndex = 3;
            this.membersNoneLabel.Text = "Aucun membre";
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.BackColor = System.Drawing.Color.Gray;
            this.archiveProjectButton.ForeColor = System.Drawing.Color.White;
            this.archiveProjectButton.Location = new System.Drawing.Point(271, 20);
            this.archiveProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(88, 30);
            this.archiveProjectButton.TabIndex = 8;
            this.archiveProjectButton.Text = "Archiver";
            this.archiveProjectButton.UseVisualStyleBackColor = false;
            this.archiveProjectButton.Click += new System.EventHandler(this.archiveProjectButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(301, 124);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 32;
            this.returnButton.Text = "< Retour";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ProjectPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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