﻿using Progra2.NotificationExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new NotificationMenu();
            menu.Execute();
        }
    }
}
