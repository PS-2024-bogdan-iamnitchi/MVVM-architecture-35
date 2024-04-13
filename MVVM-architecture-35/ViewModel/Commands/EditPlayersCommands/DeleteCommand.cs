using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class DeleteCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public DeleteCommand(EditPlayersVM editPlayersVM)
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
                    bool result = playerRepository.DeletePlayer(selectedID);
                    if (result)
                    {
                        this.editPlayersVM.SetMessage("Success!", "Deletion was completed successfully!");
                        this.editPlayersVM.LoadCommand.Execute();
                        this.editPlayersVM.ResetFieldsCommand.Execute();
                    }
                    else
                        this.editPlayersVM.SetMessage("Failure!", "Deletion was ended with failure!");
                }
                else
                    this.editPlayersVM.SetMessage("Failure!", "No player has been selected to be deleted!");
            }
            catch (Exception exception)
            {
                this.editPlayersVM.SetMessage("Exception - Delete", exception.ToString());
            }
        }
    }
}
