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

            ProductTest();
            //Ioc standartlarını öğrendiğimizde Managerları newlemeyeceğiz.
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+" /"+ product.CategoryName);
            }
        }
    }
}
