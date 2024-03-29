﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class Project
    {
        private int id;
        private string name;     
        private string description;
        private bool is_archived;
        private List<Member> members;
        private List<Sprint> sprints;
        private ProductBacklog backlog;

        public Project(int id, string name)
        {
            members = new List<Member>();
            sprints = new List<Sprint>();
            this.id = id;
            this.name = name;
        }
        public Project(int id, string name, string description)
        {
            this.id=id; 
            this.name = name;
            this.description = description; 
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }   
        public string Description { get { return description; } set { description = value; } }
        public bool IsArchived { get { return is_archived; } set { is_archived = value; } }
        public List<Member> Members { get { return members; } set { members = value; } }
        public List<Sprint> Sprints { get { return sprints; } set { sprints = value; } }
        public ProductBacklog Backlog { get { return backlog; } set { backlog = value; } }
        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }
        public void RemoveMemberById(int id)
        {
            members.Remove(new Member(id, "", null));
        }

        public void AddSprint(Sprint sprint)
        {
            sprints.Add(sprint);
        }
        public void RemoveSprint(Sprint sprint)
        {
            sprints.Remove(sprint);
        }
        public void RemoveSprintById(int id)
        {
            sprints.Remove(new Sprint(id, "", DateTime.Now, DateTime.Now));
        }
    }
}
