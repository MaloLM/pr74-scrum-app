using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class Member : IEquatable<Member>
    {
        private int id;
        private string role;
        private User user;
        private List<UserStory> assignements;

        public Member(int id, string role, User user)
        {
            this.id = id;   
            this.role = role;
            this.user = user;
           assignements = new List<UserStory>();
        }
        public Member(int id)
        {
            this.id = id;
        }
        public int Id { get { return id; }  set { id = value; }}
        public User User { get { return user; } set { user = value; }}
        public string Role { get { return role; } set { role = value; } }
        public List<UserStory> Assignements { get { return assignements; } set {assignements = value;} }
        public string getFullRole()
        {
            switch (Role)
            {
                case "SM":
                    return "Scrum Master";
                case "PO":
                    return "Product owner";
                case "DEV":
                    return "Standard";
                default:
                    return "None";
            }
        }
        public bool Equals(Member other)
        {
            return id == other.id;
        }
        public void AddAssignement(UserStory userStory)
        {
            assignements.Add(userStory);
        }
        public void RemoveAssignement(UserStory userStory)
        {
            assignements.Remove(userStory);
        }
    }
}
