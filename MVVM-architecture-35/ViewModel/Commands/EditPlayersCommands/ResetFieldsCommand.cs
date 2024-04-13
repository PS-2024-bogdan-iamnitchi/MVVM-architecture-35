using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class ResetFieldsCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public ResetFieldsCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.editPlayersVM.PlayerID = 0;
            this.editPlayersVM.FullName = "";
            this.editPlayersVM.Email = "";
            this.editPlayersVM.Age = 0;
            this.editPlayersVM.Password = "";
            this.editPlayersVM.Score = 0;
        }
    }
}
