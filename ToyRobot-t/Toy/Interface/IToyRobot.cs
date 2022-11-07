namespace ToySimulator.Toy.Interface
{
    public interface IToyRobot
    {
        Direction Direction { get; set; }
        Position Position { get; set; }
        void Place(Position position, Direction direction);
        Position GetNextPosition();
        void RotateLeft();
        void RotateRight();   
        void Rotate(int rotationNumber);
    }
}
