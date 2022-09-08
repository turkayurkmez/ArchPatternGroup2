using HR.Infrastructure.DomainBase;
using HR.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Infrastructure.Spesification
{
    public abstract class SpesificationBase<T> : ISpesification<T> where T : IEntity
    {
        public abstract bool IsStatisfied(T item);

        public IList<string> Errors { get; set; } = new List<string>();



        public void Notify()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in Errors)
            {
                stringBuilder.AppendLine(item);
                stringBuilder.AppendLine();
            }

            throw new EntityException(stringBuilder.ToString());
        }
    }
}
