using MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands;
using MVVM_architecture_35.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVM_architecture_35.ViewModel.Commands.GameCommands;
using System.Drawing;
using MVVM_architecture_35.Model;
using System.Diagnostics;
using System.Windows.Input;

namespace MVVM_architecture_35.ViewModel
{
    public class GameVM : INotifyPropertyChanged
    {
        private uint level;
        private uint score;
        private bool scoreVisible;
        private uint playerScore;
        private uint oponentScore;
        private bool cpuStart;
        private bool reset;

        private string loggedPlayerEmail;
        private bool isVisible;

        private System.Drawing.Color playerColor;
        private System.Drawing.Color oponentColor;

        private Image playButtonImage;
        private Image playerMovesImage;
        private Image oponentMovesImage;

        public IComand InitGameCommand;
        public IComand PlayCommand;
        public IComand RestartCommand;
        public IComand ExitCommand;
        public IComand LevelChangedCommand;
        public IComand CPUMovesCommand;
        public ICommand PlayerMoveCommand;

        public Button[,] ButtonsGrid;
        public GameModel gameModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public GameVM(string loggedPlayerEmail)
        {
            this.gameModel = new GameModel();

            this.loggedPlayerEmail = loggedPlayerEmail;
            this.isVisible = true;
            this.playerScore = 0;
            this.oponentScore = 0;

            this.InitGameCommand = new InitGameCommand(this);
            this.InitGameCommand.Execute();
            
            this.PlayCommand = new PlayCommand(this);
            this.RestartCommand = new RestartCommand(this);
            this.ExitCommand = new ExitCommand(this);
            this.LevelChangedCommand = new LevelChangedCommand(this);
            this.CPUMovesCommand = new CPUMovesCommand(this);
            this.PlayerMoveCommand = new PlayerMovesCommand(this);

        }

        public uint Level
        {
            get { return this.level; }
            set
            {
                this.level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public uint Score
        {
            get { return this.score; }
            set
            {
                this.score = value;
                OnPropertyChanged(nameof(Score));
            }
        }
        public bool ScoreVisible
        {
            get { return this.scoreVisible; }
            set
            {
                this.scoreVisible = value;
                OnPropertyChanged(nameof(ScoreVisible));
            }
        }
        public uint PlayerScore
        {
            get { return this.playerScore; }
            set
            {
                this.playerScore = value;
                OnPropertyChanged(nameof(PlayerScore));
            }
        }
        public uint OponentScore
        {
            get { return this.oponentScore; }
            set
            {
                this.oponentScore = value;
                OnPropertyChanged(nameof(OponentScore));
            }
        }
        public bool CPUStart
        {
            get { return this.cpuStart; }
            set
            {
                this.cpuStart = value;
                OnPropertyChanged(nameof(CPUStart));
            }
        }
        public bool Reset
        {
            get { return this.reset; }
            set
            {
                this.reset = value;
                OnPropertyChanged(nameof(Reset));
            }
        }
        public System.Drawing.Color PlayerColor
        {
            get { return this.playerColor; }
            set
            {
                this.playerColor = value;
                OnPropertyChanged(nameof(PlayButtonImage));
            }
        }
        public System.Drawing.Color OponentColor
        {
            get { return this.oponentColor; }
            set
            {
                this.oponentColor = value;
                OnPropertyChanged(nameof(OponentColor));
            }
        }
        public Image PlayButtonImage
        {
            get { return this.playButtonImage; }
            set
            {
                this.playButtonImage = value;
                OnPropertyChanged(nameof(PlayButtonImage));
            }
        }
        public Image PlayerMovesImage
        {
            get { return this.playerMovesImage; }
            set
            {
                this.playerMovesImage = value;
                OnPropertyChanged(nameof(PlayerMovesImage));
            }
        }
        public Image OponentMovesImage
        {
            get { return this.oponentMovesImage; }
            set
            {
                this.oponentMovesImage = value;
                OnPropertyChanged(nameof(OponentMovesImage));
            }
        }

        public string LoggedPlayerEmail
        {
            get { return this.loggedPlayerEmail; }
            set
            {
                this.loggedPlayerEmail = value;
                OnPropertyChanged(nameof(LoggedPlayerEmail));
            }
        }
        public bool IsVisible
        {
            get { return this.isVisible; }
            set
            {
                this.isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public Button GetButtonWithStyle(int row, int col, int buttonSize, int spacing)
        {
            int locGridX = 55;
            int locGridY = 200;

            Button button = new Button();
            button.Size = new System.Drawing.Size(buttonSize, buttonSize);
            button.Location = new System.Drawing.Point(col * (buttonSize + spacing) + locGridX, row * (buttonSize + spacing) + locGridY);
            button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button.Cursor = Cursors.Hand;

            return button;
        }
        public Form CreateSelectArrowMessageBox(string title, string message)
        {
            Form messageForm = new Form();
            messageForm.Text = title;
            messageForm.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            messageForm.ClientSize = new Size(330, 330);
            messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            messageForm.StartPosition = FormStartPosition.CenterParent;
            messageForm.BackColor = System.Drawing.Color.FromArgb(44, 44, 44);
            //messageForm.Location = new Point(this.Right / 2 + 55, this.Top + 200);

            Label label = new Label();
            label.Text = message;
            label.Font = new Font("Arial Rounded MT Bold", 14, FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.FromArgb(210, 210, 210);
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point(40, 20);

            messageForm.Controls.Add(label);
            return messageForm;
        }
        public TableLayoutPanel CreateChooseDirectionTable()
        {
            TableLayoutPanel buttonsPanel = new TableLayoutPanel();
            buttonsPanel.RowCount = 3;
            buttonsPanel.ColumnCount = 3;
            buttonsPanel.Size = new Size(210, 210);
            buttonsPanel.Location = new Point(50, 60);

            buttonsPanel.AutoSize = true;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
            buttonsPanel.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            buttonsPanel.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            buttonsPanel.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 80));

            return buttonsPanel;
        }
        public Button CreateDirectionButton(string imageName)
        {
            Button button = new Button();
            button.BackgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as System.Drawing.Image;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;

            button.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.FromArgb(210, 210, 210);

            button.Dock = DockStyle.Fill;
            return button;
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }
        public DialogResult ChooseOptionMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
