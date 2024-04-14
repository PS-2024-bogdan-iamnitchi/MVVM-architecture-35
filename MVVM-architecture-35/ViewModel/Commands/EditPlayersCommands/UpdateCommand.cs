using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class UpdateCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public UpdateCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            PlayerRepository playerRepository = new PlayerRepository();
            try
            {
                if (this.editPlayersVM.SelectedRow != null)
                {
                    uint selectedID = Convert.ToUInt32(this.editPlayersVM.SelectedRow.Cells[0].Value);
                    Player player = this.validInformation();
                    if (player != null)
                    {
                        bool result = playerRepository.UpdatePlayer(selectedID, player);
                        if (result)
                        {
                            this.editPlayersVM.SetMessage("Success!", "Updating was completed successfully!");
                            this.editPlayersVM.LoadCommand.Execute();
                            this.editPlayersVM.ResetFieldsCommand.Execute();
                        }
                        else
                            this.editPlayersVM.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
                else
                    this.editPlayersVM.SetMessage("Failure!", "No player has been selected to be updated!");
            }
            catch (Exception exception)
            {
                this.editPlayersVM.SetMessage("Exception - Update", exception.ToString());
            }
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private Player validInformation()
        {
            uint playerID = this.editPlayersVM.PlayerID;
            if (playerID == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Player ID must be non-zero natural number!");
                return null;
            }
            string fullName = this.editPlayersVM.FullName;
            if (fullName == null || fullName.Length == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Player name is empty!");
                return null;
            }
            string email = this.editPlayersVM.Email;
            if (email == null || email.Length == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Email field is empty!");
                return null;
            }
            uint age = this.editPlayersVM.Age;
            if (age <= 10)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Player age must be greater or equal with 10!");
                return null;
            }
            string password = this.editPlayersVM.Password;
            if (password == null || password.Length == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Password field is empty!");
                return null;
            }
            uint score = this.editPlayersVM.Score;
            if (score < 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Player score must be greater or equal with 0!");
                return null;
            }
            return new Player(playerID, string.Empty, fullName, email, age, password, score);
        }
    }
}
