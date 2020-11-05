using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    interface IAutomobileActions
    {
        void TurnLeft();
        void TurnRight();
        void Reverse();
        void Turn(bool turnleft);
    }
}
