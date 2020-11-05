using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Car : Automobile, IAutomobileActions
    {
        public Car(bool IsOn)
        {
            this.IsOn = true;
        }
        public Car() 
        {
        }

        public void TurnLeft()
        {
            Console.WriteLine("CAR VROUM VROUM LEFT");
            this.Steering = true;
        }

        public void Break()
        {
            Console.WriteLine("CAR STAAAAAAAAAAAAAAAAAAAAAHP");
        }

        public void TurnRight()
        {
            Console.WriteLine("CAR VROUM VROUM RIGHT");
            this.Steering = false;
        }

        public void Reverse()
        {
            Console.WriteLine("CAR VROUM VROUM BACK");
        }

        public void Turn(bool turnleft)
        {
            if (turnleft)
            {
                Console.WriteLine("CAR TURNING LEFT");
                this.Steering = false;
            }
            else
            {
                Console.WriteLine("CAR TURNING RIGHT");
                this.Steering = true;
            }
        }
    }
}
