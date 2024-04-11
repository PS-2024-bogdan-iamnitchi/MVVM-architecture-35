using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.LoginCommands
{
    public class ToGameCommand : IComand
    {
        private LoginVM loginVM;

        public ToGameCommand(LoginVM loginVM)
        {
            this.loginVM = loginVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.loginVM.IsVisible = false;
            GameGUI gameGUI = new GameGUI("");
            gameGUI.Show();
        }

    }
}
