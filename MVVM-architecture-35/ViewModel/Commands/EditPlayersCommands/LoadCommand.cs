using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class LoadCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public LoadCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            PlayerRepository playerRepository = new PlayerRepository();
            try
            {
                this.editPlayersVM.PlayersTable.Rows.Clear();
                if (this.editPlayersVM.PlayersTable.Columns.Count < 6)
                {
                    this.editPlayersVM.PlayersTable.Columns.Add("ID", typeof(string));
                    this.editPlayersVM.PlayersTable.Columns.Add("FullName", typeof(string));
                    this.editPlayersVM.PlayersTable.Columns.Add("Email", typeof(string));
                    this.editPlayersVM.PlayersTable.Columns.Add("Age", typeof(uint));
                    this.editPlayersVM.PlayersTable.Columns.Add("Password", typeof(string));
                    this.editPlayersVM.PlayersTable.Columns.Add("Score", typeof(uint));
                }
                List<Player> lista = playerRepository.GetPlayersList();
                foreach (Player p in lista)
                    this.editPlayersVM.PlayersTable.Rows.Add(p.PlayerID, p.FullName, p.Email, p.Age, p.Password, p.Score);
            }
            catch (Exception exception)
            {
                this.editPlayersVM.SetMessage("Exception - Load", exception.ToString());
            }
        }
    }
}
