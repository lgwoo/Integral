using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 2;
            int end = 5;
            int bar = 100;

            Console.WriteLine("110 :" + start * end + bar);
            Console.WriteLine(end + bar);
            Console.WriteLine((end + bar) * start);
            Console.WriteLine("시작" + start);
            Console.WriteLine("끝에서 시작 뺀것/100 + 시작 : 2.03?" + (((end - start) / bar) + start));
        }
    }
}
