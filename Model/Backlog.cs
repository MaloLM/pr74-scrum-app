using System;
using System.Collections.Generic;
namespace pr74_scrum_app.Model
{
    public abstract class Backlog
    {
        private List<UserStory> userStories;
        public Backlog() 
        {
            userStories = new List<UserStory>();
        }
        public List<UserStory> UserStories { get { return userStories; } set { userStories = value; } }
        public void AddUserStory(UserStory userStory)
        {
            userStories.Add(userStory);
        }
        public void RemoveUserStory(UserStory userStory)
        {
            userStories.Remove(userStory);
        }
        public void RemoveUserStoryById(int id)
        {
            userStories.Remove(new UserStory(id, "", ""));
        }
        public List<UserStory> SearchBy(string query)
        {
            List<UserStory> selected = new List<UserStory>();
            foreach (UserStory us in UserStories)
            {
                bool selectable = false;
                if (query.Length > 0 && us.Name.Contains(query)) selectable = true;
                foreach (Member assignee in us.Assignees)
                {
                    string fullname = assignee.User.FirstName + " " + assignee.User.LastName;
                    if (query.Length > 0 && fullname.Contains(query)) selectable = true;
                }
                if (selectable) selected.Add(us);
            }

            return selected;
        }
        public List<UserStory> SearchBy(Member assignee)
        {
            List<UserStory> selected = new List<UserStory>();
            foreach (UserStory us in UserStories)
            {
                bool selectable = false;
                foreach (Member m in us.Assignees) if (assignee.Id == m.Id) selectable = true;
                if (selectable) selected.Add(us);
            }

            return selected;
        }
        public List<UserStory> SearchBy(int priority)
        {
            List<UserStory> selected = new List<UserStory>();
            foreach (UserStory us in UserStories) if (us.Priority==priority) selected.Add(us);
            return selected;
        }
        public List<UserStory> Intersect(List<UserStory> userStoriesA, List<UserStory> userStoriesB) 
        {
            List<UserStory> intersect = new List<UserStory>();
            foreach (UserStory us in userStoriesA) if (userStoriesB.Contains(us)) intersect.Add(us);
            return intersect;
        }
        public List<UserStory> Union(List<UserStory> userStoriesA, List<UserStory> userStoriesB)
        {
            foreach (UserStory us in userStoriesA) if (!userStoriesB.Contains(us)) userStoriesB.Add(us);
            return userStoriesB;
        }
    }
}
