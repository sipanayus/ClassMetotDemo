using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
       //public Ekle(Musteri musteri)
       // {

       //     Console.WriteLine( "tebrikler artık müşterisiniz : " +musteri.Adi);
       // }

        //public Sil(Musteri musteri)
        //{
        //    Console.WriteLine( "aboneliğiniz silindi : " +musteri.Id);
        //}

     
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(  "tebrikler artık müşterisiniz : " +musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(  "aboneliğiniz silindi : " +musteri.Adi);
        }

        //public void Listele(Musteri musteri)
        //{
        //    Console.WriteLine(" Listelendi");
        //} Listeleme metodu olmadı tekrar  yap

    }



}
