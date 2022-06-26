using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database db = new Database();
            db.Connect();

            Fixtures fixtures = new Fixtures();
            // fixtures.CreateUsers();
            // fixtures.CreateProjects();
            // fixtures.CreateMembers();
            // fixtures.CreateSprints();
            // fixtures.createUserStories();
            fixtures.createUserStoryComments();
            fixtures.createUserStoryMembers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
