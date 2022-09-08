using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Infrastructure.DomainBase
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }

        // override object.Equals
        // Entity'ler ve Value Object'ler birbirleriyle eşitlik karşılaştırması yapıabiliyor olmalı. Bu tarz operasyonlar için bu abstract class kullanılmalıdır.
    }
}
