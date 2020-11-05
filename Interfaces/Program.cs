using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car();
            car.Start();
            Console.WriteLine(car.IsOn);
            car.Stop();
            Console.WriteLine(car.IsOn);
            car.TurnLeft();
            car.TurnRight();
            car.Reverse();
            car.Turn(true);

            Motorbike bike = new Motorbike();

            bike.Start();
            Console.WriteLine(car.IsOn);
            bike.Stop();
            Console.WriteLine(car.IsOn);
            bike.TurnLeft();
            bike.TurnRight();
            bike.Reverse();
            bike.Turn(true);

            Boat boat = new Boat();

            boat.Start();
            Console.WriteLine(car.IsOn);
            boat.Stop();
            Console.WriteLine(car.IsOn);
            boat.TurnLeft();
            boat.TurnRight();
            boat.Reverse();
            boat.Turn(true);




        }
    }
}
