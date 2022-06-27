namespace pr74_scrum_app
{
    partial class AddNewMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMemberForm));
            this.roleSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.Label();
            this.memberEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.cancelForm = new System.Windows.Forms.Button();
            this.ConfirmForm = new System.Windows.Forms.Button();
            this.erreurLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roleSelectionComboBox
            // 
            this.roleSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleSelectionComboBox.FormattingEnabled = true;
            this.roleSelectionComboBox.Items.AddRange(new object[] {
            resources.GetString("roleSelectionComboBox.Items"),
            resources.GetString("roleSelectionComboBox.Items1"),
            resources.GetString("roleSelectionComboBox.Items2")});
            resources.ApplyResources(this.roleSelectionComboBox, "roleSelectionComboBox");
            this.roleSelectionComboBox.Name = "roleSelectionComboBox";
            // 
            // RoleLabel
            // 
            resources.ApplyResources(this.RoleLabel, "RoleLabel");
            this.RoleLabel.Name = "RoleLabel";
            // 
            // emailAddressLabel
            // 
            resources.ApplyResources(this.emailAddressLabel, "emailAddressLabel");
            this.emailAddressLabel.Name = "emailAddressLabel";
            // 
            // formTitle
            // 
            resources.ApplyResources(this.formTitle, "formTitle");
            this.formTitle.Name = "formTitle";
            // 
            // memberEmailAddressTextBox
            // 
            resources.ApplyResources(this.memberEmailAddressTextBox, "memberEmailAddressTextBox");
            this.memberEmailAddressTextBox.Name = "memberEmailAddressTextBox";
            // 
            // cancelForm
            // 
            resources.ApplyResources(this.cancelForm, "cancelForm");
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.UseVisualStyleBackColor = true;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // ConfirmForm
            // 
            this.ConfirmForm.BackColor = System.Drawing.Color.SteelBlue;
            this.ConfirmForm.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ConfirmForm, "ConfirmForm");
            this.ConfirmForm.Name = "ConfirmForm";
            this.ConfirmForm.UseVisualStyleBackColor = false;
            this.ConfirmForm.Click += new System.EventHandler(this.ConfirmForm_Click);
            // 
            // erreurLabel
            // 
            resources.ApplyResources(this.erreurLabel, "erreurLabel");
            this.erreurLabel.BackColor = System.Drawing.Color.White;
            this.erreurLabel.ForeColor = System.Drawing.Color.Red;
            this.erreurLabel.Name = "erreurLabel";
            // 
            // AddNewMemberForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.erreurLabel);
            this.Controls.Add(this.roleSelectionComboBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.memberEmailAddressTextBox);
            this.Controls.Add(this.cancelForm);
            this.Controls.Add(this.ConfirmForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roleSelectionComboBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TextBox memberEmailAddressTextBox;
        private System.Windows.Forms.Button cancelForm;
        private System.Windows.Forms.Button ConfirmForm;
        private System.Windows.Forms.Label erreurLabel;
    }
}