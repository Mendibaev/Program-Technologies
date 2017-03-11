using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace простое_число_1
{
    class Program
    {
        static bool Prime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= number; i++)
            {
                if (number / i > 2) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (Prime(n))
                Console.WriteLine("простое");
            else
                Console.WriteLine("непростое");
            Console.ReadKey();

        }
        
    }
    
}
