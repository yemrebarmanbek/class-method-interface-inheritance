using System; //oluşturulan namespace adları

namespace erisim_bildirgecleri
{
    public class my_erisimler
    {
       private int id { get; set; }    

       public void save()
       {
         id; //tanımlanır aşağıda tanımlanmaz
       }
    }


    //yukarıda private bir ıd tanımlı private olarak
    //tanımlandığı için aşağıda ıd kullanılamaz...
    //private erisimi sadece kendi tanımlı olduğu
    //blokta kullanılır.. (blok==class)

    //protected ise inheritance edilen sınıflarda kullanılır

    class my_erisimler2
    {
         public void save()
         {
             my_erisimler erisimler=new my_erisimler();
             
             
         }
 
    }


   //class sınıfı oluştururken onun default tanımlı 
   //erişim bilfirgeci internaldır.
   //internal projede istediğimiz noktada çağırdığımızda gelir
   
    internal class internal_kullanımı
    {
        public int MyProperty { get; set; }
    }
    


}
