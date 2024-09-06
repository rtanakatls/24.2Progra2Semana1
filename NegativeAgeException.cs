using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class NegativeAgeException : Exception
    {
        public NegativeAgeException(int age) : base($"La edad ingresada es {age} pero la edad no puede ser negativa")
        {
        }
    }
}
