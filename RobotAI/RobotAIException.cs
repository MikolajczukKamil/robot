using System;

namespace RobotAI
{
    public class RobotAIGotLostException : Exception
    {
        public RobotAIGotLostException() : base("Bot się pogubił i nie wie co robić :(") { }
    }
}
