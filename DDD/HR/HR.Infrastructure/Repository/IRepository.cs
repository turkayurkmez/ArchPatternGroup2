using HR.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR.Infrastructure.Repository
{
    internal interface IRepository<T> where T : EntityBase, new()
    {
        IList<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);

        IList<T> GetWithCriteria(Expression<Func<T, bool>> criteria);
        T this[int id] { get; set; }
    }
}
