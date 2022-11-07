using System;
using ToySimulator.ConsoleChecker;
using ToySimulator.ConsoleChecker.Interface;
using ToySimulator.Toy;
using ToySimulator.Toy.Interface;
using ToySimulator.ToyBoard.Interface;

namespace ToySimulator
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            const string description =
@" 

  Place the Toy Robot on the table in position X,Y as below instruction:

  PLACE X,Y,F (F must be either NORTH, SOUTH, EAST or WEST)

  
                
     REPORT  
     LEFT   
     RIGHT  
     MOVE   
     EXIT  
";

            IToyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            IInputParser inputParser = new InputParser();
            IToyRobot robot = new ToyRobot();
            var simulator = new Behaviours.Behaviour(robot, squareBoard, inputParser);

            var stopApplication = false;
            Console.WriteLine(description);
            do
            {
                var command = Console.ReadLine();
                if (command == null) continue;

                if (command.Equals("EXIT"))
                    stopApplication = true;
                else
                {
                    try
                    {
                        var output = simulator.ProcessCommand(command.Split(' '));
                        if (!string.IsNullOrEmpty(output))
                            Console.WriteLine(output);
                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            } while (!stopApplication);
        }
    }
}

