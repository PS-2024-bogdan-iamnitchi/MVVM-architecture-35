using MVVM_architecture_35.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class PlayCommand : IComand
    {
        private GameVM gameVM;

        public PlayCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            if (this.gameVM.gameModel.GameState == GameState.Init || this.gameVM.gameModel.GameState == GameState.Paused)
            {
                this.gameVM.gameModel.GameState = GameState.Started;
                this.gameVM.PlayButtonImage = Properties.Resources.pause;
                this.gameVM.SetMessage("PLAY!", "Game started!");
                this.gameVM.PlayerColor = System.Drawing.Color.FromArgb(40, 196, 36);
                this.gameVM.OponentColor = System.Drawing.Color.FromArgb(210, 210, 210);
            }
            else
            {
                this.gameVM.gameModel.GameState = GameState.Paused;
                this.gameVM.PlayButtonImage = Properties.Resources.start;
                this.gameVM.SetMessage("PAUSE!", "Game is paused!");
            }
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------

    }
}
