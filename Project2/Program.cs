using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, _inputstr;
            string data = "john";
            string _reverse = string.Empty;   
            Console.Write("Enter a Name:"+" ");
            firstName = Console.ReadLine();
            if (firstName == data)
            {

                Console.WriteLine("First Name is" +" " + firstName);
                Console.ReadLine();
                for (int i = firstName.Length - 1; i >= 0; i--)
                {
                    _reverse += firstName[i].ToString();
                    
                }
                Console.WriteLine("Name in reverse form is" + " " + _reverse);


            }
            else

            {
                Console.WriteLine("First Name is Wrong");
                Console.ReadLine();
            }


            
        }
    }
}
