// See https://aka.ms/new-console-template for more information
using RobotSimulator;

var robot = new ToyRobot();
var processor = new CommandProcessor(robot);

//var commands = File.ReadAllLines("commands.txt");
var commands = File.ReadAllLines("../../../commands.txt"); // Project Directory

foreach (var command in commands)
{
    processor.ExecuteCommand(command.Trim());
}

Console.ReadLine();
