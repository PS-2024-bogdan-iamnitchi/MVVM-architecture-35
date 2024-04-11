using System;

namespace MVVM_architecture_35.Model
{
    public class Player
    {
        private uint playerID;
        private string isAdmin;
        private string fullName;
        private string email;
        private uint age;
        private string password;
        private uint score;

        public Player()
        {
            this.playerID = 0;
            this.isAdmin = "No";
            this.fullName = "No Name";
            this.email = "no.name@none.com";
            this.age = 20;
            this.password = "parola123";
            this.score = 0;
        }

        public Player(Player player)
        {
            this.playerID = player.playerID;
            this.isAdmin = player.isAdmin;
            this.fullName = player.fullName;
            this.email = player.email;
            this.age = player.age;
            this.password = player.password;
            this.score = player.score;
        }
        public Player(string fullName, string email, uint age, string password)
        {
            this.playerID = 0;
            this.isAdmin = "No";
            this.fullName = fullName;
            this.email = email;
            this.age = age;
            this.password = password;
            this.score = 0;
        }

        public Player(uint playerID, string isAdmin, string fullName, string email, uint age, string password, uint score)
        {
            this.playerID = playerID;
            this.isAdmin = isAdmin;
            this.fullName = fullName;
            this.email = email;
            this.age = age;
            this.password = password;
            this.score = score;
        }

        public uint PlayerID
        {
            get { return this.playerID; }
            set { this.playerID = value; }
        }

        public string IsAdmin
        {
            get { return this.isAdmin; }
            set { this.isAdmin = value; }
        }

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public uint Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public uint Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public override string ToString()
        {
            string s = "Player: " + this.fullName + "\n";
            s += " - ID: " + this.playerID + "\n";
            s += " - isAdmin: " + this.IsAdmin + "\n";
            s += " - email: " + this.email + "\n";
            s += " - age: " + this.age + "\n";
            s += " - password: " + this.password + "\n";
            s += " - score: " + this.score + "\n";
            return s;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            Player p = (Player)obj;
            return this.playerID == p.playerID;
        }
    }
}
