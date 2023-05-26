using System;

namespace csgo_sharecode.CSGOSharecode.Exceptions
{
    public class InvalidSharecodeException : Exception
    {
        public InvalidSharecodeException() : base("This code has invalid csgo-sharecode structure") { }
    }
}
