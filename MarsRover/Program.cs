using System;
using System.Text;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Input:");
            string grid = Console.ReadLine();
            string[] gridArr = grid.Split(" ");
            int max_X = int.Parse(gridArr[0]);
            int max_Y = int.Parse(gridArr[1]);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Exptected Output: ");

            for (int k =1;k<=2;k++)
            {
                Position p1 = new Position(max_X, max_Y);
                string position1 = Console.ReadLine();
                string rotateList1 = Console.ReadLine();

                string[] pos1 = position1.Split(" ");
                p1.CurrentRotation = pos1[2];
                p1.X = int.Parse(pos1[0]);
                p1.Y = int.Parse(pos1[1]);
                Rover r1 = new Rover();
                r1.SetPosition(p1);
                r1.SetRotateList(rotateList1);
                r1.StartAction();
                Position finalPos = r1.GetPosition();
                string result = string.Format("{0} {1} {2}", finalPos.X, finalPos.Y, finalPos.CurrentRotation);
                builder.AppendLine(result);
            }
            Console.WriteLine(builder.ToString());
            Console.ReadKey();
          
        }
    }
}
