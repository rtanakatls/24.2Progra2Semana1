using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class PersonMenu : Menu
    {
        public override void Execute()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                try
                {
                    string name;
                    int age;
                    Console.WriteLine("Introduce el nombre:");
                    name = Console.ReadLine();
                    Console.WriteLine("Introduce la edad:");
                    age = int.Parse(Console.ReadLine());
                    Person person = new Person();
                    person.SetName(name);
                    person.SetAge(age);
                    continueFlag = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Inténtalo de nuevo");
                }
            }
        }
    }
}
