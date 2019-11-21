using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InterfaceWithClasses
{
    class Result : INewInterface
    {
        double sum;
        int i;
        double mean;
        double result;//result of Mean
        int result1;//result of Median
        double result2;//result of Variance

        public void Train(double[] data)
        {
            //Mean Calculation
            for (i = 0; i < data.Length; i++)
            {
              sum += data[i];
            }
            
            double mean = sum / data.Length;
            result = mean;
            //Median Calculation
            Array.Sort(data);
            result1 = Convert.ToInt32(data[data.Length / 2]);
            //Variance
            if (data.Length > 1)
            {
                double avg = result;//Mean Value
                double sumOfSquares = 0.0;
                foreach (int num in data)
                {
                    sumOfSquares += Math.Pow((num - avg), 2.0);//For each Number in the array subtract it with mean value
                }                                               //and square it.
                result2 = sumOfSquares / (double)(data.Length);//Then devide it by total length of the array.
            }
            else
                result2 = 0.0;
        }
        public void GetResult()
        {
            //return Convert.ToInt32(mean);
            double r = Convert.ToDouble(String.Format("{0:0.0000}", result));//Taking 4 digits after decimal point
            double r2 = Convert.ToDouble(String.Format("{0:0.0000}", result2));
            Console.WriteLine("\nMean:" + r);
            Console.WriteLine("\nMedian:" + result1);
            Console.WriteLine("\nVariance:" + r2);
        }

        public void Save()
        {
            StreamWriter sw = File.CreateText(@"C:\Users\Ghulam Mustafa\source\repos\se-cloud-2019-2020\Source\MyWork\InterfaceWithClasses\SaveFile.txt");
            if (!File.Exists(@"C: \Users\Ghulam Mustafa\source\repos\se - cloud - 2019 - 2020\Source\MyWork\InterfaceWithClasses\SaveFile.txt"))
            {
                File.Create(@"C:\Users\Ghulam Mustafa\source\repos\se-cloud-2019-2020\Source\MyWork\InterfaceWithClasses\SaveFile.txt");
            }
            File.WriteAllText("SaveFile.txt", result.ToString());
            File.WriteAllText("SaveFile.txt", result1.ToString());
            File.WriteAllText("SaveFile.txt", result2.ToString());
        }

        public void Load()
        {
            var res = File.ReadAllText("SaveFile.txt");
            Console.WriteLine(res);
        }
    }
}
