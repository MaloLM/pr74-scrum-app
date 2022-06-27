using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr74_scrum_app.Model;
using System.Text.RegularExpressions;

namespace pr74_scrum_app.Controller
{
    internal class ProjectController : Controller
    {
        public ProjectController() : base() { }


        public void PersistMember(int projectId, string userEmail, string role)
        {
            /**
             * this method do not have any data control since it has to be done before calling it (front-end)
             **/
            int userId = FetchUserIdByEmail(userEmail);
                string sql = $"select * from users where id={userId}";
                MySqlDataReader dataRequest = Database.ExecutQuery(sql);

                if (dataRequest != null && dataRequest.HasRows)
                {
                    dataRequest.Close();

                    sql = $"insert into Member (Project_id, role, user_id) values ('{projectId}','{role}','{userId}')";

                    dataRequest = Database.ExecutQuery(sql);
                    dataRequest.Close();
                            
                }
                dataRequest.Close();
        }


        public int FetchUserIdByEmail(string email)
        {
            int userId = -1;

            string sql = $"select id from users where email='{email}'";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);
            
            while (dataRequest.Read())
            {
                userId = (int)dataRequest["id"];
            }
            dataRequest.Close();

            return userId;
        }


        public bool emailExists(string email)
        {
            bool exists;

            string sql = $"select * from users where email={email}"; 
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);

            exists = dataRequest != null && dataRequest.HasRows;
            dataRequest.Close();

            return exists;
        }


        public User FetchUserById(int userId)
        {
            User user = null;

            string sql = $"select * from users where id={userId}";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);

            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string firstName = (string)dataRequest["firstname"];
                    string lastName = (string)dataRequest["lastname"];
                    string email = (string)dataRequest["email"];

                    user = new User(id);
                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.Email = email;

                }
            }
            dataRequest.Close();
            return user;
        }


        public void RemoveMember(Project project, int memberId)
        {
            string sql = $"select id from Member where id={memberId} and Project_id={project.Id}";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);

            if (dataRequest.HasRows)
            {
                project.RemoveMemberById(memberId);
                dataRequest.Close();

                sql = $"delete from member where id={memberId} and Project_id={project.Id}";
                dataRequest = Database.ExecutQuery(sql);
                dataRequest.Close();
            }
            dataRequest.Close();
        }


        public Project FetchProjectById(int projectId)
        {
            string sql = $"select * from Project where id={projectId}";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);

            Project project = null;
            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string name = (string)dataRequest["name"];
                    string description = (string)dataRequest["description"];
                    bool is_archived = (bool)dataRequest["archived"];

                    project = new Project(id, name, description);
                    project.IsArchived = is_archived;
                }
                dataRequest.Close();

                List<Member> members = FetchMembers(projectId);
                List<Sprint> sprints = FetchSprints(projectId);
                ProductBacklog productBacklog = FetchProductBacklog(projectId);

                project.Members = members;
                project.Sprints = sprints;
                project.Backlog = productBacklog;
            }
            dataRequest.Close();
            return project;
        }


        public ProductBacklog FetchProductBacklog(int projectId)
        {
            ProductBacklog backlog = new ProductBacklog();
            UserStoryController usc = new UserStoryController();
            backlog.UserStories = usc.FetchUserStoriesByProjectID(projectId);

            return backlog;
        }


        public List<Sprint> FetchSprints(int projectId)
        {
            List<Sprint> list = new List<Sprint>();

            string sql = $"select id, name, startDate, endDate from Sprint where Project_id={projectId}";

            MySqlDataReader dataRequest = Database.ExecutQuery(sql);
            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string name = (string)dataRequest["name"];
                    DateTime startDate = (DateTime)dataRequest["startDate"];
                    DateTime endDate = (DateTime)dataRequest["endDate"];

                    Sprint sprint = new Sprint(id, name,startDate,endDate);

                    list.Add(sprint);
                }
            }

            dataRequest.Close();

            return list;
        }


        public List<Member> FetchMembers(int projectId)
        {
            List<Member> list = new List<Member>();
            
            string sql = $"select u.id as user_id," +
                $" m.role as role," +
                $" u.lastname as lastname," +
                $" u.firstname as firstname," +
                $" m.id as id," +
                $" u.email as email" +
                $" from Member m, users u" +
                $" where Project_Id={projectId} and m.user_id=u.id";

            MySqlDataReader dataRequest = Database.ExecutQuery(sql); // pour chaque membre, retourner le nom, le role, l'id du membre (pas du user)
            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string role = (string)dataRequest["role"];
                    int userId = (int)dataRequest["user_id"];

                    string firstname = (string)dataRequest["firstname"];
                    string lastname = (string)dataRequest["lastname"];
                    string email = (string)dataRequest["email"];

                    User user = new User(userId, firstname, lastname, email);
                    Member currentMember = new Member(id, role, user);

                    list.Add(currentMember);
                }
                dataRequest.Close();
            }
            dataRequest.Close();

            return list;
        }


        public void PersistNewSprint(string name, DateTime startingDate, DateTime endingDate, int projectId)
        {
                string start = startingDate.ToString("yyyy/MM/dd");
                string end = endingDate.ToString("yyyy/MM/dd");
                string sql = $"insert into Sprint (name, startDate, endDate, Project_id) values ('{name}','{start}','{end}',{projectId})"; 
                MySqlDataReader dataRequest = Database.ExecutQuery(sql);
                dataRequest.Close();
        }


        public void ArchiveProject(int projectId)
        {
            string sql = $"select * from Project where id={projectId}";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);

            if (dataRequest.HasRows) // project exists
            {
                dataRequest.Close();
                sql = $"update Project SET archived = 1 where id={projectId}";
                dataRequest = Database.ExecutQuery(sql);
                dataRequest.Close();
            }
        }

        public void PersistProductBacklogUserStory(string name, int priority, int complexity, string description, int projectId)
        {
            string defaultState = "TODO";
            string sql = $"insert into UserStory (name, description , complexity , priority, state, Project_id ) " +
                $"values ('{name}','{description}','{complexity}',{priority},'{defaultState}',{projectId})";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);
            dataRequest.Close();
        }


        public Member FetchMember(int projectId, int userId)
        {
            Member member = null;
            User user = FetchUserById(userId);
            string sql = $"select id, Project_id, role from Member where Project_id={projectId} and user_id={userId}";
            MySqlDataReader dataRequest = Database.ExecutQuery(sql);

            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int memberId = (int)dataRequest["id"];
                    string role = (string)dataRequest["role"];
                    member = new Member(memberId, role, user);
                }
            }
            dataRequest.Close();

            return member;
        }

    }
}
