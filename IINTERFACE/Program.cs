using System;

namespace InterfaceWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            INewInterface greater = new SumChecker();
            INewInterface mmv = new Result();
            double[] data = { 5,4,15,13,15,21,6,13,15,16,18,20 };
            greater.Train(data);
            greater.GetResult();
            mmv.Train(data);
            mmv.GetResult();
            Console.ReadLine();
            mmv.Save();
            mmv.Load();
        }
    }
}
