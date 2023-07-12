using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverload
{
    internal class Number
    {
        public void Min(int a, int b, int c)
        {
            Console.WriteLine("Tersedia angka sebagai berikut {0}, {1}, {2}", a, b, c);

            if (a <= b && a <= c)
            {

                Console.WriteLine("Nilai terkecil dari ketiga angka adalah: {0}", a);
            }
            else if (b <= a && b <= c)
            {

                Console.WriteLine("Nilai terkecil dari ketiga angka adalah: {0}", b);
            }
            else if (c <= a && c <= b)
            {

                Console.WriteLine("Nilai terkecil dari ketiga angka adalah: {0}", c);

            }
        }


        public int Max(int a, int b, int c)
        {
            Console.WriteLine("Tersedia angka sebagai berikut {0}, {1}, {2}", a, b, c);

            if (a >= b && a >= c)
            {

                Console.WriteLine("Nilai terbesar dari ketiga angka adalah : {0}", a);
            }
            else if (b >= a && b >= c)
            {

                Console.WriteLine("Nilai terbesar dari ketiga angka adalah: {0}", b);
            }
            else if (c >= a && c <= b)
            {

                Console.WriteLine("Nilai terbesar dari ketiga angka adalah: {0}", c);
            }
            return 0;
        }
    }
}