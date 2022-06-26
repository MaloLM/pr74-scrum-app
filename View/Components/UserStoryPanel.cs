using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app.View
{
    class UserStoryPanel : Panel
    {
        private LinkLabel  content;
        private RoundButton priorityBadge;
        private UserStory userStory;
        public UserStoryPanel(UserStory userStory) {
            this.userStory = userStory;
            InitBackground();
            InitContentLabel();
            Controls.Add(content);
            InitPriorityBadge();
            Controls.Add(priorityBadge);

        }
        public void AddFuncForChilds(Action<object, MouseEventArgs> f)
        {
            foreach(Control c in Controls) c.MouseDown += new MouseEventHandler(f);
        }
        public void AddFuncToPriorityBadge(Action<object, MouseEventArgs> f)
        {
            priorityBadge.MouseDown += new MouseEventHandler(f);
        }
        public void AddFuncToLink(Action<object, LinkLabelLinkClickedEventArgs> f)
        {
            content.LinkClicked += new LinkLabelLinkClickedEventHandler(f);
        }
        public UserStory UserStory { get { return userStory; } }
        public void InitBackground()
        {
            BackColor = System.Drawing.Color.WhiteSmoke;
            BorderStyle = BorderStyle.FixedSingle;
            Name = "UserStory_"+userStory.Id;
            TabIndex = 16;
        }
        public void InitContentLabel()
        {
            content = new LinkLabel();
            content.LinkBehavior = LinkBehavior.NeverUnderline;
            content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            content.LinkColor = System.Drawing.Color.Black;
            content.Location = new System.Drawing.Point(31, 3);
            content.Name = "userStory_"+userStory.Id;
            content.Size = new System.Drawing.Size(140, 45);
            content.TabIndex = 0;
            content.TabStop = true;
            content.Text = userStory.Name;
        }
        public void InitPriorityBadge()
        {
            priorityBadge = new RoundButton();
            priorityBadge.BackColor = getPriorityColor();
            priorityBadge.Enabled = false;
            priorityBadge.FlatAppearance.BorderSize = 0;
            priorityBadge.FlatStyle = FlatStyle.Flat;
            priorityBadge.ForeColor = System.Drawing.Color.White;
            priorityBadge.Location = new System.Drawing.Point(3, 3);
            priorityBadge.Name = "priority_"+userStory.Id;
            priorityBadge.Size = new System.Drawing.Size(22, 21);
            priorityBadge.TabIndex = 1;
            priorityBadge.UseVisualStyleBackColor = false;
        }

        public System.Drawing.Color getPriorityColor()
        {
            switch (userStory.Priority) {
                case 1: return System.Drawing.Color.Red;
                case 2: return System.Drawing.Color.Yellow;
                case 3: return System.Drawing.Color.Green;
                default: return System.Drawing.Color.Gray;
            }
        }

    }
}
