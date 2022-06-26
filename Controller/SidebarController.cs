using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace pr74_scrum_app
{
    class SidebarController
    {
        private readonly Database db = new Database();


        //Method to get pinned or non pinned projects for a user
        //Return Dictionary of (projectID, projectName)
        public Dictionary<int,string> GetProjects(int userID, bool pinned)
        {
            Dictionary<int, string> projects = new Dictionary<int, string>();
            string sql = $"select * from Member m inner join Project p on m.Project_id = p.id where m.pinned = {pinned} and user_id='{userID}' order by p.id DESC LIMIT 5";
            MySqlDataReader dr = db.ExecutQuery(sql);
            if (dr.HasRows)  while (dr.Read()) projects.Add((int)dr["Project_id"], (string)dr["name"]);
            dr.Close();

            return projects;
        }


    }

}
