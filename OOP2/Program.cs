using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ertan";
            musteri1.Soyadi = "Osmanoğlu";
            musteri1.TcNo = "12345678912";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1231";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1231564560";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
        }
    }
}
