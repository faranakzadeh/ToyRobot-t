using System;
using ToySimulator.Toy;

namespace ToySimulator.ConsoleChecker.Interface
{
    public interface IInputParser
    {
        Command ParseCommand(string[] rawInput);      
        PlaceCommandParameter ParseCommandParameter(string[] input);
    }
}
