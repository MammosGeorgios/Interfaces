using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Boat : Automobile, IAutomobileActions
    {
        public Boat()
        {
        }

        public void TurnLeft()
        {
            Console.WriteLine("BOAT VROUM VROUM LEFT");
            this.Steering = true;
        }
        public void TurnRight()
        {
            Console.WriteLine("BOAT VROUM VROUM RIGHT");
            this.Steering = false;
        }

        public void Reverse()
        {
            Console.WriteLine("BOAT VROUM VROUM BACK");
        }

        public void Turn(bool turnleft)
        {
            if (turnleft)
            {
                Console.WriteLine("BOAT TURNING LEFT");
                this.Steering = false;
            }
            else
            {
                Console.WriteLine("BOAT TURNING RIGHT");
                this.Steering = true;
            }
        }

      
    }
}
