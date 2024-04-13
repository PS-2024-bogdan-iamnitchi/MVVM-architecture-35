using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Debug.WriteLine("Exit");
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
