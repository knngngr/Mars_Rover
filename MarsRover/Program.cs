using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p = new Position(5, 5);
            p.CurrentRotation = "N";
            p.X = 1;
            p.Y = 2;

            Rover r1 = new Rover();
            r1.SetPosition(p);
            r1.SetRotateList("LMLMLMLMM");
            r1.StartAction();
            Position result = r1.GetPosition();
            Console.WriteLine(result.X + " " + result.Y + " " + result.CurrentRotation);
            Position p2 = new Position(5, 5);
            Rover r2 = new Rover();
            p2.CurrentRotation = "E";
            p2.X = 3;
            p2.Y = 3;
            r2.SetPosition(p2);
            r2.SetRotateList("MMRMMRMRRM");
            r2.StartAction();
            Position result2 = r2.GetPosition();
            Console.WriteLine(result2.X + " " + result2.Y + " " + result2.CurrentRotation);
            Console.ReadLine();

        }
    }
}
