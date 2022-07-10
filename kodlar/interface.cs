using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {  
        static void Main(string[] args)
        {
            //IntarfacesIntro();

            //Demo();

            // bu sayede bir veriyi birden fazla veritabanına kayıt ediyoruz....
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MySqlCustomerDal(), 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

         
        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }






        // bu sayede interface'e implement olan her grubu yazabiliyoruz
        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departmant = "Computer Sciences"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }




    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }








    class PersonManager  //interface'i burada implement ettik.
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}










//interface çoklu implementasyon
//bir class birden fazla interface implement edebilir.

interface Calisanlar
{
   void vork();
   void eat();
   void salary();

}


//birden fazla interface tanımlayıp aynı propetiesde implement edebiliriz.
interface Ozel_Hayat{
   void gezmek();
   void eglenmek();
   void dinlenmek();

}



class Worker : Calisanlar //implement ettiğimiz zaman bu şekilde olur 
{ //güzel parantezlerin içine komutları yazarız...
    public void eat()
    {
        
    }

    public void salary()
    {
        throw new NotImplementedException();
    }

    public void vork()
    {
        throw new NotImplementedException();
    }
}




// iki tane interface'i bir propertieste implement ettik.
class İnsan : Ozel_Hayat, Calisanlar
{
    public void dinlenmek()
    {
        throw new NotImplementedException();
    }

    public void eat()
    {
        throw new NotImplementedException();
    }

    public void eglenmek()
    {
        throw new NotImplementedException();
    }

    public void gezmek()
    {
        throw new NotImplementedException();
    }

    public void salary()
    {
        throw new NotImplementedException();
    }

    public void vork()
    {
        throw new NotImplementedException();
    }
}
