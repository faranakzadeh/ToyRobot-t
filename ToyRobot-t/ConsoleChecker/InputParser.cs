using System;
using ToySimulator.ConsoleChecker.Interface;
using ToySimulator.Toy;

namespace ToySimulator.ConsoleChecker
{
    public class InputParser : IInputParser
    {
        public Command ParseCommand(string[] rawInput)
        {
            Command command;
            if (!Enum.TryParse(rawInput[0], true, out command))
                throw new ArgumentException("Sorry, your command was not recognised. Please try again using the following format: PLACE X,Y,F|MOVE|LEFT|RIGHT|REPORT");          
            return command;
        }      
        public PlaceCommandParameter ParseCommandParameter( string[] input)
        {
            var thisPlaceCommandParameter = new PlaceCommandParameterParser();     
            return thisPlaceCommandParameter.ParseParameters(input);
        }     
    }



}
