using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa kenar uzunluğunu giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kağıt sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam alan: " + ToplamAlan(x, n));
        }

        public static int ToplamAlan(int x, int n)
        {
            if (n == 1)
            {
                return x * (x + 2);
            }
            else
            {
                return ToplamAlan(x, n - 1) + (x + 2 * (n - 1)) * x;
            }
        }
    }
}
