// Create a database management system for manage user in our market. 
// We can perform user add, check rather a user exists or not in the database
// and also checking a user exits with a specific username and password.
// Get a user with a specific username
// Get all the user present in the database

using System;
namespace Ecommerce
{
    class User
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        private string Password;

        public User(string fullname, string username, string password)
        {
            this.FullName = fullname;
            this.UserName = username;
            this.Password = password;
        }
        public void Details()
        {
            Console.WriteLine("Fullname: " + FullName);
            Console.WriteLine("Username: " + UserName);
        }
        public bool PasswordVarify(string password)
        {
            return this.Password == password;
        }
    }
    class Users
    {
        private User[] users = new User[100];
        private int UserCount;
        public Users()
        {
            this.UserCount = 0;
        }
        public void Add(string fullName, string userName, string password)
        {
            users[UserCount++] = new User(fullName, userName, password);
        }
        public bool Exists(string username)
        {
            for (int i = 0; i < UserCount; i++)
            {
                if (users[i].UserName == username)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Exists(string username, string password)
        {
            for (int i = 0; i < UserCount; i++)
            {
                if (users[i].UserName == username && users[i].PasswordVarify(password))
                {
                    return true;
                }
            }
            return false;
        }

        public User Get(string username)
        {

            foreach (User user in users)
            {
                if (user.UserName == username)
                {
                    return user;
                }
            }
            return new User("null", "null", "null");
        }
    }
}