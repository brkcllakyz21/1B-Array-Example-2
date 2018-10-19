using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1B_Array_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            int sayı = 0, sayaç = 0;

            Console.WriteLine("Bir sayı giriniz.");
            sayı = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dizi.Length; i++)
            {
                if (sayı > dizi[i])
                {
                    sayaç++;
                }
            }

            Console.WriteLine(sayı + " sayısı " + sayaç + " tane elemandan büyüktür.");



        }
    }
}
