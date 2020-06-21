using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class Sum
    {
        public static int calcSumWithReturn(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static void calcSumNoReturn(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }
    }
}