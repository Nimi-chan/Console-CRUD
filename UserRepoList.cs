using System.Collections.Generic;

namespace CRUDToFile
{
    class UserRepoList : IUserRepo
    {
        public List<User> Users { get; set; }
        private string fileName;

        public UserRepoList()
        {
            Users = new List<User>();
        }

        public UserRepoList(List<User> users)
        {
            this.Users = users;
        }

        ~UserRepoList()
        {

        }

        public void add(User user)
        {
            Users.Add(user);
        }

        public void update(string email, User user)
        {
            int index = -1;
            foreach (User u in Users) {
                if (u.Email.Equals(email))
                {
                    index = Users.IndexOf(u);
                    break;
                }
            }
            if (index != -1)
            {
                Users[index] = user;
            }
        }

        public User get(string email)
        {
            foreach (User u in Users)
            {
                if (u.Email.Equals(email))
                {
                    return u;
                }
            }
            return null;
        }

        public List<User> getAll()
        {
            return Users;
        }
        public void delete(string email)
        {
            User found = null;
            foreach (User u in Users)
            {
                if (u.Email.Equals(email))
                {
                    found = u;
                }
            }
            if (found != null)
            {
                Users.Remove(found);
            }
        }
    }
}
