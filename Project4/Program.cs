using System;

namespace Project4
{

    public class Person
    {
        public string Name;
        public int Age;
        public bool pet;
        
        public void greeting()
        {
            Console.WriteLine("Hi!, My Name is" + " " + Name + " " + "and" + " " + "My Age is" + " " + Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person wow = new Person();

            wow.Name = "Abdul";
            wow.Age = 25;
            wow.pet = true;

            wow.greeting();
        }
    }
}
