using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.HomeCommands
{
    public class ToGameCommand : IComand
    {
        private HomeVM homeVM;

        public ToGameCommand(HomeVM homeVM)
        {
            this.homeVM = homeVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.homeVM.IsVisible = false;
            GameGUI gameGUI = new GameGUI(this.homeVM.LoggedPlayerEmail);
            gameGUI.Show();
        }
    }
}
