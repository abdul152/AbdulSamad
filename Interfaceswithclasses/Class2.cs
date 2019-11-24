using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Interfaceswithclasses
{
    class Class2 : IMyInterface
    {
        //using file path from the library
        string filepath = (@"F:\GitHub Profile\GitHub Task\se-cloud-2019-2020\MyWork\Interfaceswithclasses\sample.txt");
        /*string filepath = ("sample.text"); */
       //reading the text from the file and hold in Lines as an string
        List<string> lines;
        //update text of file hold in newlines
        string newlines;
        double varian;
        double sum;
        double avgout;
        int loop;
        int outt;
        private object reader;

        // int medianout;

        public void Train(double[] data)
        {
            //loop for the sum of all the number stored in data
            for (loop =0; loop<data.Length; loop++)
            {
                sum += data[loop];
            }
            avgout = Math.Round((sum/data.Length), 2);

            //Median Calcualtion
            Array.Sort(data);
             outt = Convert.ToInt32(data[data.Length / 2]);
            //Variance

            if (data.Length > 1)
            {
                double soq = 0;
                //Mean Value
                foreach (int num in data)
                {
                    soq += Math.Pow((num - avgout), 2.0);

                }
                varian = Math.Round(soq / (double)(data.Length), 2);
            }
            else
                varian = 0;

        }


        


        public void Getresult()
        {
            Console.WriteLine("The average of Data is" + " " + avgout);
            Console.WriteLine("The Median of Data is" + " " + outt);
            Console.WriteLine("The Variance of Data is" + " " + varian);
        }


        public void Load()
        {

            lines = File.ReadAllLines(filepath).ToList();

            foreach(string line in lines)
            {

                Console.WriteLine(line);
            }

            Console.ReadLine();


        }

        public void Save()
        {
            lines.Add("wow, Abdul Samad, 1322431");

            File.WriteAllLines(filepath, lines);

            Console.ReadLine();
        }

        
    }
}

