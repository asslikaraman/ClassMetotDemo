using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("------------------------------");
            Musteri musteri1=new Musteri();
            musteri1.musteriAdi = "Aslı";
            musteri1.musteriSoyadi = "Kara";
            musteri1.musteriNo = 321;
            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Ayşe";
            musteri2.musteriSoyadi = "Öztürk";
            musteri2.musteriNo = 44;
            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Zeynep";
            musteri3.musteriSoyadi = "Arıcı";
            musteri3.musteriNo = 321;
            Musteri musteri4 = new Musteri();
            musteri4.musteriAdi = "Zehra";
            musteri4.musteriSoyadi = "Yılmaz";
            musteri4.musteriNo = 162;

            Musteri[] musteri=new Musteri[] {musteri1,musteri2,musteri3,musteri4};

            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine("Musteri: "+musteriler.musteriAdi+" "+musteriler.musteriSoyadi+" "+musteriler.musteriNo);
            }
            Console.WriteLine("------------------------------");
            MusteriManager musteriManager=new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("------------------------------");
            Console.ReadLine();


        }
    }
}
