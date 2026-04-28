using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint (generic kısıtlama)
    //class : referans tip.
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {//veritabanında yapacağım operasyonları(listele,sil,güncelle..) içeren interface 
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filter = null yani filtre vermeye de bilirsin demek.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
