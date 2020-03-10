using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class RotateRightAction : IExecute
    {
        Position position;
        public RotateRightAction(Position p)
        {
            position = p;
        }
        public void Execute()
        {
            position.SetRotateRight();
        }
    }
}
