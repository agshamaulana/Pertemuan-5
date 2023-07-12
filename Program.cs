using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number method = new Number();
            method.Min(27, 82, 11);

            Console.WriteLine("--------------------------------------");
            method.Max(50, 55, 30);

            Console.ReadKey();
        }
    }
}