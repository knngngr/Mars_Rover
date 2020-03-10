using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Position
    {
        readonly int MAX_X, MAX_Y;
        static Dictionary<string, Dictionary<string, string>> rotation = new Dictionary<string, Dictionary<string, string>>();
        private int x;
        private int y;
        static Position()
        {
            rotation.Add("N", new Dictionary<string, string>() { { "L", "W" }, { "R", "E" } });
            rotation.Add("E", new Dictionary<string, string>() { { "L", "N" }, { "R", "S" } });
            rotation.Add("S", new Dictionary<string, string>() { { "L", "E" }, { "R", "W" } });
            rotation.Add("W", new Dictionary<string, string>() { { "L", "S" }, { "R", "N" } });
        }
        public Position(int max_X, int max_Y)
        {
            MAX_X = max_X;
            MAX_Y = max_Y;
        }   
        public int X
        {
            get { return x; }
            set
            {
                if (value <= MAX_X)
                    x = value;
                else
                {
                    throw new Exception("value of X  > MAX_X");
                }
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value <= MAX_Y)
                    y = value;
                else
                {
                    throw new Exception("value of Y  > MAX_Y");
                }
            }

        }

        public string CurrentRotation { get; set; }
        public void SetRotateLeft()
        {
            CurrentRotation = rotation[CurrentRotation]["L"];
        }

        public void SetRotateRight()
        {
            CurrentRotation = rotation[CurrentRotation]["R"];
        }

        public void SetMove()
        {
            if (CurrentRotation == "N")
            {
                this.Y++;
            }
            else if (CurrentRotation == "E")
            {
                this.X++;
            }
            else if (CurrentRotation == "S")
            {
                this.Y--;
            }
            else if (CurrentRotation == "W")
            {
                this.X--;
            }

        }

    }
}
