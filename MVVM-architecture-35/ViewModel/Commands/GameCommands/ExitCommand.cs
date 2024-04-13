using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class ExitCommand : IComand
    {
        private GameVM gameVM;

        public ExitCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            if (this.gameVM.LoggedPlayerEmail == string.Empty)
            {
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.gameVM.IsVisible = false;
                return;
            }

            DialogResult result = this.gameVM.ChooseOptionMessage("Leave Game", "Do you want to save your results?");
            switch (result)
            {
                case DialogResult.Yes:
                    savePlayerScoreToDB();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    return; //stay in GameGUI
            }
            HomeGUI homeGUI = new HomeGUI(this.gameVM.LoggedPlayerEmail);
            homeGUI.Show();
            this.gameVM.IsVisible = false;
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void savePlayerScoreToDB()
        {
            PlayerRepository playerRepository = new PlayerRepository();
            Player player = null;

            try
            {
                string email = this.gameVM.LoggedPlayerEmail;
                if (email != null && email.Length != 0)
                {
                    player = playerRepository.GetPlayerByEmail(email);
                    if (player != null)
                    {
                        player.Score += this.gameVM.PlayerScore;

                        bool result = playerRepository.UpdatePlayer(player.PlayerID, player);
                        if (result)
                        {
                            this.gameVM.SetMessage("Success!", "Saving the score was completed successfully!");
                        }
                        else
                            this.gameVM.SetMessage("Failure!", "Updating was ended with failure!");
                    }
                }
            }
            catch (Exception ex)
            {
                this.gameVM.SetMessage("Exeption - GetLoggedInPlayer", ex.ToString());
            }
        }
    }
}
