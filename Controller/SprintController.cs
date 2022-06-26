using MySql.Data.MySqlClient;
using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;

namespace pr74_scrum_app.Controller
{
    class SprintController : Controller
    {
        public SprintController() : base() {}
        public Sprint FetchSprintById(int id)
        {
            Sprint sprint = null;
            MySqlDataReader dr = Database.ExecutQuery($"select * from {SPRINTS_TABLE} where id={id}");
            while (dr.Read())
            {
                string name = (string)dr["name"];
                DateTime startDate = (DateTime)dr["startDate"];
                DateTime endDate = (DateTime)dr["endDate"];
                sprint = new Sprint(id, name, startDate, endDate);
            }
            dr.Close();

            if(sprint != null)
                sprint.Backlog = FetchSprintBacklogById(id);

            return sprint;
        }
        public SprintBacklog FetchSprintBacklogById(int sprintId)
        {
            SprintBacklog sprintBacklog = new SprintBacklog();
            UserStoryController usc = new UserStoryController();
            sprintBacklog.UserStories=usc.FetchUserStoriesBySprintId(sprintId);

            return sprintBacklog;
        }
        public bool PersistSprint(Sprint sprint, int projectId)
        {
            // start transaction
            Database.Begin();

            // persister les informations de base du sprint 
            string sql = $"" +
                $"INSERT INTO {SPRINTS_TABLE} (id, name, startDate, endDate, Project_id)" +
                $"VALUES ({sprint.Id}, '{sprint.Name}', '{sprint.StartingDate.ToString("yyyy/MM/dd")}','{sprint.EndingDate.ToString("yyyy/MM/dd")}',{projectId}) " +
                $"ON DUPLICATE KEY " +
                $"UPDATE name = '{sprint.Name}', startDate='{sprint.StartingDate.ToString("yyyy/MM/dd")}', endDate='{sprint.EndingDate.ToString("yyyy/MM/dd")}' ; ";
            MySqlDataReader dr = Database.ExecutQuery(sql);
            if (dr.RecordsAffected < 0)
            {
                dr.Close();
                Database.Rollback();
                return false;
            }

            dr.Close();

            UserStoryController usc = new UserStoryController();

            // persister les userStories
            foreach (UserStory userStory in sprint.Backlog.UserStories)
            {
                bool ok = usc.PersistUserStoryWithSprintId(userStory, sprint.Id, projectId);
                if (!ok) {
                    Database.Rollback();
                    return false; 
                }
            }
            Database.Commit();
            return true;
        }
    }
}
