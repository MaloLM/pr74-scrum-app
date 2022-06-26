
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string password;
        private string email;
        public User(int id, string firstName, string lastName, string password, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
        }
        public User(int id)
        {
            this.id = id;
        }
        public int Id {get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
