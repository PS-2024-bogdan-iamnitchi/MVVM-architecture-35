using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class PlayerMovesCommand : IComand
    {
        private GameVM gameVM;

        public PlayerMovesCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
