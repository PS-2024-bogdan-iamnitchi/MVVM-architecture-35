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
                
            }
            catch (Exception ex)
            {
                this.editPlayersVM.SetMessage("Exeption - Update", ex.ToString());
            }
        }
    }
}
