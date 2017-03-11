using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            

            string line = sr.ReadToEnd();

            sr.Close();
            fs.Close();

            string[] input = line.Split(' ');
            int min = int.Parse(input[0]);
            int max = int.Parse(input[0]);

            for (int i = 0; i < input.Length; i++)
            {
                int cur = int.Parse(input[i]);
                if (cur < min)
                    min = cur;
                if (cur > max)
                    max = cur;

            }
            Console.WriteLine("minimum = {0}, maximum = {1}", min, max);
            
            Console.ReadKey();
        }
    }
}