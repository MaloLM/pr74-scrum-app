namespace pr74_scrum_app.View
{   using System.Windows.Forms;
    using pr74_scrum_app.Controller;
    using pr74_scrum_app.Model;
    using System.Collections.Generic;
    partial class SprintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprintForm));
            this.todoLabel = new System.Windows.Forms.Label();
            this.todoTitlePanel = new System.Windows.Forms.Panel();
            this.todoBadge = new pr74_scrum_app.View.RoundButton();
            this.inProgressTitlePanel = new System.Windows.Forms.Panel();
            this.inProgressBadge = new pr74_scrum_app.View.RoundButton();
            this.InProgressLabel = new System.Windows.Forms.Label();
            this.inReviewTitlePanel = new System.Windows.Forms.Panel();
            this.inReviewBadge = new pr74_scrum_app.View.RoundButton();
            this.InReviewLabel = new System.Windows.Forms.Label();
            this.doneTitlePanel = new System.Windows.Forms.Panel();
            this.doneBadge = new pr74_scrum_app.View.RoundButton();
            this.doneLabel = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.MyTaskCheckBox = new System.Windows.Forms.CheckBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.allPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.highPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.lowPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.cancelSearchButton = new pr74_scrum_app.View.RoundButton();
            this.searchBarBackground = new pr74_scrum_app.View.RoundButton();
            this.separator = new pr74_scrum_app.View.Components.Separator();
            this.todoList = new pr74_scrum_app.View.ListPanel();
            this.UserStoryExemple = new System.Windows.Forms.Panel();
            this.PriorityBadgeExemple = new pr74_scrum_app.View.RoundButton();
            this.linkLabelExemple = new System.Windows.Forms.LinkLabel();
            this.doneList = new pr74_scrum_app.View.ListPanel();
            this.inReviewList = new pr74_scrum_app.View.ListPanel();
            this.inProgressList = new pr74_scrum_app.View.ListPanel();
            this.todoTitlePanel.SuspendLayout();
            this.inProgressTitlePanel.SuspendLayout();
            this.inReviewTitlePanel.SuspendLayout();
            this.doneTitlePanel.SuspendLayout();
            this.todoList.SuspendLayout();
            this.UserStoryExemple.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.todoLabel.Location = new System.Drawing.Point(68, 22);
            this.todoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(171, 44);
            this.todoLabel.TabIndex = 16;
            this.todoLabel.Text = "A FAIRE";
            // 
            // todoTitlePanel
            // 
            this.todoTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.todoTitlePanel.Controls.Add(this.todoBadge);
            this.todoTitlePanel.Controls.Add(this.todoLabel);
            this.todoTitlePanel.Location = new System.Drawing.Point(448, 316);
            this.todoTitlePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.todoTitlePanel.Name = "todoTitlePanel";
            this.todoTitlePanel.Size = new System.Drawing.Size(376, 84);
            this.todoTitlePanel.TabIndex = 17;
            // 
            // todoBadge
            // 
            this.todoBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.todoBadge.Enabled = false;
            this.todoBadge.FlatAppearance.BorderSize = 0;
            this.todoBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoBadge.ForeColor = System.Drawing.Color.White;
            this.todoBadge.Location = new System.Drawing.Point(246, 19);
            this.todoBadge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.todoBadge.Name = "todoBadge";
            this.todoBadge.Size = new System.Drawing.Size(62, 48);
            this.todoBadge.TabIndex = 2;
            this.todoBadge.Text = "1";
            this.todoBadge.UseVisualStyleBackColor = false;
            // 
            // inProgressTitlePanel
            // 
            this.inProgressTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inProgressTitlePanel.Controls.Add(this.inProgressBadge);
            this.inProgressTitlePanel.Controls.Add(this.InProgressLabel);
            this.inProgressTitlePanel.Location = new System.Drawing.Point(840, 316);
            this.inProgressTitlePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inProgressTitlePanel.Name = "inProgressTitlePanel";
            this.inProgressTitlePanel.Size = new System.Drawing.Size(376, 84);
            this.inProgressTitlePanel.TabIndex = 18;
            // 
            // inProgressBadge
            // 
            this.inProgressBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inProgressBadge.Enabled = false;
            this.inProgressBadge.FlatAppearance.BorderSize = 0;
            this.inProgressBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inProgressBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressBadge.ForeColor = System.Drawing.Color.White;
            this.inProgressBadge.Location = new System.Drawing.Point(262, 16);
            this.inProgressBadge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inProgressBadge.Name = "inProgressBadge";
            this.inProgressBadge.Size = new System.Drawing.Size(62, 48);
            this.inProgressBadge.TabIndex = 18;
            this.inProgressBadge.Text = "0";
            this.inProgressBadge.UseVisualStyleBackColor = false;
            // 
            // InProgressLabel
            // 
            this.InProgressLabel.AutoSize = true;
            this.InProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProgressLabel.Location = new System.Drawing.Point(32, 19);
            this.InProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InProgressLabel.Name = "InProgressLabel";
            this.InProgressLabel.Size = new System.Drawing.Size(223, 42);
            this.InProgressLabel.TabIndex = 16;
            this.InProgressLabel.Text = "EN COURS";
            // 
            // inReviewTitlePanel
            // 
            this.inReviewTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inReviewTitlePanel.Controls.Add(this.inReviewBadge);
            this.inReviewTitlePanel.Controls.Add(this.InReviewLabel);
            this.inReviewTitlePanel.Location = new System.Drawing.Point(1232, 316);
            this.inReviewTitlePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inReviewTitlePanel.Name = "inReviewTitlePanel";
            this.inReviewTitlePanel.Size = new System.Drawing.Size(376, 84);
            this.inReviewTitlePanel.TabIndex = 19;
            // 
            // inReviewBadge
            // 
            this.inReviewBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inReviewBadge.Enabled = false;
            this.inReviewBadge.FlatAppearance.BorderSize = 0;
            this.inReviewBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inReviewBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inReviewBadge.ForeColor = System.Drawing.Color.White;
            this.inReviewBadge.Location = new System.Drawing.Point(296, 16);
            this.inReviewBadge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inReviewBadge.Name = "inReviewBadge";
            this.inReviewBadge.Size = new System.Drawing.Size(62, 48);
            this.inReviewBadge.TabIndex = 19;
            this.inReviewBadge.Text = "0";
            this.inReviewBadge.UseVisualStyleBackColor = false;
            // 
            // InReviewLabel
            // 
            this.InReviewLabel.AutoSize = true;
            this.InReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.InReviewLabel.Location = new System.Drawing.Point(22, 19);
            this.InReviewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InReviewLabel.Name = "InReviewLabel";
            this.InReviewLabel.Size = new System.Drawing.Size(271, 44);
            this.InReviewLabel.TabIndex = 16;
            this.InReviewLabel.Text = "EN REVISION";
            // 
            // doneTitlePanel
            // 
            this.doneTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.doneTitlePanel.Controls.Add(this.doneBadge);
            this.doneTitlePanel.Controls.Add(this.doneLabel);
            this.doneTitlePanel.Location = new System.Drawing.Point(1624, 316);
            this.doneTitlePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doneTitlePanel.Name = "doneTitlePanel";
            this.doneTitlePanel.Size = new System.Drawing.Size(376, 84);
            this.doneTitlePanel.TabIndex = 19;
            // 
            // doneBadge
            // 
            this.doneBadge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.doneBadge.Enabled = false;
            this.doneBadge.FlatAppearance.BorderSize = 0;
            this.doneBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBadge.ForeColor = System.Drawing.Color.White;
            this.doneBadge.Location = new System.Drawing.Point(258, 16);
            this.doneBadge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doneBadge.Name = "doneBadge";
            this.doneBadge.Size = new System.Drawing.Size(62, 48);
            this.doneBadge.TabIndex = 20;
            this.doneBadge.Text = "0";
            this.doneBadge.UseVisualStyleBackColor = false;
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.doneLabel.Location = new System.Drawing.Point(30, 19);
            this.doneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(221, 44);
            this.doneLabel.TabIndex = 16;
            this.doneLabel.Text = "TERMINEE";
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(1024, 209);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(366, 31);
            this.searchBar.TabIndex = 21;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(846, 203);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(148, 44);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MyTaskCheckBox
            // 
            this.MyTaskCheckBox.AutoSize = true;
            this.MyTaskCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.MyTaskCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTaskCheckBox.Location = new System.Drawing.Point(1408, 209);
            this.MyTaskCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MyTaskCheckBox.Name = "MyTaskCheckBox";
            this.MyTaskCheckBox.Size = new System.Drawing.Size(190, 36);
            this.MyTaskCheckBox.TabIndex = 25;
            this.MyTaskCheckBox.Text = "Mes tâches";
            this.MyTaskCheckBox.UseVisualStyleBackColor = false;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(1610, 211);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(138, 32);
            this.priorityLabel.TabIndex = 27;
            this.priorityLabel.Text = "Priorité : ";
            // 
            // allPriorityRadioButton
            // 
            this.allPriorityRadioButton.AutoSize = true;
            this.allPriorityRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.allPriorityRadioButton.Checked = true;
            this.allPriorityRadioButton.Location = new System.Drawing.Point(1750, 197);
            this.allPriorityRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allPriorityRadioButton.Name = "allPriorityRadioButton";
            this.allPriorityRadioButton.Size = new System.Drawing.Size(109, 29);
            this.allPriorityRadioButton.TabIndex = 28;
            this.allPriorityRadioButton.TabStop = true;
            this.allPriorityRadioButton.Text = "Toutes";
            this.allPriorityRadioButton.UseVisualStyleBackColor = false;
            // 
            // highPriorityRadioButton
            // 
            this.highPriorityRadioButton.AutoSize = true;
            this.highPriorityRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.highPriorityRadioButton.Location = new System.Drawing.Point(1750, 228);
            this.highPriorityRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.highPriorityRadioButton.Name = "highPriorityRadioButton";
            this.highPriorityRadioButton.Size = new System.Drawing.Size(88, 29);
            this.highPriorityRadioButton.TabIndex = 29;
            this.highPriorityRadioButton.Text = "Haut";
            this.highPriorityRadioButton.UseVisualStyleBackColor = false;
            // 
            // mediumPriorityRadioButton
            // 
            this.mediumPriorityRadioButton.AutoSize = true;
            this.mediumPriorityRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.mediumPriorityRadioButton.Location = new System.Drawing.Point(1864, 197);
            this.mediumPriorityRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mediumPriorityRadioButton.Name = "mediumPriorityRadioButton";
            this.mediumPriorityRadioButton.Size = new System.Drawing.Size(108, 29);
            this.mediumPriorityRadioButton.TabIndex = 30;
            this.mediumPriorityRadioButton.Text = "Moyen";
            this.mediumPriorityRadioButton.UseVisualStyleBackColor = false;
            // 
            // lowPriorityRadioButton
            // 
            this.lowPriorityRadioButton.AutoSize = true;
            this.lowPriorityRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lowPriorityRadioButton.Location = new System.Drawing.Point(1864, 231);
            this.lowPriorityRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lowPriorityRadioButton.Name = "lowPriorityRadioButton";
            this.lowPriorityRadioButton.Size = new System.Drawing.Size(80, 29);
            this.lowPriorityRadioButton.TabIndex = 31;
            this.lowPriorityRadioButton.Text = "Bas";
            this.lowPriorityRadioButton.UseVisualStyleBackColor = false;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.BackColor = System.Drawing.Color.White;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(448, 211);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(232, 66);
            this.projectNameLabel.TabIndex = 32;
            this.projectNameLabel.Text = "SprintName :";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(448, 152);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(112, 36);
            this.returnButton.TabIndex = 33;
            this.returnButton.Text = "< Retour";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.BackColor = System.Drawing.Color.Gray;
            this.archiveButton.ForeColor = System.Drawing.Color.White;
            this.archiveButton.Location = new System.Drawing.Point(570, 152);
            this.archiveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(112, 55);
            this.archiveButton.TabIndex = 34;
            this.archiveButton.Text = "Archiver";
            this.archiveButton.UseVisualStyleBackColor = false;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.BackColor = System.Drawing.Color.Red;
            this.cancelSearchButton.FlatAppearance.BorderSize = 0;
            this.cancelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchButton.ForeColor = System.Drawing.Color.White;
            this.cancelSearchButton.Location = new System.Drawing.Point(744, 202);
            this.cancelSearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(54, 52);
            this.cancelSearchButton.TabIndex = 24;
            this.cancelSearchButton.Text = "X";
            this.cancelSearchButton.UseVisualStyleBackColor = false;
            this.cancelSearchButton.Visible = false;
            this.cancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // searchBarBackground
            // 
            this.searchBarBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.searchBarBackground.Enabled = false;
            this.searchBarBackground.FlatAppearance.BorderSize = 0;
            this.searchBarBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBarBackground.ForeColor = System.Drawing.Color.White;
            this.searchBarBackground.Location = new System.Drawing.Point(804, 181);
            this.searchBarBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBarBackground.Name = "searchBarBackground";
            this.searchBarBackground.Size = new System.Drawing.Size(1194, 84);
            this.searchBarBackground.TabIndex = 23;
            this.searchBarBackground.UseVisualStyleBackColor = false;
            // 
            // separator
            // 
            this.separator.isVertical = false;
            this.separator.Location = new System.Drawing.Point(448, 272);
            this.separator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1654, 36);
            this.separator.TabIndex = 20;
            this.separator.Text = "separator1";
            this.separator.Thickness = 1;
            // 
            // todoList
            // 
            this.todoList.AllowDrop = true;
            this.todoList.AutoScroll = true;
            this.todoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.todoList.Controls.Add(this.UserStoryExemple);
            this.todoList.Cursor = System.Windows.Forms.Cursors.Default;
            this.todoList.ElementsHigh = 70;
            this.todoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoList.Location = new System.Drawing.Point(448, 397);
            this.todoList.Margin = new System.Windows.Forms.Padding(38, 39, 38, 39);
            this.todoList.Name = "todoList";
            this.todoList.Padding = new System.Windows.Forms.Padding(0, 78, 0, 0);
            this.todoList.Size = new System.Drawing.Size(376, 708);
            this.todoList.SpaceBetweenElements = 10;
            this.todoList.TabIndex = 4;
            this.todoList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragDrop);
            this.todoList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragEnter);
            // 
            // UserStoryExemple
            // 
            this.UserStoryExemple.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserStoryExemple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserStoryExemple.Controls.Add(this.PriorityBadgeExemple);
            this.UserStoryExemple.Controls.Add(this.linkLabelExemple);
            this.UserStoryExemple.Location = new System.Drawing.Point(10, 27);
            this.UserStoryExemple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserStoryExemple.Name = "UserStoryExemple";
            this.UserStoryExemple.Size = new System.Drawing.Size(354, 118);
            this.UserStoryExemple.TabIndex = 16;
            // 
            // PriorityBadgeExemple
            // 
            this.PriorityBadgeExemple.BackColor = System.Drawing.Color.LimeGreen;
            this.PriorityBadgeExemple.Enabled = false;
            this.PriorityBadgeExemple.FlatAppearance.BorderSize = 0;
            this.PriorityBadgeExemple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityBadgeExemple.ForeColor = System.Drawing.Color.White;
            this.PriorityBadgeExemple.Location = new System.Drawing.Point(4, 3);
            this.PriorityBadgeExemple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PriorityBadgeExemple.Name = "PriorityBadgeExemple";
            this.PriorityBadgeExemple.Size = new System.Drawing.Size(32, 33);
            this.PriorityBadgeExemple.TabIndex = 1;
            this.PriorityBadgeExemple.UseVisualStyleBackColor = false;
            // 
            // linkLabelExemple
            // 
            this.linkLabelExemple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelExemple.LinkColor = System.Drawing.Color.Black;
            this.linkLabelExemple.Location = new System.Drawing.Point(46, 3);
            this.linkLabelExemple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelExemple.Name = "linkLabelExemple";
            this.linkLabelExemple.Size = new System.Drawing.Size(249, 72);
            this.linkLabelExemple.TabIndex = 0;
            this.linkLabelExemple.TabStop = true;
            this.linkLabelExemple.Text = "voila commennt ça marche le multiline ooo";
            this.linkLabelExemple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelExemple.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserStory_Click);
            // 
            // doneList
            // 
            this.doneList.AllowDrop = true;
            this.doneList.AutoScroll = true;
            this.doneList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.doneList.ElementsHigh = 70;
            this.doneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneList.Location = new System.Drawing.Point(1624, 397);
            this.doneList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doneList.Name = "doneList";
            this.doneList.Size = new System.Drawing.Size(376, 708);
            this.doneList.SpaceBetweenElements = 10;
            this.doneList.TabIndex = 15;
            this.doneList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragDrop);
            this.doneList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragEnter);
            // 
            // inReviewList
            // 
            this.inReviewList.AllowDrop = true;
            this.inReviewList.AutoScroll = true;
            this.inReviewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inReviewList.ElementsHigh = 70;
            this.inReviewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inReviewList.Location = new System.Drawing.Point(1232, 397);
            this.inReviewList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inReviewList.Name = "inReviewList";
            this.inReviewList.Size = new System.Drawing.Size(376, 708);
            this.inReviewList.SpaceBetweenElements = 10;
            this.inReviewList.TabIndex = 14;
            this.inReviewList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragDrop);
            this.inReviewList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragEnter);
            // 
            // inProgressList
            // 
            this.inProgressList.AllowDrop = true;
            this.inProgressList.AutoScroll = true;
            this.inProgressList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.inProgressList.ElementsHigh = 70;
            this.inProgressList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressList.Location = new System.Drawing.Point(840, 397);
            this.inProgressList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inProgressList.Name = "inProgressList";
            this.inProgressList.Size = new System.Drawing.Size(376, 708);
            this.inProgressList.SpaceBetweenElements = 10;
            this.inProgressList.TabIndex = 13;
            this.inProgressList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragDrop);
            this.inProgressList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListPanel_DragEnter);
            // 
            // SprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2022, 1127);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.lowPriorityRadioButton);
            this.Controls.Add(this.mediumPriorityRadioButton);
            this.Controls.Add(this.highPriorityRadioButton);
            this.Controls.Add(this.allPriorityRadioButton);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.MyTaskCheckBox);
            this.Controls.Add(this.cancelSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchBarBackground);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.doneTitlePanel);
            this.Controls.Add(this.inReviewTitlePanel);
            this.Controls.Add(this.inProgressTitlePanel);
            this.Controls.Add(this.todoTitlePanel);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.doneList);
            this.Controls.Add(this.inReviewList);
            this.Controls.Add(this.inProgressList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprint View";
            this.todoTitlePanel.ResumeLayout(false);
            this.todoTitlePanel.PerformLayout();
            this.inProgressTitlePanel.ResumeLayout(false);
            this.inProgressTitlePanel.PerformLayout();
            this.inReviewTitlePanel.ResumeLayout(false);
            this.inReviewTitlePanel.PerformLayout();
            this.doneTitlePanel.ResumeLayout(false);
            this.doneTitlePanel.PerformLayout();
            this.todoList.ResumeLayout(false);
            this.UserStoryExemple.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ListPanel inProgressList;
        private ListPanel inReviewList;
        private ListPanel doneList;
        private ListPanel todoList;
        private Panel UserStoryExemple;
        private LinkLabel linkLabelExemple;
        private RoundButton PriorityBadgeExemple;
        private Label todoLabel;
        private Panel todoTitlePanel;
        private Panel inProgressTitlePanel;
        private Label InProgressLabel;
        private Panel inReviewTitlePanel;
        private Label InReviewLabel;
        private Panel doneTitlePanel;
        private Label doneLabel;
        private RoundButton todoBadge;
        private RoundButton inProgressBadge;
        private RoundButton inReviewBadge;
        private RoundButton doneBadge;
        private Components.Separator separator;
        private TextBox searchBar;
        private Button searchButton;
        private RoundButton searchBarBackground;
        private RoundButton cancelSearchButton;
        private CheckBox MyTaskCheckBox;
        private Label priorityLabel;
        private RadioButton allPriorityRadioButton;
        private RadioButton highPriorityRadioButton;
        private RadioButton mediumPriorityRadioButton;
        private RadioButton lowPriorityRadioButton;
        private Label projectNameLabel;
        private Button returnButton;
        private Button archiveButton;
    }
}