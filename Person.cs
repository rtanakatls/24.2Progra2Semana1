using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Person
    {
        private string name;
        private int age;

        public void SetName(string name)
        {
            if (name.Length <= 0)
            {
                throw new BlankNameException();
            }
            this.name = name;
        }

        public void SetAge(int age)
        {
            if (age <= 0)
            {
                throw new NegativeAgeException(age);
            }
            this.age = age;
        }
    }
}
