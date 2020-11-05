using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces
{
    class Automobile//: IAutomobileActions
    {
        private bool _isOn;
        private bool _steering; // LEFT -> TRUE

        public bool IsOn
        {
            get { return (_isOn); }
            private protected set { _isOn = value; }
        }
        public bool Steering
        {
            get { return (_steering); }
            private protected set { _steering = value; }
        }

        public void Start()
        {
            this._isOn = true;
        }

        public void Stop()
        {
            this._isOn = false;
        }


        //abstract public void TurnLeft();
        //abstract public void TurnRight();
        //abstract public void Reverse();
    }
}
