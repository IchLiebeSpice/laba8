using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Library
{
    public class RiverException : Exception
    {
        public RiverException(string message) : base(message) { }
    }

    public class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Неправильна назва рикалусси Хохляндии.") { }
    }

    public class InvalidRegionException : RiverException
    {
        public InvalidRegionException() : base("Неправильний регіон.") { }
    }

    public class InvalidDlinaException : RiverException
    {
        public InvalidDlinaException() : base("Неправильна довжина.") { }
    }

    public class InvalidPritokiException : RiverException
    {
        public InvalidPritokiException() : base("Неправильна притока.") { }
    }

    public class InvalidLenghtException : RiverException
    {
        public InvalidLenghtException() : base("Ви вказали озеро...") { }
    }
}
