using System.Collections.Generic;

namespace MVVM_architecture_35.Model
{
    public enum GameState
    {
        Init = 0,
        Started = 1,
        Paused = 2,
        Ended = 3
    }

    public enum GameOutcome
    {
        None = 0,
        Win = 1,
        Draw = 2,
        Lose = 3
    }

    public class GameModel
    {
        private Arrow[,] board;
        private int level;
        private int boardSize;
        private GameState gameState;
        private GameOutcome gameOutcome;
        private int turn;

        public GameModel()
        {
            this.boardSize = 4;
            this.level = 1;
            this.board = this.GetNewBoard();
            this.gameState = GameState.Init;
            this.gameOutcome = GameOutcome.None;
            this.turn = 0;
        }

        public GameModel(GameModel gameModel)
        {
            this.board = gameModel.board;
            this.boardSize = gameModel.boardSize;
            this.level = gameModel.level;
            this.gameState = GameState.Init;
            this.gameOutcome = GameOutcome.None;
            this.turn = 0;
        }

        public GameModel(int boardSize, int level)
        {
            this.boardSize = boardSize;
            this.level = level;
            this.board = this.GetNewBoard();
            this.gameState = GameState.Init;
            this.gameOutcome = GameOutcome.None;
            this.turn = 0;
        }

        public Arrow[,] Board
        {
            get { return this.board; }
            set { this.board = value; }
        }

        public int BoardSize
        {
            get { return this.boardSize; }
            set 
            { 
                this.boardSize = value;
                this.board = GetNewBoard();
            }
        }

        public int Level
        {
            get { return this.level; }
            set { 
                if(value == 1)
                {
                    this.level = value;
                    this.BoardSize = 4;
                }
                else if(value == 2)
                {
                    this.level = value;
                    this.BoardSize = 8;
                }
            }
        }

        public GameState GameState
        {
            get { return this.gameState; }
            set { this.gameState = value; }
        }
        public GameOutcome GameOutcome
        {
            get { return this.gameOutcome; }
            set { this.gameOutcome = value; }
        }

        public int Turn
        {
            get { return this.turn; }
            set { this.turn = value; }
        }

        public int mapGameOutcomeToValue(GameOutcome gameOutcome)
        {
            Dictionary<GameOutcome, int> outcomeValues = new Dictionary<GameOutcome, int>
            {
                { GameOutcome.Win, 1000 },
                { GameOutcome.Draw, 0 },
                { GameOutcome.Lose, -1000 }
            };
            return outcomeValues[gameOutcome];
        }

        public GameOutcome CheckGameOutcome(int turn)
        {
            int count = 0;
            bool iHaveMoves = false;
            GameOutcome gameOutcome = GameOutcome.None;

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {
                    if (this.Board[i, j].Direction == Direction.None)
                    {
                        count += 1;
                        if(this.Board[i, j].AllowedDirections.Count != 0)
                        {
                            iHaveMoves = true;
                        }
                    }
                }
            }
            if(count == 0)
            {
                gameOutcome = GameOutcome.Draw;
            }
            else if(iHaveMoves == false && turn == 0)
            {
                gameOutcome = GameOutcome.Lose;
            }
            else if (iHaveMoves == false && turn == 1)
            {
                gameOutcome = GameOutcome.Win;
            }

            return gameOutcome;
        }

        public GameState CheckGameState(int turn)
        {
            int count = 0;
            bool iHaveMoves = false;
            GameState gameState = this.GameState;

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {
                    if (this.Board[i, j].Direction == Direction.None)
                    {
                        count += 1;
                        if (this.Board[i, j].AllowedDirections.Count != 0)
                        {
                            iHaveMoves = true;
                        }
                    }
                }
            }
            if (count == 0)
            {
                gameState = GameState.Ended;
            }
            else if (iHaveMoves == false && turn == 0)
            {
                gameState = GameState.Ended;
            }
            else if (iHaveMoves == false && turn == 1)
            {
                gameState = GameState.Ended;
            }

            return gameState;
        }

        public bool MoveAvailable(int row, int col)
        {
            if (this.Board[row, col].Direction == Direction.None && this.Board[row, col].AllowedDirections.Count > 0)
            {
                return true;
            }
            return false;
        }

        public Arrow[,] GetNewBoard()
        {
            board = new Arrow[this.boardSize, this.boardSize];
            for (int i = 0; i < this.Board.GetLength(0); i++)
            {
                for (int j = 0; j < this.Board.GetLength(1); j++)
                {
                    this.Board[i, j] = new Arrow(this.level);
                }
            }
            return board;
        }

        public override string ToString()
        {
            string s = "Game Model: \n";
            s += " - BoardSize: " + this.BoardSize.ToString() + "\n";
            s += " - Level: " + this.Level.ToString() + "\n";
            for (int i = 0; i < this.Board.GetLength(0); i++)
            {
                for (int j = 0; j < this.Board.GetLength(1); j++)
                {
                    s += this.Board[i, j].ToString();
                }
                s += "\n";
            }
            s += "\n";

            return s;
        }
    }
}
