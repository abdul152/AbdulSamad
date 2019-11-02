using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int result;
            Console.Write("Enter the Table NO:" + " ");
            int table = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++ )
            {
                result = table * i;
                Console.WriteLine(table + " " + "X" + i + " " + result);
               
            }
        }
    }
}
