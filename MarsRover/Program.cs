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

            Position p1 = new Position(max_X,max_Y);            
            string[] pos1 = position1.Split(" ");
            p1.CurrentRotation = pos1[2];
            p1.X = int.Parse(pos1[0]);
            p1.Y = int.Parse(pos1[1]);

            string[] pos2 = position2.Split(" ");
            Position p2 = new Position(max_X, max_Y);
            p2.CurrentRotation = pos2[2];
            p2.X = int.Parse(pos2[0]);
            p2.Y = int.Parse(pos2[1]);


            Console.WriteLine();
            Console.WriteLine("Expected Output:");

            Rover r1 = new Rover();
            r1.SetPosition(p1);
            r1.SetRotateList(rotateList1);
            r1.StartAction();
            Position result = r1.GetPosition();
            Console.WriteLine(result.X + " " + result.Y + " " + result.CurrentRotation);      
            Rover r2 = new Rover();
                    
            r2.SetPosition(p2);
            r2.SetRotateList(rotateList2);
            r2.StartAction();
            Position result2 = r2.GetPosition();
            Console.WriteLine(result2.X + " " + result2.Y + " " + result2.CurrentRotation);
            Console.ReadLine();

        }
    }
}
