using HR.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Infrastructure.Spesification
{
    public interface ISpesification<T> where T: IEntity
    {
        public bool IsStatisfied(T item);
        void Notify();

    }
}
