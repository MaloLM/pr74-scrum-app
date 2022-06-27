using System;
using System.Windows.Forms;

namespace pr74_scrum_app.View.Components
{
    class NavBar : Panel
    {
        private PictureBox NavBarPictureBox;
        private ListBox ProfilListBox = new ListBox();

        private User user;

        public NavBar(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            NavBarPictureBox = new PictureBox();
            SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(NavBarPictureBox)).BeginInit();
            // 
            // NavBarPanel
            // 
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(NavBarPictureBox);
            Location = new System.Drawing.Point(-8, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NavBarPanel";
            //Size = new System.Drawing.Size(1135, 75);
            Size = new System.Drawing.Size(1135, 94);
            TabIndex = 24;
            // 
            // NavBarPanel Background
            // 
            Panel navBackPanel = new Panel();
            navBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(93)))), ((int)(((byte)(128)))));
            navBackPanel.Location = new System.Drawing.Point(-8, 0);
            navBackPanel.Margin = new Padding(3, 2, 3, 2);
            navBackPanel.Size = new System.Drawing.Size(1135, 75);
            navBackPanel.TabIndex = 100;// 
            // Sidebar Background
            // 
            Panel sidebarPanel = new Panel();
            sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            sidebarPanel.Location = new System.Drawing.Point(-8, 0);
            sidebarPanel.Margin = new Padding(3, 2, 3, 2);
            sidebarPanel.Size = new System.Drawing.Size(196, 95);
            sidebarPanel.TabIndex = 101;
            // 
            // NavBarPictureBox
            // 
            NavBarPictureBox.BackColor = System.Drawing.Color.Transparent;
            NavBarPictureBox.Load("../../Ressources/logoScrum.ico");
            //NavBarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("../../Ressources/logoScrum.ico")));
            NavBarPictureBox.Location = new System.Drawing.Point(21, 4);
            NavBarPictureBox.Margin = new Padding(4);
            NavBarPictureBox.Name = "NavBarPictureBox";
            NavBarPictureBox.Size = new System.Drawing.Size(140, 70);
            NavBarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NavBarPictureBox.TabIndex = 8;
            NavBarPictureBox.TabStop = false;


            RoundButton UserEmailRoundButton = new RoundButton();
            UserEmailRoundButton.BackColor = System.Drawing.Color.White;
            UserEmailRoundButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            UserEmailRoundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            UserEmailRoundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            UserEmailRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            UserEmailRoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UserEmailRoundButton.ForeColor = System.Drawing.Color.Black;
            UserEmailRoundButton.Location = new System.Drawing.Point(768, 20);
            UserEmailRoundButton.Margin = new System.Windows.Forms.Padding(2);
            UserEmailRoundButton.Name = "UserEmailRoundButton";
            UserEmailRoundButton.Size = new System.Drawing.Size(204, 34);
            UserEmailRoundButton.TabIndex = 10;
            UserEmailRoundButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            UserEmailRoundButton.UseVisualStyleBackColor = false;
            UserEmailRoundButton.Text = user.Email;

            PictureBox PictureProfilBox = new PictureBox();
            PictureProfilBox.BackColor = System.Drawing.Color.Transparent;
            PictureProfilBox.Load("../../Ressources/imgProfil.ico");
            PictureProfilBox.Location = new System.Drawing.Point(980, 25);
            PictureProfilBox.Name = "PictureProfilBox";
            PictureProfilBox.TabIndex = 8;
            PictureProfilBox.Size = new System.Drawing.Size(24, 28);
            PictureProfilBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProfilBox.TabStop = false;
            PictureProfilBox.Click += new System.EventHandler(this.PictureProfilBox_Click);
            //PictureProfilBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureProfilBox.Image")));


            ProfilListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ProfilListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ProfilListBox.FormattingEnabled = true;
            ProfilListBox.ItemHeight = 17;
            ProfilListBox.Items.AddRange(new object[] {
            "Mon profil",
            "Déconnexion"});
            ProfilListBox.Location = new System.Drawing.Point(911, 60);
            ProfilListBox.Margin = new System.Windows.Forms.Padding(2);
            ProfilListBox.Name = "ProfilListBox";
            ProfilListBox.Size = new System.Drawing.Size(97, 34);
            ProfilListBox.TabIndex = 10;
            ProfilListBox.Visible = false;
            ProfilListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(ProfilListBox_MouseClick);
            ProfilListBox.MouseLeave += new System.EventHandler(ProfilListBox_MouseLeave);
            ProfilListBox.MouseHover += new System.EventHandler(ProfilListBox_MouseHover);

            this.Controls.Add(PictureProfilBox);
            this.Controls.Add(UserEmailRoundButton);
            this.Controls.Add(ProfilListBox);
            this.Controls.Add(navBackPanel);
            this.Controls.Add(sidebarPanel);


            ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(NavBarPictureBox)).EndInit();
        }
        private void ProfilListBox_MouseHover(object sender, EventArgs e)
        {
            ProfilListBox.Visible = true;
        }

        private void ProfilListBox_MouseLeave(object sender, EventArgs e)
        {
            ProfilListBox.Visible = false;
        }

        //if i click on an item proffil list box i ave 2 choices
        private void ProfilListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProfilListBox.SelectedItem != null)
            {
                if (ProfilListBox.SelectedItem.ToString() == "Mon profil")
                {
                    UpdateInfos update = new UpdateInfos(user);
                    update.ShowDialog();
                }
                if (ProfilListBox.SelectedItem.ToString() == "Déconnexion")
                {
                    MessageBoxButtons conf = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnection", conf);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        foreach (Form oForm in Application.OpenForms)
                        {
                            if (oForm is HomeForm)
                            {
                                oForm.Show();
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void PictureProfilBox_Click(object sender, EventArgs e)
        {
            ProfilListBox.Visible = true;
        }

    }
}
