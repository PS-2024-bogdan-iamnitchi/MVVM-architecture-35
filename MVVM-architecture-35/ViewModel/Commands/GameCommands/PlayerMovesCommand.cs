using MVVM_architecture_35.Model;
using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class PlayerMovesCommand : ICommand
    {
        private GameVM gameVM;

        public event EventHandler CanExecuteChanged;
        public PlayerMovesCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute(object parameter)
        {
            ParameterObject param = parameter as ParameterObject;
            if (this.gameVM.gameModel.Turn == 0)
            {
                this.checkGameEnded(this.gameVM.gameModel.Turn);
                this.applyMove(param.Dir, param.Color, param.Row, param.Col);
                this.updateGridView(param.Dir, param.Color, param.Row, param.Col);
                this.gameVM.gameModel.Turn = 1 - this.gameVM.gameModel.Turn;

                this.gameVM.OponentColor = System.Drawing.Color.Red;
                this.gameVM.PlayerColor = System.Drawing.Color.FromArgb(210, 210, 210);
                this.gameVM.CPUStart = true;
            }
        }
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void updateGridView(Direction dir, Model.Color color, int row, int col)
        {
            string dirStr = dir.ToString().ToLower();
            string colorStr = color.ToString().ToLower();
            string imageName = $"{colorStr}_{dirStr}";
            this.gameVM.ButtonsGrid[row, col].BackgroundImageLayout = ImageLayout.Stretch;
            this.gameVM.ButtonsGrid[row, col].BackgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as System.Drawing.Image;
            this.gameVM.ButtonsGrid[row, col].Enabled = false;
        }

        private List<(int, int)> applyMove(Direction dir, Model.Color color, int row, int col)
        {
            this.gameVM.gameModel.Board[row, col].Direction = dir;
            this.gameVM.gameModel.Board[row, col].Color = color;
            return removeAllowedDirection(dir, row, col);
        }

        private List<(int, int)> removeAllowedDirection(Direction dir, int row, int col)
        {
            List<(int, int)> modifiedPosition = new List<(int, int)>();
            if (this.gameVM.gameModel.Level >= 1)
            {
                for (int j = 0; j < this.gameVM.gameModel.BoardSize; j++)
                {
                    if (this.gameVM.gameModel.Board[row, j].AllowedDirections.Contains(dir))
                    {
                        this.gameVM.gameModel.Board[row, j].RemoveAllowedDirection(dir);
                        modifiedPosition.Add((row, j));
                    }
                }
                for (int i = 0; i < this.gameVM.gameModel.BoardSize; i++)
                {
                    if (this.gameVM.gameModel.Board[i, col].AllowedDirections.Contains(dir))
                    {
                        this.gameVM.gameModel.Board[i, col].RemoveAllowedDirection(dir);
                        modifiedPosition.Add((i, col));
                    }
                }
            }
            if (this.gameVM.gameModel.Level >= 2)
            {
                for (int i = 0; i < this.gameVM.gameModel.BoardSize; i++)
                {
                    for (int j = 0; j < this.gameVM.gameModel.BoardSize; j++)
                    {
                        if (Math.Abs(row - i) == Math.Abs(col - j))
                        {
                            if (this.gameVM.gameModel.Board[i, j].AllowedDirections.Contains(dir))
                            {
                                this.gameVM.gameModel.Board[i, j].RemoveAllowedDirection(dir);
                                modifiedPosition.Add((i, j));
                            }
                        }
                    }
                }
            }
            for (int i = this.gameVM.gameModel.Board[row, col].AllowedDirections.Count - 1; i >= 0; i--)
            {
                this.gameVM.gameModel.Board[row, col].AllowedDirections.RemoveAt(i);
                modifiedPosition.Add((row, col));
            }
            return modifiedPosition;
        }

        private void checkGameEnded(int turn)
        {
            var gameOutcome = this.gameVM.gameModel.CheckGameOutcome(turn);
            if (gameOutcome == GameOutcome.Lose)
            {
                this.gameVM.SetMessage("Game Over!", "You have lost the game!");
                this.gameVM.OponentScore += 1;
                this.gameVM.CPUStart = false;
                this.gameVM.InitGameCommand.Execute();
                this.gameVM.Reset = true;
                return;
            }
            if (gameOutcome == GameOutcome.Draw)
            {
                this.gameVM.SetMessage("Draw!", "Not Good not bad");
                this.gameVM.OponentScore += 1;
                this.gameVM.PlayerScore += 1;
                this.gameVM.CPUStart = false;
                this.gameVM.InitGameCommand.Execute();
                this.gameVM.Reset = true;
                return;
            }
            if (gameOutcome == GameOutcome.Win)
            {
                this.gameVM.SetMessage("Congratulation!", "You have win the game!");
                this.gameVM.PlayerScore += 1;
                this.gameVM.CPUStart = false;
                this.gameVM.InitGameCommand.Execute();
                this.gameVM.Reset = true;
                return;
            }
        }
    }
}
