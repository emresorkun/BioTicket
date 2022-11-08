using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
    internal static class Utilities
    {
        public static int CalculateTotal(int price, int groupCount)
        {
            Console.WriteLine($"total: {price * groupCount}");
            return price * groupCount;
        }

        public static void testMethod1()
        {
            Console.WriteLine("test1 is succesfull");
            return;
        }



    }
}
