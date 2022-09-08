using HR.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Entities
{
    /*
     * POCO - POJO: Plain Old C# Object
     *              Plain Old Java Object
     *              
     * 
     */
    public class Department : AggregateBase
    {
        public string Name { get; set; }
        public string TasksInfo { get; set; }
        public Employee Lead { get; set; } = new Employee();
        public IList<Employee> Employees { get; set; } = new List<Employee>();



    }
}
