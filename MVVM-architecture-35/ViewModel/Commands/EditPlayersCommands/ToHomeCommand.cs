using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class ToHomeCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public ToHomeCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.editPlayersVM.IsVisible = false;
            HomeGUI homeGUI = new HomeGUI(editPlayersVM.LoggedPlayerEmail);
            homeGUI.Show();
        }
    }
}
