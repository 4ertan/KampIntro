using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım gelişririci yetiştirme kampı";
            string kurs2 = "programlamaya başlangıc için temel kursu";
            string kurs3 = "java";
            string[] kurslar = new string[]
            {
                "yazılım gelişririci yetiştirme kampı","programlamaya başlangıc için temel kursu","java"
            };

            for (int i = 1; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
