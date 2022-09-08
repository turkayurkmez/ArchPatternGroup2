using HR.Domain.Aggregates;
using HR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Factories
{
    public static  class CompanyFactory
    {
        public static Company CreateCompany(string companyName)
        {
            Company company = new Company {  Name=companyName};
            company.Departments = new List<Department>();

            return company;
            
        }

        public static Department CreateDepartment()
        {
            Department department = new Department();
            department.Employees = new List<Employee>();
            return department;
        }


    }

}
