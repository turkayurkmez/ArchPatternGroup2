using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Infrastructure.DomainBase
{
    public abstract class AggregateBase : EntityBase, IAggregateRoot
    {
    }
}
