using System;

namespace Interfaceswithclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //int dloop;
            IMyInterface compare = new Class1();
            IMyInterface avrgverne = new Class2();

            double[] data = { 1, 20, 30, 20, 2 ,100};
            //double[] data = new double[5];
            //double wow;
            /*  Console.WriteLine("Enter the numbers:");
              for (dloop=0; dloop<5; dloop++)
              {

                  wow = Console.Read();

                  data[dloop] = wow;
                  Console.ReadKey();
              }*/

            compare.Train(data);
            compare.Getresult();
            compare.Save();           

            avrgverne.Train(data);
            avrgverne.Getresult();
            avrgverne.Load();
        }


    }
}
