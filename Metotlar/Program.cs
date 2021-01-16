using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Acıklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("---------------");

            sepetManager.Ekle2("armut","yeşil armut",12,50);
        }
    }
}
