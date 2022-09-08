using HR.Domain.Aggregates;
using HR.Domain.Factories;

namespace HR.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Hire_Employee()
        {
            Company company = CompanyFactory.CreateCompany("Turkcell");
            company.Departments.Add(new Domain.Entities.Department { Id = 1 });
            
            //var department = company.FindDepartment(1);
            var employee = new Domain.Entities.Employee { FirstName = "xxx", LastName = "yyyy", DepartmentId=1 };
            company.HireEmployee(employee);


            
        }
    }
}