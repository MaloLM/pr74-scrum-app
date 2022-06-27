namespace pr74_scrum_app
{
    partial class ArchiveProjectConfirmationForm
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
            this.cancelForm = new System.Windows.Forms.Button();
            this.ConfirmForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelForm
            // 
            this.cancelForm.Location = new System.Drawing.Point(226, 57);
            this.cancelForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.Size = new System.Drawing.Size(58, 29);
            this.cancelForm.TabIndex = 20;
            this.cancelForm.Text = "Annuler";
            this.cancelForm.UseVisualStyleBackColor = true;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // ConfirmForm
            // 
            this.ConfirmForm.BackColor = System.Drawing.Color.SteelBlue;
            this.ConfirmForm.ForeColor = System.Drawing.Color.White;
            this.ConfirmForm.Location = new System.Drawing.Point(296, 57);
            this.ConfirmForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmForm.Name = "ConfirmForm";
            this.ConfirmForm.Size = new System.Drawing.Size(76, 29);
            this.ConfirmForm.TabIndex = 19;
            this.ConfirmForm.Text = "Confirmer";
            this.ConfirmForm.UseVisualStyleBackColor = false;
            this.ConfirmForm.Click += new System.EventHandler(this.ConfirmForm_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Voulez-vous vraiment archiver le projet ? Il ne sera plus consultable après confi" +
    "rmation.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ArchiveProjectConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 98);
            this.Controls.Add(this.cancelForm);
            this.Controls.Add(this.ConfirmForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArchiveProjectConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive de projet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelForm;
        private System.Windows.Forms.Button ConfirmForm;
        private System.Windows.Forms.Label label1;
    }
}