using MVVM_architecture_35.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (this.gameVM.gameModel.Turn == 1)
            {
                this.checkGameEnded(this.gameVM.gameModel.Turn);
                this.cpuMoves();
                this.gameVM.gameModel.Turn = 1 - this.gameVM.gameModel.Turn;

                this.gameVM.PlayerColor = System.Drawing.Color.FromArgb(40, 196, 36);
                this.gameVM.OponentColor = System.Drawing.Color.FromArgb(210, 210, 210);
                this.gameVM.CPUStart = false;
            }
            if (this.gameVM.gameModel.GameState != GameState.Ended)
            {
                this.checkGameEnded(this.gameVM.gameModel.Turn);
            }
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void cpuMoves()
        {
            int bestScore = int.MaxValue;
            (Direction, int, int) bestMove = (Direction.None, 0, 0);
            Model.Color color = Model.Color.Red;

            for (int i = 0; i < this.gameVM.gameModel.BoardSize; i++)
            {
                for (int j = 0; j < this.gameVM.gameModel.BoardSize; j++)
                {
                    if (this.gameVM.gameModel.MoveAvailable(i, j))
                    {
                        List<Direction> allowedDir = cloneListDir(this.gameVM.gameModel.Board[i, j].AllowedDirections);
                        foreach (Direction dir in allowedDir)
                        {
                            var modifiedPosition = applyMove(dir, color, i, j);
                            int score = minimax(0, 0);
                            resetMove(dir, i, j, modifiedPosition);

                            if (score < bestScore)
                            {
                                bestScore = score;
                                bestMove = (dir, i, j);
                            }
                        }
                        this.gameVM.gameModel.Board[i, j].AllowedDirections = allowedDir;
                    }
                }
            }
            (Direction bestDir, int row, int col) = bestMove;
            if (this.gameVM.gameModel.GameState == GameState.Started)
            {
                applyMove(bestDir, color, row, col);
                updateGridView(bestDir, color, row, col);
            }
        }

        private int minimax(int depth, int turn)
        {
            var result = this.gameVM.gameModel.CheckGameOutcome(turn);
            if (result != GameOutcome.None || depth == 1)
            {
                return evaluateGameModel(result);
            }

            if (turn == 0)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < this.gameVM.gameModel.BoardSize; i++)
                {
                    for (int j = 0; j < this.gameVM.gameModel.BoardSize; j++)
                    {
                        if (this.gameVM.gameModel.MoveAvailable(i, j))
                        {
                            List<Direction> allowedDir = cloneListDir(this.gameVM.gameModel.Board[i, j].AllowedDirections);
                            foreach (Direction dir in allowedDir)
                            {
                                var modifiedPosition = applyMove(dir, Model.Color.Green, i, j);
                                int score = minimax(depth + 1, 1);
                                resetMove(dir, i, j, modifiedPosition);

                                bestScore = Math.Max(score, bestScore);
                            }
                            this.gameVM.gameModel.Board[i, j].AllowedDirections = allowedDir;
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < this.gameVM.gameModel.BoardSize; i++)
                {
                    for (int j = 0; j < this.gameVM.gameModel.BoardSize; j++)
                    {
                        if (this.gameVM.gameModel.MoveAvailable(i, j))
                        {
                            List<Direction> allowedDir = cloneListDir(this.gameVM.gameModel.Board[i, j].AllowedDirections);
                            foreach (Direction dir in allowedDir)
                            {
                                var modifiedPosition = applyMove(dir, Model.Color.Red, i, j);
                                int score = minimax(depth + 1, 0);
                                resetMove(dir, i, j, modifiedPosition);

                                bestScore = Math.Min(score, bestScore);
                            }
                            this.gameVM.gameModel.Board[i, j].AllowedDirections = allowedDir;
                        }
                    }
                }
                return bestScore;
            }
        }

        private int evaluateGameModel(GameOutcome result)
        {
            int score = 0;
            if (result != GameOutcome.None)
            {
                score += this.gameVM.gameModel.mapGameOutcomeToValue(result);
            }
            for (int i = 0; i < this.gameVM.gameModel.BoardSize; i++)
            {
                for (int j = 0; j < this.gameVM.gameModel.BoardSize; j++)
                {
                    score += this.gameVM.gameModel.Board[i, j].AllowedDirections.Count;
                }
            }
            return score;
        }

        private List<Direction> cloneListDir(List<Direction> list)
        {
            List<Direction> newList = new List<Direction>();
            foreach (Direction dir in list)
            {
                newList.Add(dir);
            }
            return newList;
        }

        private List<(int, int)> applyMove(Direction dir, Model.Color color, int row, int col)
        {
            this.gameVM.gameModel.Board[row, col].Direction = dir;
            this.gameVM.gameModel.Board[row, col].Color = color;
            return removeAllowedDirection(dir, row, col);
        }

        private void resetMove(Direction dir, int row, int col, List<(int, int)> modifiedPosition)
        {
            this.gameVM.gameModel.Board[row, col].Direction = Direction.None;
            this.gameVM.gameModel.Board[row, col].Color = Model.Color.None;
            addAllowedDirection(modifiedPosition, dir);
        }

        private void addAllowedDirection(List<(int, int)> modifiedPosition, Direction dir)
        {
            foreach ((int i, int j) in modifiedPosition)
            {
                this.gameVM.gameModel.Board[i, j].AddAllowedDirection(dir);
            }
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

        private void updateGridView(Direction dir, Model.Color color, int row, int col)
        {
            string dirStr = dir.ToString().ToLower();
            string colorStr = color.ToString().ToLower();
            string imageName = $"{colorStr}_{dirStr}";
            this.gameVM.ButtonsGrid[row, col].BackgroundImageLayout = ImageLayout.Stretch;
            this.gameVM.ButtonsGrid[row, col].BackgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as System.Drawing.Image;
            this.gameVM.ButtonsGrid[row, col].Enabled = false;
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
