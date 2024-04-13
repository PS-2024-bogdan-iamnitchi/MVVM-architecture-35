﻿using MVVM_architecture_35.ViewModel;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MVVM_architecture_35.View
{
    public partial class GameGUI : Form
    {
        private GameVM gameVM;
        public GameGUI(string email)
        {
            InitializeComponent();
            this.gameVM = new GameVM(email);
            this.DataBindings.Add("Visible", this.gameVM, "isVisible", false, DataSourceUpdateMode.OnPropertyChanged);

            this.nudLoggedInPlayerScore.DataBindings.Add("Value", this.gameVM, "score", false, DataSourceUpdateMode.OnPropertyChanged);
            this.nudLoggedInPlayerScore.DataBindings.Add("Visible", this.gameVM, "scoreVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            this.loggedInPlayerScoreLabel.DataBindings.Add("Visible", this.gameVM, "scoreVisible", false, DataSourceUpdateMode.OnPropertyChanged);
           
            this.nudLevel.DataBindings.Add("Value", this.gameVM, "level", false, DataSourceUpdateMode.OnPropertyChanged);

            this.playerLabel.DataBindings.Add("ForeColor", this.gameVM, "playerColor", false, DataSourceUpdateMode.OnPropertyChanged);
            this.playerMovesPictureBox.DataBindings.Add("Image", this.gameVM, "playerMovesImage", true, DataSourceUpdateMode.OnPropertyChanged);
            this.nudPlayerScore.DataBindings.Add("Value", this.gameVM, "playerScore", false, DataSourceUpdateMode.OnPropertyChanged);

            this.oponentLabel.DataBindings.Add("ForeColor", this.gameVM, "oponentColor", false, DataSourceUpdateMode.OnPropertyChanged);
            this.oponentMovesPictureBox.DataBindings.Add("Image", this.gameVM, "oponentMovesImage", true, DataSourceUpdateMode.OnPropertyChanged);
            this.nudOponentScore.DataBindings.Add("Value", this.gameVM, "oponentScore", false, DataSourceUpdateMode.OnPropertyChanged);

            this.playPauseButton.DataBindings.Add("BackgroundImage", this.gameVM, "playButtonImage", true, DataSourceUpdateMode.OnPropertyChanged);

            this.playPauseButton.Click += delegate { gameVM.PlayCommand.Execute(); };
            this.restartGameButton.Click += delegate { gameVM.RestartCommand.Execute(); };
            this.leaveGameButton.Click += delegate { gameVM.ExitCommand.Execute(); };
            this.nudLevel.ValueChanged += delegate { gameVM.LevelChangedCommand.Execute(); this.UpdateControls(); };
        
            this.timerCPU.Tick += delegate { gameVM.CPUMovesCommand.Execute(); };
            //this.timerCPU.Start();
            this.UpdateControls();
        }

        private void UpdateControls()
        {
            Debug.WriteLine("Aici");
            buttonsTableLayout.Controls.Clear();

            int boardSize = this.gameVM.gameModel.BoardSize;
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    buttonsTableLayout.Controls.Add(this.gameVM.ButtonsGrid[i, j]);
                }
            }
        }
    }
}
