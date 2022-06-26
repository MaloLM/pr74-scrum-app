using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Controller
{
    class Controller
    {
        private Database database;
        protected readonly string COMMENTS_TABLE = "userstorycomment";
        protected readonly string ASSIGNEES_TABLE = "userstorymember";
        protected readonly string SPRINTS_TABLE = "sprint";
        protected readonly string MEMBERS_TABLE = "member";
        protected readonly string USER_STORIES_TABLE = "userstory";

        public Controller()
        {
            database = new Database();
        }
        public int GenerateNewId(string tableName)
        {
            int id = -1;
            MySqlDataReader dr = database.ExecutQuery($"select id from {tableName} order by id DESC limit 1");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id = (int)dr["id"];
                    id++;
                }
            }
            else id = 1;
            
            dr.Close();

            return id;
        }
        public Database Database { get { return database; } }
    }
}
