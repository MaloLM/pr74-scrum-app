using MySql.Data.MySqlClient;
using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Controller
{
    class UserStoryController : Controller
    {
        public UserStoryController(): base() {}
        public List<UserStory> FetchUserStoriesBySprintId(int sprintId)
        {
            List<UserStory> userStories = new List<UserStory>();
            // Fetching the userStories basic infos
            MySqlDataReader dr = Database.ExecutQuery($"select * from userstory where sprint_id={sprintId}");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["name"];
                    string description = (string)dr["description"];
                    int complexity = (int)dr["complexity"];
                    int priotity = (int)dr["priority"];
                    string state = (string)dr["state"];
                    UserStory userStory = new UserStory(id, name, state);
                    userStory.Priority = priotity;
                    userStory.Complexity = complexity;
                    userStory.Description = description;
                    userStories.Add(userStory);
                }
            }
            dr.Close();

            foreach (UserStory userStory in userStories)
            {
                // Fetching userStories comments
                userStory.Comments = FetchUserStoryComments(userStory.Id);

                // Fetching userStories assignees
                userStory.Assignees = FetchUserStoryAssignees(userStory.Id);
            }

            return userStories;
        }
        public UserStory FetchUserStoriesById(int id)
        {
            UserStory userStory = null;
            // Fetching the userStories basic infos
            MySqlDataReader dr = Database.ExecutQuery($"select * from userstory where id={id}");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string name = (string)dr["name"];
                    string description = (string)dr["description"];
                    int complexity = (int)dr["complexity"];
                    int priotity = (int)dr["priority"];
                    string state = (string)dr["state"];
                    userStory = new UserStory(id, name, state);
                    userStory.Priority = priotity;
                    userStory.Complexity = complexity;
                    userStory.Description = description;
                }
            }
            dr.Close();

            // Fetching userStories comments
            userStory.Comments = FetchUserStoryComments(userStory.Id);

            // Fetching userStories assignees
            userStory.Assignees = FetchUserStoryAssignees(userStory.Id);

            return userStory;
        }

        public List<UserStory> FetchUserStoriesByProjectID(int projectId)
        { 
            List<UserStory> userStories = new List<UserStory>();

            string sql = $"select * from UserStory where Project_id={projectId}"; // get product backlock

            MySqlDataReader dr = Database.ExecutQuery(sql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["name"];
                    string description = (string)dr["description"];
                    int complexity = (int)dr["complexity"];
                    int priotity = (int)dr["priority"];
                    string state = (string)dr["state"];
                    UserStory userStory = new UserStory(id, name, state);
                    userStory.Priority = priotity;
                    userStory.Complexity = complexity;
                    userStory.Description = description;
                    userStories.Add(userStory);
                }
            }
            dr.Close();

            foreach (UserStory userStory in userStories)
            {
                // Fetching userStories comments
                userStory.Comments = FetchUserStoryComments(userStory.Id);

                // Fetching userStories assignees
                userStory.Assignees = FetchUserStoryAssignees(userStory.Id);
            }

            return userStories;
        }

        public List<Comment> FetchUserStoryComments(int userStoryId)
        {
            List<Comment> comments = new List<Comment>();
            string sql = $"" +
                $"SELECT usm.id as comment_id, usm.description, date, m.id as member_id, m.role, users.id as user_id, users.lastname, users.firstname " +
                $"FROM userstorycomment usm, member m, users " +
                $"WHERE userstory_id={userStoryId} and member_id=m.id and users.id = m.user_id " +
                $"ORDER BY usm.date DESC;";
            MySqlDataReader dr = Database.ExecutQuery(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int memberId = (int)dr["member_id"];
                    int commentId = (int)dr["comment_id"];
                    int userId = (int)dr["user_id"];
                    string description = (string)dr["description"];
                    string role = (string)dr["role"];
                    string lastname = (string)dr["lastname"];
                    string firstname = (string)dr["firstname"];
                    DateTime date = (DateTime)dr["date"];

                    User user = new User(userId);
                    user.FirstName = firstname; user.LastName = lastname;

                    Member member = new Member(memberId, role, user);

                    Comment comment = new Comment(commentId, description, member);
                    comment.Date = date;

                    comments.Add(comment);
                }
            }
            dr.Close();
            return comments;
        }
        public List<Member> FetchUserStoryAssignees(int userStoryId)
        {
            List<Member> assignees = new List<Member>();
            MySqlDataReader dr = Database.ExecutQuery($"" +
                $"SELECT member_id, role, user_id, lastname,firstname " +
                $"FROM {ASSIGNEES_TABLE} usm, {MEMBERS_TABLE} m, users " +
                $"WHERE usm.userstory_id={userStoryId} and usm.member_id =m.id and m.user_id= users.id;");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int memberId = (int)dr["member_id"];
                    int userId = (int)dr["user_id"];
                    string role = (string)dr["role"];
                    string lastname = (string)dr["lastname"];
                    string firstname = (string)dr["firstname"];

                    User user = new User(userId);
                    user.FirstName = firstname; user.LastName = lastname;

                    Member member = new Member(memberId, role, user);

                    assignees.Add(member);
                }
            }
            dr.Close();
            return assignees;
        }
        public bool PersistUserStoryWithSprintId(UserStory userStory, int sprintId, int projectId)
        {
            Database.Begin();

            if (userStory.Id < 1) userStory.Id = GenerateNewId(USER_STORIES_TABLE);

            // basics
            string sql = sprintId != -1 ? $"" +
                $"INSERT INTO {USER_STORIES_TABLE} (id, name, description, complexity, priority, state, sprint_id, project_id) " +
                $"VALUES ({userStory.Id}, '{userStory.Name}', '{userStory.Description}',{userStory.Complexity},{userStory.Priority}, '{userStory.State}', {sprintId}, {projectId}) " +
                $"ON DUPLICATE KEY " + 
                $"UPDATE description = '{userStory.Description}', name = '{userStory.Name}', complexity = {userStory.Complexity}, priority = {userStory.Priority}, state= '{userStory.State}', sprint_id={sprintId}, project_id={projectId} ; "
                : $"" +
                $"INSERT INTO {USER_STORIES_TABLE} (id, name, description, complexity, priority, state, project_id) " +
                $"VALUES ({userStory.Id}, '{userStory.Name}', '{userStory.Description}',{userStory.Complexity},{userStory.Priority}, '{userStory.State}', {projectId}) " +
                $"ON DUPLICATE KEY " +
                $"UPDATE description = '{userStory.Description}', name = '{userStory.Name}', complexity = {userStory.Complexity}, priority = {userStory.Priority}, state= '{userStory.State}', project_id={projectId} ; ";
            ;
            MySqlDataReader dr = Database.ExecutQuery(sql);
            if (dr.RecordsAffected < 0)
            {
                dr.Close();
                Database.Rollback();
                return false;
            }

            dr.Close();

            // assignements 
            bool ok = PersistAssignees(userStory.Assignees, userStory.Id);
            if (!ok)
            {
                Database.Rollback();
                return false;
            }

            // comments
            foreach (Comment c in userStory.Comments)
            {
                ok = PersistComment(c, userStory.Id);
                if (!ok)
                {
                    Database.Rollback();
                    return false;
                }
            }

            Database.Commit();
            return true;
        }
        public bool PersistComment(Comment comment, int userStoryId)
        {
            Database.Begin();

            if (comment.Id < 1) comment.Id = GenerateNewId(COMMENTS_TABLE);

            string sql = $"" +
                $"INSERT INTO {COMMENTS_TABLE} (id, description, date, member_id, userstory_id)" +
                $"VALUES ({comment.Id}, '{comment.Content}', '{comment.Date.ToString("yyyy/MM/dd HH:mm:ss")}',{comment.ByMember.Id},{userStoryId}) " +
                $"ON DUPLICATE KEY " +
                $"UPDATE description = '{comment.Content}', date = '{comment.Date.ToString("yyyy/MM/dd")}';";
            MySqlDataReader dr = Database.ExecutQuery(sql);
            if (dr.RecordsAffected < 0) {
                Database.Rollback();
                dr.Close();
                return false;
            }
            dr.Close();

            Database.Commit();
            return true;
        }
        public bool PersistAssignees(List<Member> members, int userstoryId)
        {
            Database.Begin();

            MySqlDataReader dr = Database.ExecutQuery($"DELETE FROM {ASSIGNEES_TABLE} WHERE userstory_id={userstoryId};");
            if (dr.RecordsAffected < 0)
            {
                dr.Close();
                Database.Rollback();
                return false;
            }
            dr.Close();

            foreach (Member member in members)
            {
                dr = Database.ExecutQuery($"INSERT INTO {ASSIGNEES_TABLE} (member_id,userstory_id) VALUES ({member.Id}, {userstoryId});");
                if (dr.RecordsAffected < 0) {
                    Database.Rollback();
                    return false; 
                }
                dr.Close();
            }

            Database.Commit();

            return true;
        }
        public bool UpdateState(UserStory userStory)
        {
            Database.Begin();
            MySqlDataReader dr = Database.ExecutQuery($"UPDATE {USER_STORIES_TABLE} SET state='{userStory.State}' WHERE id={userStory.Id};");
            dr.Close();
            if (dr.RecordsAffected < 0)
            {
                Database.Rollback();
                return false;
            }
            Database.Commit();
            return true;
        }
        
        public Member fetchMemberByProjectIdAndMemberId(int projectId, int memberId)
        {
            Member member = null;
            MySqlDataReader dr = Database.ExecutQuery($"" +
                $"SELECT m.id as member_id, role, user_id, lastname,firstname " +
                $"FROM {MEMBERS_TABLE} m, users " +
                $"WHERE m.Project_id={projectId} and m.id={memberId} and m.user_id= users.id;");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int userId = (int)dr["user_id"];
                    string role = (string)dr["role"];
                    string lastname = (string)dr["lastname"];
                    string firstname = (string)dr["firstname"];

                    User user = new User(userId);
                    user.FirstName = firstname; user.LastName = lastname;

                    member = new Member(memberId, role, user);
                }
            }
            dr.Close();
            return member;
        }
        public List<int> fetchSprintIdProjectIdByUserStoryId(int userStoryId)
        {
            List<int> sprintProjectIds = new List<int>();
            string qsl = $"" +
               $"SELECT Project_id, sprint_id " +
               $"FROM {USER_STORIES_TABLE} u " +
               $"WHERE u.id={userStoryId};";
            MySqlDataReader dr = Database.ExecutQuery(qsl);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (!Convert.IsDBNull(dr["sprint_id"]))
                    {
                        sprintProjectIds.Add((int)dr["sprint_id"]);
                    }
                    else
                    {
                        sprintProjectIds.Add(-1);
                    }
                    sprintProjectIds.Add((int)dr["Project_id"]);
                }
            }
            dr.Close();
            return sprintProjectIds;
        }
        public List<Member> fetchMembersByProjectMock(int projectId)
        {
            List<Member> members = new List<Member>();
            MySqlDataReader dr = Database.ExecutQuery($"" +
                $"SELECT m.id as member_id, role, user_id, lastname,firstname " +
                $"FROM {MEMBERS_TABLE} m, users " +
                $"WHERE m.Project_id={projectId} and m.user_id= users.id;");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int memberId = (int)dr["member_id"];
                    int userId = (int)dr["user_id"];
                    string role = (string)dr["role"];
                    string lastname = (string)dr["lastname"];
                    string firstname = (string)dr["firstname"];

                    User user = new User(userId);
                    user.FirstName = firstname; user.LastName = lastname;

                    Member member = new Member(memberId, role, user);

                    members.Add(member);
                }
            }
            dr.Close();
            return members;
        }
    }
}
