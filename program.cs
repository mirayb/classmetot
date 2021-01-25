using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class program
    {
        static void Main(string []args)
        {
            customer customer1 = new customer();
            customer1.Id = 34;
            customer1.Adi = "hafsa";
            customer1.Soyadı = "camlıca";

            customer customer2 = new customer();
            customer2.Id = 56;
            customer2.Adi = "bilal";
            customer2.Soyadı = "kapoğlu";

            customer customer3 = new customer();
            customer3.Id = 89;
            customer3.Adi = "afra";
            customer3.Soyadı = "anık";

            customer[] customers = new customer[] { customer1, customer2, customer3 };
            Console.WriteLine("müşteriler");

            foreach (var customer in customers) 
            {
                Console.WriteLine(customer.Id+" "+customer.Adi+" "+customer.Soyadı);

            }

           CustomerManager customermanager = new CustomerManager();
            Console.WriteLine("------Yeni müşteri ver-------");
            customermanager.Ekle(new customer());

            Console.WriteLine("---------Müşteriyi silin------");
            customermanager.Sil(new customer());



        }
    }
}
