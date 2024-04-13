using MVVM_architecture_35.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class CPUMovesCommand : IComand
    {
        private GameVM gameVM;

        public CPUMovesCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            Debug.WriteLine("Tick");
            
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
