using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    public class ToyRobot
    {
        private const int TableSize = 5;
        private Position? _position;

        public bool IsPlaced => _position.HasValue;
        public void Place(int x, int y, Direction facing)
        {
            if (IsValidPosition(x, y))
            {
                _position = new Position(x, y, facing);
            }
        }


        public void Move()
        {
            if (!IsPlaced) return;
           
            var (x, y, facing) = _position.Value;
            switch (facing)
            {
                case Direction.NORTH: if (IsValidPosition(x, y + 1)) _position = new Position(x, y + 1, facing); break;
                case Direction.SOUTH: if (IsValidPosition(x, y - 1)) _position = new Position(x, y - 1, facing); break;
                case Direction.EAST: if (IsValidPosition(x + 1, y)) _position = new Position(x + 1, y, facing); break;
                case Direction.WEST: if (IsValidPosition(x - 1, y)) _position = new Position(x - 1, y, facing); break;
            }
        }

        public void RotateLeft()
        {
            if (!IsPlaced) return;

            Direction newFacing;
            if (_position.Value.Facing == Direction.NORTH)
            {
                newFacing = Direction.WEST;
            }
            else if (_position.Value.Facing == Direction.WEST)
            {
                newFacing = Direction.SOUTH;
            }
            else if (_position.Value.Facing == Direction.SOUTH)
            {
                newFacing = Direction.EAST;
            }
            else // Direction.EAST
            {
                newFacing = Direction.NORTH;
            }

            // Update position
            _position = new Position(_position.Value.X, _position.Value.Y, newFacing);

        }

        public void RotateRight()
        {
            if (!IsPlaced) return;
            Direction newFacing;
            if (_position.Value.Facing == Direction.NORTH)
            {
                newFacing = Direction.EAST;
            }
            else if (_position.Value.Facing == Direction.EAST)
            {
                newFacing = Direction.SOUTH;
            }
            else if (_position.Value.Facing == Direction.SOUTH)
            {
                newFacing = Direction.WEST;
            }
            else // Direction.WEST
            {
                newFacing = Direction.NORTH;
            }

            // Update position
            _position = new Position(_position.Value.X, _position.Value.Y, newFacing);

        }

        public string Report()
        {
            return IsPlaced ? $"{_position.Value.X},{_position.Value.Y},{_position.Value.Facing}" : "Robot not placed";
        }

        private static bool IsValidPosition(int x, int y)
        {
            /// Valid values: 0, 1, ,2 ,3, 4
            return x >= 0 && 
                   x < TableSize && 
                   y >= 0 && 
                   y < TableSize;
        }
    }

}
