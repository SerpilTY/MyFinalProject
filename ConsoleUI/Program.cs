using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //O:Open Closed Principle
            //Yaptığın yazılıma yeni bir özellik ekliyorsan mevcut hiçbir koduna dokunmamalısın.
            //Biz burada sadece bir klasör ekleyip, konfigurasyonu değiştirdik, kodlara dokunmadık.

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
