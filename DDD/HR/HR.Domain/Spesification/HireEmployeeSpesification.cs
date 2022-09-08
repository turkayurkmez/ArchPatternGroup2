using HR.Domain.Entities;
using HR.Infrastructure.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Spesification
{
    public class HireEmployeeSpesification : SpesificationBase<Employee>
    {

        public override bool IsStatisfied(Employee item)
        {
            checkFirstName(item);
            checkDepartment(item);
            checkIsNew(item);

            if (Errors.Count >0)
            {
                Notify();
                return false;
            }

            return true;
        }

        private void checkFirstName(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                Errors.Add("Name required");
            }
        }

        private void checkDepartment(Employee employee)
        {
            if (employee.DepartmentId == default)
            {
                Errors.Add("Deparment must be spesified");
            }
        }


        private void checkIsNew(Employee employee)
        {
            if (employee.Id != 0)
            {
                Errors.Add("Employee must be new");
            }
        }

        
     
    }
}
