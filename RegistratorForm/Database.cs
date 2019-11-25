using System;

namespace RegistratorForm
{
    public class Database
    {
        public static User[] users;
        static int counter = 0;
        static Database()
        {
            users = new User[1];
            users[0] = new User();
            users[0].Name = "Admin";
            users[0].Surname = "Adminov";
            users[0].Email = "admin@mail.ru";
            users[0].Password = "1234";
        }
        public static bool HasUser(User newUser)
        {
            bool isHere = false;
            foreach (User user in users)
            {
                if (user.Email == newUser.Email)
                {
                    isHere = true;
                    break;
                }
            }
            return isHere;
        }
        public static bool HasUser(string email,string password)
        {
            bool isHere = false;
            foreach (User user in users)
            {
                if (user.Email == email&& user.Password == password)
                {
                    isHere = true;
                    break;
                }
            }
            return isHere;
        }
        public static void AddUser(User user)
        {
            counter++;
            if (users.Length <= counter)
            {
                Array.Resize(ref users, users.Length * 2);
            }
            users[counter] = user;
        }
        public static string GetUserName(string email)
        {
            string name=String.Empty;
            foreach(User user  in users)
            {
                if (user.Email == email)
                {
                    name = user.Name;
                }
            }
            return name;
        }
    }
}
