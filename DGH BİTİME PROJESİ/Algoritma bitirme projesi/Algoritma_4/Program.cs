using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] alfabe = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string fileName = "alphabet.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < alfabe.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        writer.Write(alfabe[j]);
                    }
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Dosya başarıyla oluşturuldu.");
        }
    }
}


