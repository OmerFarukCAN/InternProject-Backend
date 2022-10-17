using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // Generic Constraint
    // class : referans tip olabilir
    // IEntity : kendisi veya onu implente eden bir nesne olabilir.
    // new() : new'lenebilir olmalıdır. Interfaceler newlenemez ondan dolayı onu devre disi biraktik.

    public interface IEntityRepository <T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // filter = null filtre vermeyebilirsin anlamına gelmektedir.
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}


