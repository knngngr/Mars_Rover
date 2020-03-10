using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Input:");
            string grid = Console.ReadLine();
            string position1 = Console.ReadLine();
            string rotateList1 = Console.ReadLine();
            string position2 = Console.ReadLine();
            string rotateList2 = Console.ReadLine();
            
            string[] gridArr = grid.Split(" ");

            int max_X = int.Parse(gridArr[0]);
            int max_Y = int.Parse(gridArr[1]);
            Position p = new Position(max_X,max_Y);
            
            string[] pos1 = position1.Split(" ");
            p.CurrentRotation = pos1[2];
            p.X = int.Parse(pos1[0]);
            p.Y = int.Parse(pos1[1]);

            Console.WriteLine();
            Console.WriteLine("Expected Output:");

            Rover r1 = new Rover();
            r1.SetPosition(p);
            r1.SetRotateList(rotateList1);
            r1.StartAction();
            Position result = r1.GetPosition();
            Console.WriteLine(result.X + " " + result.Y + " " + result.CurrentRotation);      
            Rover r2 = new Rover();
          
            string[] pos2 = position2.Split(" ");
            p.CurrentRotation = pos2[2];
            p.X =int.Parse(pos2[0]);
            p.Y = int.Parse(pos2[1]);
            r2.SetPosition(p);
            r2.SetRotateList(rotateList2);
            r2.StartAction();
            Position result2 = r2.GetPosition();
            Console.WriteLine(result2.X + " " + result2.Y + " " + result2.CurrentRotation);
            Console.ReadLine();

        }
    }
}
