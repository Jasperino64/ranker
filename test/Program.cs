// See https://aka.ms/new-console-template for more information
using System.Collections;
namespace test {
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public User(int id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return "Id: " + Id + " " + Name + ": " + Score;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            IdGenerator generator = new IdGenerator();

            User user1 = new User(generator.Id, "John", 1);
            User user2 = new User(generator.Id, "Sally", 10);
            User user3 = new User(generator.Id, "Sarah", 100);
            User user4 = new User(generator.Id, "Jay", 49);
            User user5 = new User(generator.Id, "Jason", 80);
            User[] users = new User[] {user1, user2, user3, user4, user5};

            User[] sortedUsers = users.OrderByDescending(x => x.Score).ToArray();

            foreach (User u in sortedUsers)
            {
                Console.WriteLine(u);
            }
        }
    }
}

