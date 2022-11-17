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
    //generic constraint
    //class:referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden nesne olabilir
    //new() ile IEntity newlenemez olduğu için Ientity yazılmasının önüne geçtim
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
