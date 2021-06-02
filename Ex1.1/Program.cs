using System;

namespace Ex1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vui long nhap ten ");
            var name = Console.ReadLine();
            Console.WriteLine("vui long nhap dia chi ");
            var address = Console.ReadLine();
            Console.WriteLine("vui long nhap so dien thoai");
            var phone = Console.ReadLine();
            Console.WriteLine("name: {0}\n****", name);
            Console.WriteLine("address: {0}\n****", address);
            Console.WriteLine("phone: {0}",phone);
            Console.ReadLine();
        }
    }
}