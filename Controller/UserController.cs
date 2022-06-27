using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using pr74_scrum_app.Model;

namespace pr74_scrum_app.Controller
{
    class UserController : Controller
    {
        User user;
        public UserController(): base() 
        {
        }
        public User FetchUserById(int userId)
        {
            User user = null;
            string sql = $"select * from users where id={userId}";
            MySqlDataReader dr = Database.ExecutQuery(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    user = new User((int)dr["id"]);
                    user.Email = (string)dr["email"];
                    user.FirstName = (string)dr["firstname"];
                    user.LastName = (string)dr["lastname"];
                }
            }
            dr.Close();

            return user;
        }
   
        //methode to sign in into the application
        public bool UserLogin(string pass, string email)
        {
            if (pass != string.Empty || email != string.Empty)//check if field are not empty
            {
                string sql = $"select * from users where email='{email}' and password='{EncryptPass(pass)}'";
                MySqlDataReader dr = Database.ExecutQuery(sql); //if match 
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.user = new User((int)dr["id"], (string)dr["firstname"], (string)dr["lastname"], (string)dr["password"], (string)dr["email"]);
                    }
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Votre email ou mot de passe incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplir tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Methode to create a new user 
        public bool UserRegistration(string firstname, string lastname, string email, string pass, string confirmpass)
        {
            if (pass != string.Empty || email != string.Empty || firstname != string.Empty || lastname != string.Empty)
            {
                if (pass == confirmpass)//check confimation pass
                {
                    MySqlDataReader data = Database.ExecutQuery("select * from users where email='" + email + "'");
                    if (data!=null && data.HasRows)//check if email exist
                    {
                        data.Close();
                        MessageBox.Show("L'email existe déja, essayer un nouveau email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (!Regex.IsMatch(email.Trim(), @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))// check if email is in right format
                    {
                        MessageBox.Show("L'adresse email n'est pas valide ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        data.Close();
                        return false;
                    }
                    else
                    {
                        data.Close();
                        string sql = $"insert into users(lastname,firstname,email,password) values('{lastname}','{firstname}','{email}','{EncryptPass(pass)}')";
                        MySqlDataReader resp = Database.ExecutQuery(sql);
                        resp.Close();
                        MessageBox.Show("Votre compte est crée. Connectez-vous.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Entrer le même mot de passe ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Vous devez completer tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string EncryptPass(string Pass)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("Iamtheencryptionkey"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(Pass);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        public string DecryptPass(string pass)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("Iamtheencryptionkey"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] data = Convert.FromBase64String(pass);
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(result);
                    }
                }

            }
        }
        public User User{ get { return user; } set { user = value; } }

        //methode to udpdate user informations
        public void UpdateInfos(string firstname, string lastname, string email,int id)
        {
            MySqlDataReader na;
            try
            {
                string stringupdate = $"Update users set firstname='{firstname}' , lastname='{lastname}' where id={id} and email='{email}'";
                na = Database.ExecutQuery(stringupdate);
                na.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /* This methide create a projet, fiell table project and table member
         * the person whom create the projet is automatically the owner and the project stage archived is 0 for no
        */
        public void CreateProjet(string name, string description, int id)
        {
            MySqlDataReader na, data;
            int idpro = 0;
            try
            {
                string insertProjet = $"insert into project(name,description,archived,created_dt) values('{name}','{description}',{0},CURRENT_DATE) ; SELECT LAST_INSERT_ID() as id";
                data = Database.ExecutQuery(insertProjet);
                if(data!=null && data.HasRows)
                {
                    if (data.Read())
                    {
                        idpro = data.GetInt32(0); // get project id
                        data.Close();
                    }
                    if (idpro != 0)
                    {
                        string insertMernber = $"insert into member(role,project_id,user_id) values('SM',{idpro},{id})";
                        na = Database.ExecutQuery(insertMernber);
                        na.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Votre projet n'a pas été crée correctement !");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Votre projet n'a pas été crée correctement : " + e.Message);
            }
        }
        public List<Project> ReloadProjet(int userid)
        {
            MySqlDataReader data;
            var project = new List<Project>();
            string sqlprojet = "select project.id,name from project inner join member on member.Project_id=project.id " +
                $"where member.user_id={userid} and project.archived={0} order by project.created_dt DESC,project.id DESC LIMIT 4";            
            data = Database.ExecutQuery(sqlprojet);
            if(data !=null && data.HasRows)
            {
                while (data.Read()) 
                {
                    Project pro = new Project(data.GetInt32(0),data["name"].ToString());
                    project.Add(pro); //retrun project nme and id 
                }
            }
            data.Close();
            return project;
        }
        public List<Sprint> ReloadSprint(int userid)
        {
            MySqlDataReader data;
            var sprint = new List<Sprint>();
            string sqlstack = "select sprint.id,sprint.name,sprint.startDate,sprint.endDate from sprint inner join project on project.id=sprint.Project_id inner join member on member.project_id=project.id " +
                $"where member.user_id ={userid} and project.archived={0} order by project.created_dt DESC,project.id DESC LIMIT 4 ";
            data = Database.ExecutQuery(sqlstack);
            if (data != null && data.HasRows)
            {
                while (data.Read())
                {
                    Sprint sp = new Sprint(data.GetInt32(0), data["name"].ToString(),data.GetDateTime(2),data.GetDateTime(3));
                    sprint.Add(sp); //retrun sprint inforamtion
                }
            }
            data.Close();
            return sprint;

        }

        public List<UserStory> ReloadTask(int userid)
        {
            MySqlDataReader data;
            var task = new List<UserStory>();
            string sqltask = "select userStory.id,userStory.name,userStory.state,userStory.priority from userStory inner join project on project.id=userStory.Project_id " +
                " inner join member on member.project_id=project.id " +
                $" where member.user_id ={userid} and userStory.state <> 'done' and project.archived={0} order by project.created_dt DESC,project.id DESC LIMIT 4";
            data = Database.ExecutQuery(sqltask);
            if (data != null && data.HasRows)
            {
                while (data.Read())
                {
                    UserStory us = new UserStory(data.GetInt32(0), data["name"].ToString(), data.GetString(2));
                    us.Priority = (int)data["priority"];
                    task.Add(us); //retrun stack inforamtion
                }
            }
            data.Close();
            return task;
        }

        public List<Project> SearchProject(int userid)
        {
            MySqlDataReader data;
            var project = new List<Project>();
            string sqlprojet = "select project.id,name from project inner join member on member.Project_id=project.id " +
                $"where member.user_id={userid} and project.archived={0} order by project.created_dt DESC,project.id DESC";
            data = Database.ExecutQuery(sqlprojet);
            if (data != null && data.HasRows)
            {
                while (data.Read())
                {
                    Project pro = new Project(data.GetInt32(0), data["name"].ToString());
                    project.Add(pro); //retrun project nme and id 
                }
            }
            data.Close();
            return project;
        }
        public Member GetMember(User user)
        {
            MySqlDataReader data;
            Member member =null;
            string sqlm = $"select * from  member where member.user_id={user.Id} ";
            data = Database.ExecutQuery(sqlm);
            if (data != null && data.HasRows)
            {
                while (data.Read())
                {
                    member = new Member((int)data["id"],(string)data["role"],user);
                }
            }
            data.Close();
            return member;
        }
        public Member GetMemberById(int membeId)
        {
            
            Member member = null;
            string sqlm = $"select u.id as user_id, firstname, lastname, email, role, m.id as member_id  from  member m, users u where u.id= m.user_id and m.id={membeId} ";
            MySqlDataReader data = Database.ExecutQuery(sqlm);
            if (data != null && data.HasRows)
            {
                while (data.Read())
                {
                    User user = new User((int)data["user_id"]);
                    user.FirstName = (string)data["firstname"]; 
                    user.LastName = (string)data["lastname"]; 
                    user.Email = (string)data["email"];
                    member = new Member(membeId, (string)data["role"], user);
                }
            }
            data.Close();
            return member;
        }
        //methode to pin a project 
        public bool PinAnproject(int idproject, int userid)
        {
            MySqlDataReader data , na;
            bool addpin = false;
            string sqlpin = "select count(*) from project inner join member on member.Project_id=project.id " +
                $"where member.user_id={userid} and project.archived={0}  and project.pinned={1} group by project.name";
            data = Database.ExecutQuery(sqlpin);
            if ( data!=null)
            {
                if (data.GetInt32(0)>5) //if the the number of pinned project in superior to 5 send false 
                {
                    addpin = false;
                    data.Close();
                }
                else //update
                {
                    string stringupdate = $"Update project set pinned={1} where id={idproject}";
                    na = Database.ExecutQuery(stringupdate);
                    na.Close();
                }
                data.Close();
            }
            return addpin;
        }
    }
}
