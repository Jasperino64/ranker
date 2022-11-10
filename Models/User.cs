using System;

namespace ranker
{ 
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public User(int id, string name, int score)
        {
            this.Id = id;
            id++;
            this.Name = name;
            this.Score = score;
        }

        public override string ToString()
        {
            return $"{Id} {Name}: {Score}";
        }
    }
}

