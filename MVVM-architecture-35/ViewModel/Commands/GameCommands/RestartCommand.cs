using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class RestartCommand : IComand
    {
        private GameVM gameVM;

        public RestartCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            Debug.WriteLine("Restart");
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
