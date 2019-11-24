using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaceswithclasses
{
    class Class1 : IMyInterface
    {
        int result;
        int i;
        double sum;
        int status;
        public void Train(double[] data)
        {
            //Condition for greater than 100 or less than 100
            for (i=0; i<data.Length; i++)
            {
                sum += data[i];
            }
            //status compare the stored result with 100
            status = sum.CompareTo(100);
            if (status > 0)
                result = 1; 
            else 
                result = 0;
        }


        public void Getresult()
        {
            if (result == 1)
            {
                Console.WriteLine("Sum is greater than 100");
            }
            else
                Console.WriteLine("SUM is less than 100");
        }

        public void Load()
        {
            //do somthing with the file
        }

        public void Save()
        {
            //do somthing with the file
        }

        
    }
}

