// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Console.WriteLine("Hello, World!");


//string adi = "ali";
//string soyadi = "ak";
//int id = 1;

//string[] musteriler = new string[] { };


Musteri musteri1 = new Musteri();
musteri1.Adi = "ali";
musteri1.Soyadi = "al";
musteri1.Id = 1;


Musteri musteri2 = new Musteri();
musteri2.Adi = "sipan";
musteri2.Soyadi = "ay";
musteri2.Id = 2;

Musteri musteri3 = new Musteri();
musteri3.Adi = "ayşe";
musteri3.Soyadi = "gel";
musteri3.Id = 3;

Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

foreach (Musteri musteri in musteriler)
{
    Console.WriteLine(musteri.Adi );
    Console.WriteLine(  musteri.Soyadi);
    Console.WriteLine(  musteri.Id);
}

Console.WriteLine(  "---------metotlar bitti--------");


MusteriManager musteriManager = new MusteriManager();

musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri3);


musteriManager.Sil(musteri3);

//musteriManager.Listele(musteri1 ); listele olmadı






