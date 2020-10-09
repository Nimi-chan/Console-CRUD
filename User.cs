using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDToFile
{
    class User
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string email, string name, int age)
        {
            Email = email;
            Name = name;
            Age = age;
        }

        public User()
        {
            Email = null;
            Email = null;
            Age = -1;
        }
    }
}
