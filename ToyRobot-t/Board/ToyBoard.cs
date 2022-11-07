using ToySimulator.Toy;
using ToySimulator.ToyBoard.Interface;

namespace ToySimulator.ToyBoard
{
    
    public class ToyBoard : IToyBoard
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public ToyBoard(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
        }

        public bool IsValidPosition(Position position)
        {
            return position.X < Columns && position.X >= 0 && 
                   position.Y < Rows && position.Y >= 0;
        }
    }
}
