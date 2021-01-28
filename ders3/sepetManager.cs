using System;
using System.Collections.Generic;
using System.Text;

namespace ders3
{
    class sepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " +urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepetinize eklediniz : " + urunAdi);
        }
    }
}
