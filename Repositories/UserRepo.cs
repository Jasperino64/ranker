using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ranker.Repositories
{
    public class UserRepo
    {
        public static List<User> Users = new List<User>();

        public void addUser(User user)
        {
            Users.Add(user);
        }

        public bool deleteUser(int userId)
        {
            int currLength = Users.Count;
            Users.RemoveAll(x => x.Id == userId);

            return currLength != Users.Count;
        }

        public User getUser(int userId)
        {
            User user = Users.Find(x => x.Id == userId);
            return user;
        }

        public List<User> getUsers()
        {
            return Users.ToList();
        }
    }
}
