using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adı = "Muharrem ";
            musteri1.Soyadı = "Köysüren";
            musteri1.TcNo = 10101010101;
            musteri1.DogumYili = 1999;



            Musteri musteri2 = new Musteri();
            musteri2.Adı = "Memati ";
            musteri2.Soyadı = "Baş";
            musteri2.TcNo = 10401010101;
            musteri2.DogumYili = 1981;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adı);
                Console.WriteLine(musteri.Soyadı);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.DogumYili);


            }
            
            MusteriManager musteriManager= new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);




        }


    }
}
