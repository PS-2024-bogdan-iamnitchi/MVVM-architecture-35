using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class SearchCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public SearchCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            PlayerRepository playerRepository = new PlayerRepository();
            try
            {
                this.editPlayersVM.PlayersTable.Clear();
                string searchedInfo = this.editPlayersVM.SearchInfo;
                if (searchedInfo != null && searchedInfo.Length > 0)
                {
                    List<Player> list = new List<Player>();

                    if (uint.TryParse(searchedInfo, out uint result))
                    {
                        Player player = playerRepository.SearchPlayerByID(searchedInfo);
                        if (player != null)
                        {
                            list.Add(player);
                            this.playersListToDataTable(list);
                        }
                        else
                            this.editPlayersVM.SetMessage("Empty", "There is no player according to searched information!");
                    }
                    else
                    {
                        list = playerRepository.SearchPlayerByName(searchedInfo);
                        if (list != null && list.Count > 0)
                            this.playersListToDataTable(list);
                        else
                            this.editPlayersVM.SetMessage("Empty", "There is no player according to searched information!");
                    }
                }
                else
                {
                    this.editPlayersVM.LoadCommand.Execute();
                    this.editPlayersVM.SetMessage("Empty", "The searched information is empty!");
                }
            }
            catch (Exception exception)
            {
                this.editPlayersVM.SetMessage("Exception - Player Search", exception.ToString());
            }
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void playersListToDataTable(List<Player> list)
        {
            foreach (Player p in list)
                this.editPlayersVM.PlayersTable.Rows.Add(p.PlayerID, p.FullName, p.Email, p.Age, p.Password, p.Score);
        }
    }
}
