﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class BlankNameException : Exception
    {
        public BlankNameException() : base("El nombre no puede estar vacío")
        {
        }
    }
}
