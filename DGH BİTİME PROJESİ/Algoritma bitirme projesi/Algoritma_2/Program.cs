using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matris boyutunu giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[n, n];
            Random rastgele = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matris[i, j] = rastgele.Next(0, 101);
                }
            }
            Console.WriteLine("Rastgele oluşturulan matris:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Köşegenleri ters çevrilmiş matris:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write(matris[n - 1 - i, n - 1 - j] + " ");
                    }
                    else
                    {
                        Console.Write(matris[i, j] + " ");
                    }
                }
                Console.WriteLine();


            }
        }
    }
}
