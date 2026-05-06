using Business.Concrete;
using Business.Constants;
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
            ProductManager productManager = new ProductManager(new EfProductDal(), 
                new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll().Data)
            {
                Console.WriteLine(c.CategoryName);
            }
        }
    }
}