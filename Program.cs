using System;

namespace CRUDToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController("default.txt");
            char choice = 'n';
            while (choice != 'q')
            {
                Console.WriteLine("Create user: c");
                Console.WriteLine("Read user:   r");
                Console.WriteLine("Read all:    a");
                Console.WriteLine("Update user: u");
                Console.WriteLine("Delete user: d");
                Console.WriteLine("Quit:        q");
                choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case 'c':
                        userController.create();
                        break;
                    case 'r':
                        userController.read();
                        break;
                    case 'a':
                        userController.readAll();
                        break;
                    case 'u':
                        userController.update();
                        break;
                    case 'd':
                        userController.delete();
                        break;
                    default:
                        Console.WriteLine("Please, choose operation from the following: ");
                        break;
                }
                Console.WriteLine();
            }
            userController.save();
        }
    }
}
