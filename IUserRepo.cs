using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDToFile
{
    interface IUserRepo
    {
        void add(User user);
        void update(string email, User user);
        User get(string email);
        List<User> getAll();
        void delete(string email);
    }
}
