using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ertan";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.egitmen = "ertan";
            kurs1.izlemeorani = 68;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.egitmen = "deniz";
            kurs2.izlemeorani = 52;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.egitmen = "bülent";
            kurs3.izlemeorani = 31;
            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.egitmen = "aziz";
            kurs4.izlemeorani = 40;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlemeorani { get; set; }
    }
}
