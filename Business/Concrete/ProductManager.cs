using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;    //Business'ın bildiği tek şey IProductDal
                                    //BL katmanının herhangi bir veri modeli hakkında detaylı bilgiye sahip olmaması gerekir.
        public ProductManager(IProductDal productDal)//Ctor parametresi olarak veri erişim alternatifi alıcak.
        {                                             //InMemory,EFCore,Dapper              
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş kodları ve kuralları burada, 
            // Yetkisi var mı? Eğer burayı geçerse...

            return _productDal.GetAll();
            
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            // İş kodları ve kuralları burada, 
            // Yetkisi var mı? Eğer burayı geçerse...

            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
