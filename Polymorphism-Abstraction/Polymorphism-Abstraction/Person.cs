using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction
{
    internal class Person : Test, IPerson
    {
        public void GetName()
        {
            List<Person> list = new List<Person>();
            Console.WriteLine("Cavid");
        }
    }
}
