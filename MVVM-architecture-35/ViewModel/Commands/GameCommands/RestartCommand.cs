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
            this.gameVM.PlayerScore = 0;
            this.gameVM.OponentScore = 0;

            this.gameVM.PlayerColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.gameVM.OponentColor = System.Drawing.Color.FromArgb(210, 210, 210);

            this.gameVM.InitGameCommand.Execute();
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
