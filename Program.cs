// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.Serialization;

namespace test {

    class Test
    {
        static void Main(string[] args)
        {
            var idGenerator = new IdGenerator();
            User user1 = new User(idGenerator.Id, "John", 1);
            User user2 = new User(idGenerator.Id, "Sally", 10);
            User user3 = new User(idGenerator.Id, "Sarah", 100);
            User user4 = new User(idGenerator.Id, "Jay", 49);
            User user5 = new User(idGenerator.Id, "Jason", 80);
            User[] users = {user1, user2, user3, user4, user5};
            User[] sortedUsers = users.OrderByDescending(x => x.Score).ToArray();

            foreach (User u in sortedUsers)
            {
                Console.WriteLine(u);
            }

            var names = new List<string> { "blah", "bleep", "bloop"};
            foreach (string name in names)
            {
                Console.WriteLine($"{name.ToUpper()}");
            }
            Console.WriteLine(names.IndexOf("bloop"));

            var fib = new Fibonacci();
            Console.WriteLine(fib.get(20));

            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);
        }
    }
}

