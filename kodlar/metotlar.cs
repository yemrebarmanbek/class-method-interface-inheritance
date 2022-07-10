using System; 

   
namespace metotlarim{   //namespace kullandım  ana metodda çağrılması using ile olur...
   //aşağıda metotlar adında bir class(sınıf) oluşturduk erişim belirleyicisi (başında)
   //belirtmediğimiz için default olarak private yazıldı..
   public class metot{    
        
                                       
        public void isimyaz()  //geri donuş vermeyen parametre almayan metot (public başka sınıflardan çağrılıyor)
      {
          Console.WriteLine("yunus emre barmanbek");
      }
  

   }



    
    //aşağıdaki ifadeler somut nesnelerdir (interface ile yapılanlarda soyut nesnelerdir)
   public class kullanici_bilgileri{  //property kullanimi (prop yaz tab tıkla)
       
         public byte ID { get; set; }
         public string ad { get; set; }
         public string soyad { get; set; }
         public byte yas { get; set; }
   

   }


}