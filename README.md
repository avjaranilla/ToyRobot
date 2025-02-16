🚀 Toy Robot Simulator
A simple C# console application that simulates a toy robot moving on a 5x5 tabletop, following a set of commands. The robot avoids falling off the table and responds to movement, rotation, and reporting commands.

📌 Features
Supports PLACE X,Y,FACING to position the robot.
Allows MOVE, LEFT, RIGHT commands to navigate.
Prevents the robot from falling off the table.
REPORT command outputs the robot's current position.
Accepts commands from a file (commands.txt).

📥 Installation
Clone the repository:
  git clone https://github.com/avjaranilla/ToyRobot.git
  cd ToyRobot
Open the project in Visual Studio or VS Code.

Build and run the application:
  dotnet run

📝 How to Use:
Using a File (commands.txt)
Create a file named commands.txt in the project directory (not bin/Debug), and add commands:

PLACE 0,0,NORTH
MOVE
RIGHT
MOVE
REPORT

Then, run the program. It will read from commands.txt and execute the commands. Expected Output: 1,1,EAST.


🛠 Commands Overview
Command	Description:
PLACE X,Y,FACING	- Places the robot at (X, Y) facing NORTH, SOUTH, EAST, or WEST.
MOVE -------------- Moves the robot one step forward in the direction it's facing.
LEFT -------------- Rotates the robot 90° left (counter-clockwise).
RIGHT	------------- Rotates the robot 90° right (clockwise).
REPORT ------------	Prints the robot’s current position and direction.
