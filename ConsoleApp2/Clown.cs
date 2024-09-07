using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Clown 
    {
        public string? Name;
        public int Height;

        public void WhoAreYou()
        {
            Console.WriteLine($"Hi my name is {Name} and I am {Height} inches tall");
        }
    }
}
