namespace pr74_scrum_app
{
    partial class AddNewSprintForm
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
            this.StartingDateLabel = new System.Windows.Forms.Label();
            this.sprintNameLabel = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.Label();
            this.sprintNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelForm = new System.Windows.Forms.Button();
            this.ConfirmForm = new System.Windows.Forms.Button();
            this.startingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndingDateLabel = new System.Windows.Forms.Label();
            this.endingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.erreurLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartingDateLabel
            // 
            this.StartingDateLabel.AutoSize = true;
            this.StartingDateLabel.Location = new System.Drawing.Point(67, 127);
            this.StartingDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartingDateLabel.Name = "StartingDateLabel";
            this.StartingDateLabel.Size = new System.Drawing.Size(75, 13);
            this.StartingDateLabel.TabIndex = 19;
            this.StartingDateLabel.Text = "Date de début";
            // 
            // sprintNameLabel
            // 
            this.sprintNameLabel.AutoSize = true;
            this.sprintNameLabel.Location = new System.Drawing.Point(67, 68);
            this.sprintNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sprintNameLabel.Name = "sprintNameLabel";
            this.sprintNameLabel.Size = new System.Drawing.Size(72, 13);
            this.sprintNameLabel.TabIndex = 18;
            this.sprintNameLabel.Text = "Nom du sprint";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Location = new System.Drawing.Point(108, 28);
            this.formTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(79, 13);
            this.formTitle.TabIndex = 17;
            this.formTitle.Text = "Nouveau sprint";
            // 
            // sprintNameTextBox
            // 
            this.sprintNameTextBox.Location = new System.Drawing.Point(64, 87);
            this.sprintNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sprintNameTextBox.Name = "sprintNameTextBox";
            this.sprintNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.sprintNameTextBox.TabIndex = 16;
            // 
            // cancelForm
            // 
            this.cancelForm.Location = new System.Drawing.Point(193, 256);
            this.cancelForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.Size = new System.Drawing.Size(58, 29);
            this.cancelForm.TabIndex = 15;
            this.cancelForm.Text = "Cancel";
            this.cancelForm.UseVisualStyleBackColor = true;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // ConfirmForm
            // 
            this.ConfirmForm.BackColor = System.Drawing.Color.SteelBlue;
            this.ConfirmForm.ForeColor = System.Drawing.Color.White;
            this.ConfirmForm.Location = new System.Drawing.Point(262, 256);
            this.ConfirmForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmForm.Name = "ConfirmForm";
            this.ConfirmForm.Size = new System.Drawing.Size(58, 29);
            this.ConfirmForm.TabIndex = 14;
            this.ConfirmForm.Text = "Ajouter";
            this.ConfirmForm.UseVisualStyleBackColor = false;
            this.ConfirmForm.Click += new System.EventHandler(this.ConfirmForm_Click);
            // 
            // startingDateTimePicker
            // 
            this.startingDateTimePicker.CustomFormat = "";
            this.startingDateTimePicker.Location = new System.Drawing.Point(64, 147);
            this.startingDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startingDateTimePicker.MinDate = new System.DateTime(2022, 6, 18, 15, 1, 8, 0);
            this.startingDateTimePicker.Name = "startingDateTimePicker";
            this.startingDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.startingDateTimePicker.TabIndex = 21;
            this.startingDateTimePicker.Value = new System.DateTime(2022, 6, 18, 15, 1, 8, 0);
            // 
            // EndingDateLabel
            // 
            this.EndingDateLabel.AutoSize = true;
            this.EndingDateLabel.Location = new System.Drawing.Point(67, 188);
            this.EndingDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndingDateLabel.Name = "EndingDateLabel";
            this.EndingDateLabel.Size = new System.Drawing.Size(59, 13);
            this.EndingDateLabel.TabIndex = 22;
            this.EndingDateLabel.Text = "Date de fin";
            // 
            // endingDateTimePicker
            // 
            this.endingDateTimePicker.Location = new System.Drawing.Point(64, 210);
            this.endingDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endingDateTimePicker.MinDate = new System.DateTime(2022, 6, 18, 15, 1, 8, 0);
            this.endingDateTimePicker.Name = "endingDateTimePicker";
            this.endingDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.endingDateTimePicker.TabIndex = 23;
            this.endingDateTimePicker.Value = new System.DateTime(2022, 6, 18, 15, 1, 8, 0);
            // 
            // erreurLabel
            // 
            this.erreurLabel.AutoSize = true;
            this.erreurLabel.BackColor = System.Drawing.Color.White;
            this.erreurLabel.ForeColor = System.Drawing.Color.Red;
            this.erreurLabel.Location = new System.Drawing.Point(39, 236);
            this.erreurLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurLabel.Name = "erreurLabel";
            this.erreurLabel.Size = new System.Drawing.Size(88, 13);
            this.erreurLabel.TabIndex = 24;
            this.erreurLabel.Text = "Message d\'erreur";
            this.erreurLabel.Visible = false;
            // 
            // AddNewSprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 308);
            this.Controls.Add(this.erreurLabel);
            this.Controls.Add(this.endingDateTimePicker);
            this.Controls.Add(this.EndingDateLabel);
            this.Controls.Add(this.startingDateTimePicker);
            this.Controls.Add(this.StartingDateLabel);
            this.Controls.Add(this.sprintNameLabel);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.sprintNameTextBox);
            this.Controls.Add(this.cancelForm);
            this.Controls.Add(this.ConfirmForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewSprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un sprint au projet";
            this.Load += new System.EventHandler(this.AddNewSprintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StartingDateLabel;
        private System.Windows.Forms.Label sprintNameLabel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TextBox sprintNameTextBox;
        private System.Windows.Forms.Button cancelForm;
        private System.Windows.Forms.Button ConfirmForm;
        private System.Windows.Forms.DateTimePicker startingDateTimePicker;
        private System.Windows.Forms.Label EndingDateLabel;
        private System.Windows.Forms.DateTimePicker endingDateTimePicker;
        private System.Windows.Forms.Label erreurLabel;
    }
}