using System;
using System.Collections.Generic;

namespace MVVM_architecture_35.Model
{
    public enum Color
    {
        None = 0,
        Red = 1,
        Green = 2,
        Blue = 3,
        Yellow = 4,
        Orange = 5,
    }

    public enum Direction
    {
        None = 0,
        North = 1,
        East = 2,
        South = 3,
        West = 4,
        Center = 5,
        NorthEast = 6,
        SouthEast = 7,
        NorthWest = 8,
        SouthWest = 9,
    }

    public class Arrow
    {
        private Color color;
        private Direction direction;
        private List<Direction> allowedDirections;

        public Arrow()
        {
            this.color = Color.None;
            this.direction = Direction.None;
            this.allowedDirections = new List<Direction>();
        }

        public Arrow(int level)
        {
            this.color = Color.None;
            this.direction = Direction.None;
            this.allowedDirections = GetAllowedDirections(level);
        }

        public Arrow(Color color, int level)
        {
            this.color = color;
            this.direction = Direction.None;
            this.allowedDirections = GetAllowedDirections(level);
        }

        public Arrow(Arrow arrow)
        {
            this.color = arrow.color;
            this.direction = arrow.direction;
            this.allowedDirections = arrow.allowedDirections;
        }

        public Arrow(Color color, Direction direction, List<Direction> allowedDirection)
        {
            this.color = color;
            this.direction = direction;
            this.allowedDirections = allowedDirection;
        }

        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Direction Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }

        public List<Direction> AllowedDirections
        {
            get { return this.allowedDirections; }
            set { this.allowedDirections = value; }
        }

        public void AddAllowedDirection(Direction dir)
        {
            this.allowedDirections.Add(dir);
        }

        public void RemoveAllowedDirection(Direction dir)
        {
             this.allowedDirections.Remove(dir);
        }

        public List<Direction> GetAllowedDirections(int level)
        {
            List<Direction> directions = new List<Direction>();
            if (level >= 1)
            {
                directions.Add(Direction.North);
                directions.Add(Direction.East);
                directions.Add(Direction.South);
                directions.Add(Direction.West);
                directions.Add(Direction.Center);
            }
            if (level >= 2)
            {
                directions.Add(Direction.NorthEast);
                directions.Add(Direction.SouthEast);
                directions.Add(Direction.NorthWest);
                directions.Add(Direction.SouthWest);
            }
            return directions;
        }

        public static (int, int) DirectionToIndex(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return (0, 1);
                case Direction.South:
                    return (2, 1);
                case Direction.East:
                    return (1, 2);
                case Direction.West:
                    return (1, 0);
                case Direction.Center:
                    return (1, 1);
                case Direction.NorthEast:
                    return (0, 2);
                case Direction.SouthEast:
                    return (2, 2);
                case Direction.NorthWest:
                    return (0, 0);
                case Direction.SouthWest:
                    return (2, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), "Unknown direction");
            }
        }

        public override string ToString()
        {
            string s = "";
            s += " (" + this.color.ToString() + ", " + this.direction.ToString() + ") ";

            return s;
        }
    }
}
