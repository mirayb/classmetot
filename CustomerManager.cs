using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager : CustomerManagerBase
    {
        public customer Ekle(customer customer)
        {
            Console.WriteLine(" eklemek için müşteri adı:");
            customer.Adi = Console.ReadLine();
            Console.WriteLine(customer.Adi + "müşterisi eklendi");
            return customer;
        }
        public customer Sil(customer customer)
        {
            Console.WriteLine(" silmek için müşteri adı:");
            customer.Adi = Console.ReadLine();
            Console.WriteLine(customer.Adi + "müşterisi silindi");
            return customer;
        }

    }
}
