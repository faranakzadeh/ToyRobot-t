using ToySimulator.ConsoleChecker.Interface;
using ToySimulator.Toy;

namespace ToySimulator.ConsoleChecker
{
    public class PlaceCommandParameter
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public PlaceCommandParameter(Position position,Direction direction)
        {
            Position = position;
            Direction = direction;
        }
    }
}
