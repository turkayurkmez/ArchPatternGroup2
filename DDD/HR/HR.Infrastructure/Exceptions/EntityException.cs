using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Infrastructure.Exceptions
{
    public class EntityException :Exception
    {
        private readonly string message;

        public EntityException(string message)
        {
            this.message = message;
        }

        public EntityException()
        {
            this.message = "Entity oluşturulurkan bir hata oluştu...";
        }

        public string Message => message;
    }
}
