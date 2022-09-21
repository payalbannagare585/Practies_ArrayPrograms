using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practies_ArrayPrograms
{
    public class Program
    {
        private static bool i;

        static void Main(string[] args)
        {
            int[] num = new int[10] { 65, 85, 45, 96, 23, 12, 89, 56, 87, 90 };
            Console.WriteLine("Orignal array");
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------");

            int max = num.Max();
            Console.WriteLine($"Maximum integer is:{max}");

        }
    }
}
