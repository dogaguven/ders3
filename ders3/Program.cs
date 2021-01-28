using System;

namespace ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("------------Metotlar-----------");
            //instance-örnek
            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 46);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 6, 18);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 30, 16);

        }
    }
}
