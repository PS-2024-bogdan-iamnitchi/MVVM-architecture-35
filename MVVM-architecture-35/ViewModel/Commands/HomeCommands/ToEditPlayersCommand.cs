using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MVVM_architecture_35.ViewModel.Commands.HomeCommands
{
    public class ToEditPlayersCommand : IComand
    {
        private HomeVM homeVM;

        public ToEditPlayersCommand(HomeVM homeVM)
        {
            this.homeVM = homeVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            PlayerRepository playerRepository = new PlayerRepository();

            try
            {
                string email = this.homeVM.LoggedPlayerEmail;
                if (email != null && email.Length != 0)
                {
                    Player player = playerRepository.GetPlayerByEmail(email);
                    if (player != null && player.IsAdmin.Equals("Yes"))
                        this.toEditPlayersGUI(email);
                    else
                        this.homeVM.SetMessage("Not Allowed!", "You don't have rights to access this page!");
                }
            }
            catch (Exception ex)
            {
                this.homeVM.SetMessage("Exeption - Login", ex.ToString());
            }
        }
        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void toEditPlayersGUI(string email)
        {
            this.homeVM.IsVisible = false;
            EditPlayersGUI editPlayersGUI = new EditPlayersGUI(email);
            editPlayersGUI.Show();
        }
    }
}
