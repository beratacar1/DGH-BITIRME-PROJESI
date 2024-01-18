using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunKenar, cevre, alan, kenar;

            Console.Write("Dikdörtgenin çevre uzunluğunu girin:");
            cevre = Convert.ToInt32(Console.ReadLine());

            Console.Write("Karenin tek kenar uzunluğunu girin:");
            kenar = Convert.ToInt32(Console.ReadLine());

            uzunKenar = (cevre - (2 * kenar)) / 2;
            alan = uzunKenar * kenar;

            Console.WriteLine("*****************************");

            Console.WriteLine("Dikdörtgenin alanı : " + alan);



        }



    }
}

