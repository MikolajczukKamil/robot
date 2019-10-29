using System;

namespace RobotLib
{
    public class BatteryException : Exception
    {
        public BatteryException() : base("Za mało energi - padł akumulator :(") { }
    }
}
