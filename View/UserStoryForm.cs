using pr74_scrum_app.Controller;
using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app.View
{
    public partial class UserStoryForm : Form
    {
        UserStory userStory;
        Member member;
        int sprintId;
        int projectId;
        string assignees = "";
        int changeAssignee = 4;
        public UserStoryForm()
        {
            InitializeComponent();
        }
     
        public UserStoryForm(UserStory us, Member m)
        {
            InitializeComponent();
            UserStoryController controller = new UserStoryController();
            this.member = m;
            this.userStory = us;
            List<int> sprintProjectId = controller.fetchSprintIdProjectIdByUserStoryId(userStory.Id);
            this.sprintId = sprintProjectId[0];
            this.projectId = sprintProjectId[1];
            if (member == null)
            {
                MessageBox.Show("404 : Le membre n'a pas été trouvé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
            }
            userStory = controller.FetchUserStoriesById(userStory.Id);
            if (userStory == null)
            {
                MessageBox.Show("404 :  La user story n'a pas été trouvé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
            }

            List<Member> projectMembers = controller.fetchMembersByProjectMock(projectId);
            Dictionary<Member, string> assigneesList = new Dictionary<Member, string>();

            foreach (Member assignee in userStory.Assignees)
            {
                string name = assignee.User.FirstName + " " + assignee.User.LastName;
                assignees += name + ", ";
            }
            assignees = assignees.Length > 2 ? assignees.Substring(0, assignees.Length - 2) : assignees; // Remove last comma
            string shortAssignees = assignees.Length > 25 ? assignees.Substring(0, 25) + ".." : assignees;

            foreach (Member member in projectMembers)
            {
                string name = member.User.FirstName + " " + member.User.LastName;
                assigneesList.Add(member, name);
            }

            listBox1.DataSource = new BindingSource(assigneesList, null);
            listBox1.DisplayMember = "Value";
            listBox1.ValueMember = "Key";
            listBox1.SelectedIndex = -1;

            label1.Text = userStory.Name;
            this.roundButton2.Text = userStory.State;
            this.roundButton3.Text = shortAssignees;
            this.comboBox1.SelectedIndex = 3 - userStory.Priority;
            setPriorityImage(userStory.Priority);
            this.textBox3.Text = userStory.Complexity.ToString();
            this.textBox4.Text = userStory.Description;
            generateCommentList(userStory.Comments);
        }
        private void roundButton3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(roundButton3, assignees);
        }
        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void setPriorityImage(int priority)
        {
            if (priority == 1)
            {
                this.pictureBox2.Image = Image.FromFile("../../Ressources/low_priority.ico");
            }
            else if (priority == 2)
            {
                this.pictureBox2.Image = Image.FromFile("../../Ressources/medium_priority.ico");
            }
            else
            {
                this.pictureBox2.Image = Image.FromFile("../../Ressources/high_priority.ico");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            userStory.Complexity = int.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            userStory.Description = textBox4.Text;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            UserStoryController controller = new UserStoryController();
            controller.PersistUserStoryWithSprintId(userStory, sprintId, projectId);
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List< Member > listAssignees = new List < Member >();
            if (changeAssignee < 1)
            {
                foreach (KeyValuePair<Member, string> m in listBox1.SelectedItems)
                {
                    listAssignees.Add(m.Key);
                }
                userStory.Assignees = listAssignees;
            }
            else
            {
                changeAssignee --;
            }
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible)
                listBox1.Hide();
            else
                listBox1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 3 - comboBox1.SelectedIndex;
            setPriorityImage(index);
            userStory.Priority = index;
        }

        private void generateCommentList(List<Comment> comments)
        {
            int addY = 0;
            for (int i = 0; i < comments.Count(); i++)
            {
                int nbLine = comments.ElementAt(i).Content.Split('\n').Length;
                
                //Add project name
                Label name = new Label();
                name.Text = String.Format("{0}", comments.ElementAt(i).ByMember.User.FirstName + " " + comments.ElementAt(i).ByMember.User.LastName);
                name.Left = 0;
                name.Top = 0 + i * 60 + addY;
                name.BackColor = Color.Transparent;

                RoundButton roundButton = new RoundButton();
                roundButton.Left = 0;
                roundButton.Top = 13 + i * 60 + addY;
                roundButton.Size = new Size(280, 25 + nbLine * 11);
                roundButton.BackColor = Color.FromArgb(234, 239, 242);
                roundButton.Enabled = false;

                Label text = new Label();
                text.Text = String.Format("{0}", comments.ElementAt(i).Content);
                text.Left = 10;
                text.Top = 23 + i * 60 + addY;
                text.Size = new Size(260, 5 + nbLine * 11);
                text.BackColor = Color.FromArgb(234, 239, 242);
                //text.Multiline = true;
                text.BorderStyle = BorderStyle.None;

                Label date = new Label();
                date.Text = String.Format("{0}", comments.ElementAt(i).Date);
                date.Left = 200;
                date.Top = 40 + i * 60 + addY + nbLine * 11;
                date.BackColor = Color.Transparent;

                addY += 11 * nbLine;


                //Add controls to form
                panel1.Controls.Add(text);
                panel1.Controls.Add(roundButton);
                panel1.Controls.Add(name);
                panel1.Controls.Add(date);
            }

        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            UserStoryController controller = new UserStoryController();
            Comment newComment = new Comment(0, textBox1.Text, member);
            controller.PersistComment(newComment, userStory.Id);
            this.Hide();
            UserStoryForm mp = new UserStoryForm(userStory, member);
            mp.ShowDialog();
        }
    }
}
