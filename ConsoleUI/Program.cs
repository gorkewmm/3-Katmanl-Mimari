using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductDal inMemoryProductDal = new InMemoryProductDal();
            ProductManager productManager = new ProductManager(inMemoryProductDal);

            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);

            }

        }
    }
}