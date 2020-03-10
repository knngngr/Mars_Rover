using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MarsRover
{
    public class Rover
    {

        Position position;
        string[] rotateList;
        List<IExecute> listOfActions = new List<IExecute>();
        public void SetPosition(Position p)
        {
            position = p;
        }

        public void SetRotateList(string _rotateList)
        {
            this.rotateList = _rotateList.ToCharArray().Select(k => k.ToString()).ToArray();
        }
        public void StartAction()
        {
            foreach (string item in rotateList)
            {
                if (item == "M")
                {
                    listOfActions.Add(new MoveAction(position));
                }
                else if (item == "L")
                {
                    listOfActions.Add(new RotateLeftAction(position));
                }
                else if (item == "R")
                {
                    listOfActions.Add(new RotateRightAction(position));
                }
            }

            foreach (IExecute action in listOfActions)
            {
                action.Execute();
            }
        }
        public Position GetPosition()
        {
            return this.position;
        }
    }
}
