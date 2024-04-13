using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class LevelChangedCommand: IComand
    {
        private GameVM gameVM;

        public LevelChangedCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            //this.gameVM.gameModel.Level = (int)this.gameVM.Level;
            //Debug.WriteLine(this.gameVM.Level);
            //this.gameVM.InitGameCommand.Execute();
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
