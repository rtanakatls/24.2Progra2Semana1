using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Example1Menu : Menu
    {
        public override void Execute()
        {
            Console.WriteLine("Introduce un número");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"La división es: {a / b}");
            Console.WriteLine("Hola mundo!");
        }
    }
}
