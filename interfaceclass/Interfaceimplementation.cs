using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceclass
{
    class Interfaceimplementation : IMyInterface
    {
        string Name;
        int age;

        public void Train()
        {

            
            Console.WriteLine("MY" + " " + Name + " "+"Age" + " " + age);
        }

        public void Save()
        {
            Console.WriteLine("WOW");
        }
    }
}
