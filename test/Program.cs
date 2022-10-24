// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace test {
    public class User
    {
        private static int id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public User(string name, int score)
        {
            Id = id;
            id++;
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return Name + ": " + Score;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            User user1 = new User("John", 1);
            User user2 = new User("Sally", 10);
            User user3 = new User("Sarah", 100);
            User user4 = new User("Jay", 49);
            User user5 = new User("Jason", 80);
            User[] users = new User[] {user1, user2, user3, user4, user5};

            User[] sortedUsers = users.OrderByDescending(x => x.Score).ToArray();

            foreach (User u in sortedUsers)
            {
                Console.WriteLine(u);
            }
        }
    }
}

