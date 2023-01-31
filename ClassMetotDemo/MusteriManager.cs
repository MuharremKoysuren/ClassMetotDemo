using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + "Aramıza Hoşgeldiz");



        }

        public void Listele (Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı" + musteri.Adı + "Müşteri Soyadı" + musteri.Soyadı + "Müşteri TC. numarası" + musteri.TcNo);
        }
        
        public void Sil (Musteri musteri) 
        {
            Console.WriteLine( musteri.Adı + " Sistemden Çıkarıldı");
        }
    }
}
