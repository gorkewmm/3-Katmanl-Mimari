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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var p in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(p.ProductName);

            }

            foreach (var p in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(p.ProductName);

            }

        }
    }
}