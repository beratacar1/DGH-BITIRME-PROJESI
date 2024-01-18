using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBankaOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi musteri = new BankaHesabi();
            
            musteri.bakiye = 1000;
            Console.Write("Hesaptaki bakiyeniz : ");
            musteri.bakiyeGoruntule();

            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Para yatırma");
            Console.WriteLine("2 - Para çekme");
            Console.WriteLine("3 - Bakiye görüntüleme");
           
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Yatırmak istediğiniz tutarı girin:");
                    int yatirilanMiktar = Convert.ToInt32(Console.ReadLine());
                    musteri.paraYatir(yatirilanMiktar);
                    Console.WriteLine("****************************");
                    Console.Write("Güncel Bakiyeniz : ");
                    musteri.bakiyeGoruntule();
                    break;
                case 2:
                    Console.WriteLine("Çekmek istediğiniz tutarı girin:");
                    int cekilenMiktar = Convert.ToInt32(Console.ReadLine());
                    musteri.paraCek(cekilenMiktar);
                    Console.WriteLine("****************************");
                    Console.Write("Güncel Bakiyeniz : ");
                    musteri.bakiyeGoruntule();
                    break;
                case 3:
                    Console.Write("Güncel Bakiyeniz : ");
                    musteri.bakiyeGoruntule();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız ! ");
                    break;

            }
        }


        public class BankaHesabi
        {
            public int bakiye;

            public void paraYatir(int miktar)
            {
                bakiye += miktar; // bakiye = bakiye + miktar
                Console.WriteLine(miktar + " TL hesaba yatırıldı.");
            }

            public void paraCek(int miktar)
            {
                if (bakiye < miktar)
                {
                    Console.WriteLine("Yetersiz bakiye. İşlem gerçekleştirilemedi.");
                }
                else
                {
                    bakiye -= miktar; // bakiye = bakiye - miktar
                    Console.WriteLine(miktar + " TL hesaptan çekildi.");
                }
            }

            public void bakiyeGoruntule()
            {
                Console.WriteLine(bakiye + " TL");
            }
        }
    }
}
