using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_App
{
    static class DataBase
    {
        private static readonly ArrayList Users;
        static DataBase()
        {
            Users = new ArrayList();
        }
        public static ArrayList getUsers()
        {
            return Users;
        }
        public static void Add(User user)
        {
            if (user != null)
            {
                Users.Add(user);
            }
        }

        public static bool HasUser(User myUser)
        {
            bool isHere = false;
            foreach(User user in Users)
            {
                if (user.Email == myUser.Email)
                {
                    isHere = true;
                }
            }
            return isHere;
        }
        public static int HasUser(string email,string password)
        {
            int index = -1;
            for (int i = 0; i < Users.Count; i++)
            {
                User users = (User)getUsers()[i];
                if (users.Email == email&&users.Password==password)
                {
                    index = i;
                }
            }
            
            return index;
        }
        public static User GetStecificUser(string email)
        {
            User user = null;
            for (int i = 0; i < Users.Count; i++)
            {
                User users = (User)getUsers()[i];
                if (users.Email == email )
                {
                    user = (User)Users[i];
                }
            }

            return user;
        }
    }
}
