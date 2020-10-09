using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDToFile
{
    class UserController
    {
        private UserAccess userAccess;

        public UserController()
        {
            userAccess= new UserAccess();
        }

        public UserController(string fileName)
        {
            userAccess = new UserAccess(fileName);
        }
        
        public void save()
        {
            userAccess.save();
        }

        public void create() 
        {
            Console.WriteLine();
            userAccess.add(construct());
        }

        public void read() 
        {
            Console.WriteLine();
            Console.Write("User email: ");
            string email = Console.ReadLine();
            User user = userAccess.get(email);
            Console.WriteLine($"email: {user.Email}, name: {user.Name}, age: {user.Age}");
        }

        public void update() 
        {
            Console.WriteLine();
            Console.Write("User email: ");
            userAccess.update(Console.ReadLine(), construct());
        }

        public void delete() 
        {
            Console.WriteLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            userAccess.delete(email);
        }

        public void readAll()
        {
            Console.WriteLine();
            foreach(User user in userAccess.getAll()) {
                Console.WriteLine($"email: {user.Email}, name: {user.Name}, age: {user.Age}");
            }
        }

        private User construct()
        {
            User user = new User();
            Console.Write("email: ");
            user.Email = Console.ReadLine();
            Console.Write("name: ");
            user.Name = Console.ReadLine();
            Console.Write("age: ");
            user.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return user;
        }
    }
}
