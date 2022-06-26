using System.Windows.Forms;

namespace pr74_scrum_app.View.Components
{
    class NavBar : Panel
    {
        private PictureBox NavBarPictureBox;
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
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(93)))), ((int)(((byte)(128)))));
            Controls.Add(NavBarPictureBox);
            Location = new System.Drawing.Point(-8, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NavBarPanel";
            Size = new System.Drawing.Size(1363, 90);
            TabIndex = 24;
            // 
            // NavBarPictureBox
            // 
            NavBarPictureBox.BackColor = System.Drawing.Color.Transparent;
            NavBarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NavBarPictureBox.Image"))); ;
            NavBarPictureBox.Location = new System.Drawing.Point(21, 4);
            NavBarPictureBox.Margin = new Padding(4);
            NavBarPictureBox.Name = "NavBarPictureBox";
            NavBarPictureBox.Size = new System.Drawing.Size(168, 84);
            NavBarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NavBarPictureBox.TabIndex = 8;
            NavBarPictureBox.TabStop = false;

            ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(NavBarPictureBox)).EndInit();
        }

    }
}
