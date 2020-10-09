using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CRUDToFile
{
    class UserAccess
    {
        private string FileName;
        private IUserRepo UserRepo;

        public UserAccess()
        {
            UserRepo = new UserRepoList();
        }

        public UserAccess(string fileName)
        {
            FileName = fileName;
            StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\" + fileName);
            List<User> users = new List<User>();
            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(',');
                users.Add(new User(line[0].Trim(), line[1].Trim(), Convert.ToInt32(line[2].Trim())));
            }
            streamReader.Close();
            UserRepo = new UserRepoList(users);
        }

        public void save()
        {
            if (FileName == null)
            {
                FileName = "default.txt";
            }
            string filePath = Path.Combine(Environment.CurrentDirectory, FileName);
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            StreamWriter streamWriter = new StreamWriter(filePath, false);
            List<User> users = UserRepo.getAll();
            foreach(User user in users)
            {
                streamWriter.Write($"{user.Email}, {user.Name}, {user.Age}\n");
            }
            streamWriter.Flush();
            streamWriter.Close();
        }

        public void add(User user)
        {
            UserRepo.add(user);
        }

        public User get(string email)
        {
            return UserRepo.get(email);
        }

        public List<User> getAll()
        {
            return UserRepo.getAll();
        }
        public void update(string email, User user)
        {
            UserRepo.update(email, user);
        }

        public void delete(string email)
        {
            UserRepo.delete(email);
        }
    }
}
