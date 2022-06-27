using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app.View.ProjectViewSubForms
{
    public partial class ConfirmationForm : Form
    {
        private bool confirmation = false ;
        public ConfirmationForm(string text)
        {
            InitializeComponent();
            Message.Text = text;

        }
        private void ConfirmForm_Click(object sender, EventArgs e)
        {
            confirmation = true;
            this.Close();
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            confirmation = false;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool Confirmation { get { return confirmation; } }
    }
}
