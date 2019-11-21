using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceWithClasses
{
    class SumChecker:INewInterface
    {
        int result;
        double sum;
        int i;
        int status;

        public void Train(double[] data)
        {
            for (i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            status=sum.CompareTo(100);
            if (status > 0)
                result = 1;
            else
                result = 0;
        }
        public void GetResult()
        {
            //return result;
            if (result == 1)
            Console.WriteLine("Sum is greater than 100");
            else
                Console.WriteLine("Sum is less than 100");
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
