using HR.Domain.Entities;
using HR.Domain.Spesification;
using HR.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Aggregates
{
    public class Company : AggregateBase
    {
        //Şirket olmaz ise olmaz departman
        //Olmaya çalışan olmaz ise departman.
        public string Name { get; set; }
        public IList<Department> Departments { get; set; } = new List<Department>();

        //Çalışanı işe alacak...
        public void HireEmployee(Employee employee)
        {
            HireEmployeeSpesification hireEmployeeSpesification = new HireEmployeeSpesification();
            if (hireEmployeeSpesification.IsStatisfied(employee))
            {
                var department = Departments.FirstOrDefault(x => x.Id == employee.DepartmentId);
                department.Employees.Add(employee);
            }
            else
            {
                hireEmployeeSpesification.Notify();
            }
        }

        public Department FindDepartment(int id)
        {
            var department = Departments.FirstOrDefault(x => x.Id == id);
            return department;

        }
    }
}
