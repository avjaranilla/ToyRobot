using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    public struct Position
    {
        public int X { get; }
        public int Y { get;}
        public Direction Facing { get;}

        public Position(int x, int y, Direction facing)
        {
            X = x;
            Y = y;
            Facing = facing;
        }


        // Add Deconstructor for extracting values
        public void Deconstruct(out int x, out int y, out Direction facing)
        {
            x = X;
            y = Y;
            facing = Facing;
        }
    }
}
