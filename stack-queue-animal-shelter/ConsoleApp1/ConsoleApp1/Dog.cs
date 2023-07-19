using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Species = "dog";
            Name = name;
        }
    }
}
