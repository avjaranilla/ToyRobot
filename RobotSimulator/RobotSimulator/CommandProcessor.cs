using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    public class CommandProcessor
    {
        private ToyRobot _robot;

        public CommandProcessor(ToyRobot robot)
        {
            _robot = robot;
        }

        public void ExecuteCommand(string command)
        {
            var parts = command.Split(' '); // This will split into multiple parts by spaces.. if place command has space in between it will be invalid place command. 
            switch (parts[0])
            {
                case "PLACE":
                    if (parts.Length > 1 && 
                        TryParsePlaceCommand(parts[1], out var x, out var y, out var facing))
                    {
                        _robot.Place(x, y, facing);
                    }
                    break;
                case "MOVE":
                    _robot.Move();
                    break;
                case "LEFT":
                    _robot.RotateLeft();
                    break;
                case "RIGHT":
                    _robot.RotateRight();
                    break;
                case "REPORT":
                    Console.WriteLine(_robot.Report());
                    break;
            }
        }

        private static bool TryParsePlaceCommand(string arg, out int x, out int y, out Direction facing)
        {
            x = y = 0;
            facing = Direction.NORTH;

            var parts = arg.Split(',');
            if (parts.Length != 3 || 
                !int.TryParse(parts[0], out x) || 
                !int.TryParse(parts[1], out y) ||
                !Enum.TryParse(parts[2], out facing))
            {
                return false;
            }

            return true;
        }
    }

}
