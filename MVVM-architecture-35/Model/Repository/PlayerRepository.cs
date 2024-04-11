using System;
using System.Collections.Generic;
using System.Data;

namespace MVVM_architecture_35.Model.Repository
{
    public class PlayerRepository
    {
        private Repository repository;

        public PlayerRepository()
        {
            this.repository = new Repository();
        }

        public PlayerRepository(string database)
        {
            this.repository = new Repository(database);
        }

        public bool SignUpPlayer(Player player)
        {
            string commandInput = "INSERT INTO Player VALUES('";
            commandInput += "No" + "','" + player.FullName + "','";
            commandInput += player.Email + "','" + player.Age + "','";
            commandInput += player.Password + "','" + player.Score + "');";

            return this.repository.CommandSQL(commandInput);
        }

        public bool LoginPlayer(string email, string password)
        {
            string commandInput = "SELECT * FROM Player WHERE Email = '" + email + "';";
            DataTable playerTable = this.repository.GetTable(commandInput);
            if (playerTable != null && playerTable.Rows.Count != 0)
            {
                DataRow row = playerTable.Rows[0];
                //if (BCrypt.Net.BCrypt.Verify(password, row["Password"].ToString()))
                //{
                //    return true;
                //}
                if (password.Equals(row["Password"].ToString()))
                {
                    return true;
                }

            }
            return false;
        }

        public Player GetPlayerByEmail(string email)
        {
            string commandInput = "SELECT * FROM Player WHERE Email = '" + email + "';";
            DataTable playerTable = this.repository.GetTable(commandInput);
            if (playerTable != null && playerTable.Rows.Count != 0)
            {
                return rowToPlayer(playerTable.Rows[0]);
            }
            return null;
        }

        public bool AddPlayer(Player player)
        {
            string commandInput = "SET IDENTITY_INSERT Player ON;\n";
            commandInput += "INSERT INTO Player ([ID], [IsAdmin], [FullName], [Email], [Age], [Password], [Score]) VALUES('";
            commandInput += player.PlayerID + "','";
            commandInput += "No" + "','" + player.FullName + "','";
            commandInput += player.Email + "','" + player.Age + "','";
            commandInput += player.Password + "','" + player.Score + "');\n";
            commandInput += "SET IDENTITY_INSERT Player OFF;";
            return this.repository.CommandSQL(commandInput);
        }

        public bool UpdatePlayer(uint playerID, Player player)
        {
            string commandInput = "UPDATE Player SET FullName = '" + player.FullName + "', ";
            commandInput += "Age = '" + player.Age + "', Email = '" + player.Email + "', ";
            commandInput += "Password = '" + player.Password + "', Score = '" + player.Score + "' ";
            commandInput += "WHERE ID = '" + playerID + "'; ";
            return this.repository.CommandSQL(commandInput);
        }


        public bool DeletePlayer(uint playerID)
        {
            string comandInput = "DELETE FROM Player WHERE ID = '" + playerID + "';";
            return this.repository.CommandSQL(comandInput);
        }

        public Player SearchPlayerByID(string id)
        {
            int playerID = Convert.ToInt32(id);
            string comandInput = "SELECT * FROM Player WHERE ID = '" + playerID + "';";
            DataTable playerTable = this.repository.GetTable(comandInput);
            if (playerTable == null || playerTable.Rows.Count == 0)
                return null;
            DataRow row = playerTable.Rows[0];
            return this.rowToPlayer(row);
        }

        public List<Player> SearchPlayerByName(string name)
        {
            string comandInput = "SELECT * FROM Player WHERE FullName LIKE '%" + name + "%'";
            DataTable playerTable = this.repository.GetTable(comandInput);
            if (playerTable == null || playerTable.Rows.Count == 0)
                return null;
            List<Player> list = new List<Player>();
            foreach (DataRow row in playerTable.Rows)
            {
                Player player = this.rowToPlayer(row);
                list.Add(player);
            }
            return list;
        }

        public DataTable GetPlayersTable()
        {
            string commandInput = "SELECT * FROM Player WHERE IsAdmin='No' ORDER BY [FullName]";
            DataTable playerTable = this.repository.GetTable(commandInput);
            if(playerTable == null || playerTable.Rows.Count == 0)
            {
                return null;
            } 
            return playerTable;
        }

        public List<Player> GetPlayersList()
        {
            DataTable playerTable = this.GetPlayersTable();
            if (playerTable == null)
                return null;
            
            List<Player> list = new List<Player>();
            foreach(DataRow row in playerTable.Rows)
            {
                Player player = this.rowToPlayer(row);
                list.Add(player);
            }
            return list;
        }

        public Player rowToPlayer(DataRow row)
        {
            int id = (int) row["ID"];
            string isAdmin = (string) row["IsAdmin"];
            string fullName = (string) row["FullName"];
            string email = (string) row["Email"];
            int age = (int) row["Age"];
            string password = (string) row["Password"];
            int score = (int) row["Score"];

            return new Player((uint)id, isAdmin, fullName, email, (uint)age, password, (uint)score);
        }

    }
}
