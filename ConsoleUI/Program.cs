using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFranework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine(p.ProductName + "/" + p.CategoryName);

            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
        }
    }
}