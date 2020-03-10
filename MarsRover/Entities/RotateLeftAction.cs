using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class RotateLeftAction : IExecute
    {
        Position position;
        public RotateLeftAction(Position p)
        {
            position = p;
        }
        public void Execute()
        {
            position.SetRotateLeft();
        }
    }
}
