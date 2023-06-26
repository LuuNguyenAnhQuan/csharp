using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[6];
            products[0] = new Book(1, "Nha Gia Kim", 100, "Paulo Coelho");
            products[1] = new Book(2, "Dung bao gio tu bo khat vong", 200, "Nick Vujicic");
            products[2] = new Book(3, "Dac Nhan Tam", 300, "Dale Carnegie");
            products[3] = new MobilePhone(4, "Iphone", 500, "Apple");
            products[4] = new MobilePhone(5, "Samsung", 300, "Samsung");
            products[5] = new MobilePhone(6, "Oppo", 400, "Oppo");

            double totalBookTax = 0;
            double totalMobileTax = 0;

            foreach (Product product in products)
            {
                if (product is Book book)
                {
                    double bookTax = book.ComputeTax();
                    totalBookTax += bookTax;
                    Console.WriteLine($"Book: {book.name}, Tax: {bookTax}");
                }
                else if (product is MobilePhone mobilePhone)
                {
                    double mobileTax = mobilePhone.ComputeTax();
                    totalMobileTax += mobileTax;
                    Console.WriteLine($"Mobile Phone: {mobilePhone.name}, Tax: {mobileTax}");
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Total Tax for Books: {totalBookTax}");
            Console.WriteLine($"Total Tax for Mobile Phones: {totalMobileTax}");
            
            Console.ReadLine();
        }
    }
}
