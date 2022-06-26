
namespace pr74_scrum_app
{
    partial class CreatePojetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePojetForm));
            this.CreationProjetLabel = new System.Windows.Forms.Label();
            this.NomduProjetLabel = new System.Windows.Forms.Label();
            this.NameProjetText = new System.Windows.Forms.TextBox();
            this.CreateValidedButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TailleDescriptionLabel = new System.Windows.Forms.Label();
            this.MaxnameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreationProjetLabel
            // 
            this.CreationProjetLabel.AutoSize = true;
            this.CreationProjetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationProjetLabel.Location = new System.Drawing.Point(141, 10);
            this.CreationProjetLabel.Name = "CreationProjetLabel";
            this.CreationProjetLabel.Size = new System.Drawing.Size(242, 29);
            this.CreationProjetLabel.TabIndex = 26;
            this.CreationProjetLabel.Text = "Création d\'un projet";
            // 
            // NomduProjetLabel
            // 
            this.NomduProjetLabel.AutoSize = true;
            this.NomduProjetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomduProjetLabel.Location = new System.Drawing.Point(132, 63);
            this.NomduProjetLabel.Name = "NomduProjetLabel";
            this.NomduProjetLabel.Size = new System.Drawing.Size(53, 20);
            this.NomduProjetLabel.TabIndex = 25;
            this.NomduProjetLabel.Text = "Nom ";
            // 
            // NameProjetText
            // 
            this.NameProjetText.Location = new System.Drawing.Point(135, 87);
            this.NameProjetText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameProjetText.Name = "NameProjetText";
            this.NameProjetText.Size = new System.Drawing.Size(265, 22);
            this.NameProjetText.TabIndex = 24;
            // 
            // CreateValidedButton
            // 
            this.CreateValidedButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CreateValidedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.CreateValidedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateValidedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateValidedButton.Location = new System.Drawing.Point(183, 252);
            this.CreateValidedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateValidedButton.Name = "CreateValidedButton";
            this.CreateValidedButton.Size = new System.Drawing.Size(140, 30);
            this.CreateValidedButton.TabIndex = 27;
            this.CreateValidedButton.Text = "Valider ";
            this.CreateValidedButton.UseVisualStyleBackColor = true;
            this.CreateValidedButton.Click += new System.EventHandler(this.CreateValidedButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(159, 227);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(199, 17);
            this.ErrorLabel.TabIndex = 28;
            this.ErrorLabel.Text = "Veillez remplir tout les champs";
            this.ErrorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(135, 150);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(265, 58);
            this.DescriptionTextBox.TabIndex = 29;
            // 
            // TailleDescriptionLabel
            // 
            this.TailleDescriptionLabel.AutoSize = true;
            this.TailleDescriptionLabel.ForeColor = System.Drawing.Color.Red;
            this.TailleDescriptionLabel.Location = new System.Drawing.Point(88, 211);
            this.TailleDescriptionLabel.Name = "TailleDescriptionLabel";
            this.TailleDescriptionLabel.Size = new System.Drawing.Size(333, 17);
            this.TailleDescriptionLabel.TabIndex = 31;
            this.TailleDescriptionLabel.Text = "La description ne doit pas depasser 250 caractères";
            this.TailleDescriptionLabel.Visible = false;
            // 
            // MaxnameLabel
            // 
            this.MaxnameLabel.AutoSize = true;
            this.MaxnameLabel.ForeColor = System.Drawing.Color.Red;
            this.MaxnameLabel.Location = new System.Drawing.Point(177, 112);
            this.MaxnameLabel.Name = "MaxnameLabel";
            this.MaxnameLabel.Size = new System.Drawing.Size(192, 17);
            this.MaxnameLabel.TabIndex = 32;
            this.MaxnameLabel.Text = "Taille Maximun 30 caractères";
            this.MaxnameLabel.Visible = false;
            // 
            // CreatePojetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 306);
            this.Controls.Add(this.MaxnameLabel);
            this.Controls.Add(this.TailleDescriptionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CreateValidedButton);
            this.Controls.Add(this.CreationProjetLabel);
            this.Controls.Add(this.NomduProjetLabel);
            this.Controls.Add(this.NameProjetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatePojetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreationProjetLabel;
        private System.Windows.Forms.Label NomduProjetLabel;
        private System.Windows.Forms.TextBox NameProjetText;
        private System.Windows.Forms.Button CreateValidedButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label TailleDescriptionLabel;
        private System.Windows.Forms.Label MaxnameLabel;
    }
}