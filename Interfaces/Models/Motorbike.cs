using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces
{
    class Motorbike:Automobile, IAutomobileActions
    {
        public Motorbike(bool IsOn)
        {
            this.IsOn = true;
        }
        public Motorbike()
        {
        }


        public void TurnLeft()
        {
            Console.WriteLine("BIKE VROUM VROUM LEFT");
            this.Steering = true;
        }

        public void Break()
        {
            Console.WriteLine("BIKE STAAAAAAAAAAAAAAAAAAAAAHP");
        }

        public void TurnRight()
        {
            Console.WriteLine("BIKE VROUM VROUM RIGHT");
            this.Steering = false;
        }

        public void Reverse()
        {
            Console.WriteLine("BIKE VROUM VROUM BACK");
        }

        public void Turn(bool turnleft)
        {
            if (turnleft)
            {
                Console.WriteLine("BIKE TURNING LEFT");
                this.Steering = false;
            }
            else
            {
                Console.WriteLine("BIKE TURNING RIGHT");
                this.Steering = true;
            }
        }
    }
}
