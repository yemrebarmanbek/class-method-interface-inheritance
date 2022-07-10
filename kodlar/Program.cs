using System;
using metotlarim;  //using namespace 



namespace projelerim
{
    class Program
    {

        private static void ogrenimyeri(){  //metot private tanımlanda tanımlı olduğu sınıftan metot çağrıldı
             
            Console.WriteLine("bolu");
        }


        static void Main(string[] args)  //ana metodumuz (fonksiyon)
        {
          metot metot=new metot();  // static olarak tanımlamadığımız için nesne oluşturduk.(ayrıca farklı sınıftan)
          metot.isimyaz();
              

              ogrenimyeri();  //static ve aynı sınıfda olunduğu için direkt metod  çağrıldı.
            

            
            kullanici_bilgileri kisi1=new kullanici_bilgileri();
            kisi1.ID=55;  kisi1.ad="emre";  kisi1.soyad="barmanbek"; kisi1.yas=55;

            kullanici_bilgileri kisi2=new kullanici_bilgileri{
                 ID=100 , ad="emre", soyad="barmanbek", yas=55
            };

         

        }


        
         



    }

    



}

