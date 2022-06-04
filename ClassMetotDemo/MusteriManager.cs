using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi.");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Musteriler listelendi.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi");
        }
    }
}
