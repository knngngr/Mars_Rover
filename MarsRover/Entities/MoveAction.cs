using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class MoveAction : IExecute
    {
        Position position;
        public MoveAction(Position p)
        {
            position = p;
        }
        public void Execute()
        {
            position.SetMove();
        }
    }
}
