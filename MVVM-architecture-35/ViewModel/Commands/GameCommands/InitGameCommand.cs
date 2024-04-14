using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MVVM_architecture_35.ViewModel.Commands.GameCommands
{
    public class InitGameCommand : IComand
    {
        private GameVM gameVM;

        public InitGameCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.initAttributesFromVM();
            this.createButtonsGrid();

            this.gameVM.gameModel.Board = this.gameVM.gameModel.GetNewBoard();
            this.gameVM.gameModel.GameState = GameState.Init;
            this.gameVM.gameModel.GameOutcome = GameOutcome.None;
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void initAttributesFromVM()
        {
            this.gameVM.Level = (uint)this.gameVM.gameModel.Level;
            if (this.gameVM.LoggedPlayerEmail != string.Empty)
            {
                this.gameVM.ScoreVisible = true;
                this.gameVM.Score = getLoggedInPlayerScore();
            }
            else
            {
                this.gameVM.ScoreVisible = false;
            }

            this.gameVM.CPUStart = false;

            this.gameVM.PlayerColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.gameVM.PlayerMovesImage = Properties.Resources.ResourceManager.GetObject("green_level" + this.gameVM.Level) as System.Drawing.Image;

            this.gameVM.OponentColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.gameVM.OponentMovesImage = Properties.Resources.ResourceManager.GetObject("red_level" + this.gameVM.Level) as System.Drawing.Image;

            this.gameVM.PlayButtonImage = Properties.Resources.start;
        }
        private uint getLoggedInPlayerScore()
        {
            PlayerRepository playerRepository = new PlayerRepository();
            Player player = null;

            try
            {
                string email = this.gameVM.LoggedPlayerEmail;
                if (email != null && email.Length != 0)
                {
                    player = playerRepository.GetPlayerByEmail(email);
                }
            }
            catch (Exception ex)
            {
                this.gameVM.SetMessage("Exeption - GetLoggedInPlayer", ex.ToString());
            }
            return player.Score;
        }

        private void createButtonsGrid()
        {
            int size = this.gameVM.gameModel.BoardSize;
            this.gameVM.ButtonsGrid = new Button[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Button button;
                    if (this.gameVM.gameModel.Level == 1)
                    {
                        button = this.gameVM.GetButtonWithStyle(row, col, 90, 15);
                    }
                    else
                    {
                        button = this.gameVM.GetButtonWithStyle(row, col, 45, 10);
                    }

                    button.Click += (sender, e) =>
                    {
                        this.gridButtonEvent(sender, e);
                    };
                    this.gameVM.ButtonsGrid[row, col] = button; ;
                }
            }
        }
        private void gridButtonEvent(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
            {
                return;
            }

            int size = this.gameVM.gameModel.BoardSize;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (this.gameVM.ButtonsGrid[row, col] == clickedButton)
                    {
                        this.GridButtonPressed(row, col);
                        return;
                    }
                }
            }
        }
        public void GridButtonPressed(int row, int col)
        {
            if (this.gameVM.gameModel.GameState != GameState.Started)
            {
                this.gameVM.SetMessage("Failure!", "Please start the game first!");
                return;
            }
            if (this.gameVM.gameModel.Turn != 0)
            {
                this.gameVM.SetMessage("Failure!", "Not your turn!");
                return;
            }

            Model.Color color = this.gameVM.gameModel.Board[row, col].Color = Model.Color.Green;
            Form messageBox = this.gameVM.CreateSelectArrowMessageBox("Game notification", "Please select your move:");
            TableLayoutPanel dirButtonsTable = this.gameVM.CreateChooseDirectionTable();

            List<Direction> allowedDir = this.gameVM.gameModel.Board[row, col].AllowedDirections;
            foreach (Direction dir in allowedDir)
            {
                string imageName = $"{color.ToString().ToLower()}_{dir.ToString().ToLower()}";
                Button dirButton = this.gameVM.CreateDirectionButton(imageName);
                dirButton.Click += (sender, e) =>
                {
                    this.gameVM.PlayerMoveCommand.Execute(new ParameterObject { Dir = dir, Color = color, Row = row, Col = col });
                    messageBox.Close();
                };
                (int t_row, int t_col) = Arrow.DirectionToIndex(dir);
                dirButtonsTable.Controls.Add(dirButton, t_col, t_row);
            }
            messageBox.Controls.Add(dirButtonsTable);
            messageBox.ShowDialog();
        }
    }

    class ParameterObject
    {
        public Direction Dir { get; set; }
        public Model.Color Color { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
