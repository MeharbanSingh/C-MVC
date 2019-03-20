using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
   abstract class Computers
    {
        protected string _name = "unknown";

        public bool isOn { get; private set; }

        public virtual string name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public Computers(string name)
        {
            this.name = name;
        }

        protected void TurnOn()
        {
            isOn = true;
        }

        protected void TurnOff()
        {
            isOn = false;
        }

        public virtual void togglePower()
        {
            if (isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
