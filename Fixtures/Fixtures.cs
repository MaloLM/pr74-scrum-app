using System;
using System.Collections.Generic;
using Bogus;

using AutoFixture;
using System.Data.SqlClient;

namespace pr74_scrum_app
{
    public class Fixtures
    {
        private Database db;

        private Random random = new Random();   

        public Fixtures()
        {
            this.db = new Database();
        } 

        public void CreateUsers()
        {
            String queryModel = "INSERT INTO users (id, firstname, lastname, email, password) VALUE({0}, '{1}', '{2}', '{3}', '{4}')";
            for(int i = 1; i <= 50; i++)
            {
                String firstName = Faker.Name.First();
                String query = String.Format(queryModel, i, firstName, Faker.Name.Last(), Faker.Internet.Email(firstName), "123456");

                this.db.ExecuteFixtureQuery(query);
            }

        }

        public void CreateProjects()
        {
            string[] projectsName = { "Scrum", "IHM", "RSA", "AES", "Inscription", "Facturation", "Alexa", "Voyages" };

            String queryModel = "INSERT INTO project (id, name, description, archived) VALUE({0}, '{1}', '{2}', '{3}')";
            for (int i = 1; i <= 15; i++)
            {
                String query = String.Format(queryModel, i, projectsName[this.random.Next(8)], Faker.Lorem.Paragraph(), random.Next(2) == 0);
                this.db.ExecuteFixtureQuery(query);
            }
        }

        public void CreateMembers()
        {
            string[] roles = { "Product owner", "Scrum master", "Developer" };
            String queryModel = "INSERT INTO member (id, role, user_id, project_id) VALUE({0}, '{1}', {2}, {3})";

            int sprintId = 1, userId = 1, projectId = 1;
            for (int i = 1; i <= 15; i++)
            {
                for(int y = 0; y < roles.Length; y++)
                {
                    String query = String.Format(queryModel, sprintId++, roles[y], userId++, projectId);
                    this.db.ExecuteFixtureQuery(query);
                }
                projectId = projectId + 1;
            }
        }

        public void CreateSprints()
        {
            String queryModel = "INSERT INTO sprint (id, name, startDate, endDate, project_id) VALUE({0}, '{1}', '{2}', '{3}', {4})";
            int sprintId = 1, projectId = 1;

            for(int i  = 1; i <= 15; i++)
            {
                List<DateTime> dates = this.sortDates(this.getDatesTimes(6));
                int dateIndex = 0;

                for (int y = 0; y < 3; y++)
                {
                    String sprintName = String.Format("Sprint n°{0}", y + 1);
                    String query = String.Format(queryModel, sprintId++, sprintName, dates[dateIndex].ToString("yyyy/M/dd"), dates[dateIndex + 1].ToString("yyyy/M/dd"), projectId);

                    dateIndex = dateIndex + 2;
                    this.db.ExecuteFixtureQuery(query);
                }
                projectId = projectId + 1;
            }
        }

        public void createUserStories()
        {
            string[] userStories = { "Page d'accueil", "Inscription", "Connexion", "Profil", "Administration", "Footer", "Navigation", "Parmètres", "Fixtures", "Documentation" };
            string[] states = { "To do", "In progress", "Done" };

            String queryModel = "INSERT INTO userstory (id, name, description, complexity, priority, state, sprint_id, project_id) VALUE({0}, '{1}', '{2}', {3}, {4}, '{5}' , {6}, {7})";
            int userStoryId = 1, sprintId = 1, projectId = 1;

            for (int i = 1; i <= 15; i++)
            {
                for(int y = 1; y <= 3; y++)
                {
                    String query = String.Format(queryModel, userStoryId++, userStories[this.random.Next(10)], Faker.Lorem.Sentence(), this.random.Next(1, 11), this.random.Next(1, 4), states[this.random.Next(3)], sprintId++, projectId);
                    this.db.ExecuteFixtureQuery(query);
                }
                projectId = projectId + 1;
            }
        }

        public void createUserStoryComments()
        {
            String queryModel = "INSERT INTO userstorycomment (id, description, date, member_id, userstory_id) VALUE({0}, {1}, {2}, {3}, {4})";
            int userStoryCommentId = 1, memberId = 1, userStoryId = 1;

            for(int i = 1; i < 15; i++)
            {
                List<DateTime> dates = this.sortDates(this.getDatesTimes(3));
                for(int y = 0; y < 3; y++)
                {
                    String query = String.Format(queryModel, userStoryCommentId++, Faker.Lorem.Sentence(), dates[y].ToString("yyyy/M/dd"), memberId++, userStoryId);
                    Console.WriteLine(query);
                }
                userStoryId = userStoryId + 1;
            }
        }

        public void createUserStoryMembers()
        {
            String queryModel = "INSERT INTO userstorymember (id, member_id, userstory_id) VALUE({0}, {1}, {2})";
            int memberId = 1, userStoryId = 1;

            for(int i = 1; i < 15; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    String query = String.Format(queryModel, i, memberId++, userStoryId);
                    Console.WriteLine(query);
                }
                userStoryId = userStoryId + 1;
            }
        }

        public List<String> createComments()
        {
            List<String> comments = new List<String>();
            String queryModel = "";

            return comments;
        } 

        private List<DateTime> getDatesTimes(int size)
        {
            List<DateTime> dates = new List<DateTime>();
            for(int i = 0; i < size; i++)
            {
                dates.Add(this.randomDateTime());
            }

            return dates;
        }

        private DateTime randomDateTime()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;

            return start.AddDays(this.random.Next(range));
        }

        private List<DateTime> sortDates(List<DateTime> dates)
        {
            dates.Sort((dateOne, dateTwo) => dateOne.CompareTo(dateTwo));
            return dates;
        }
    }
}
