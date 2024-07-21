using Emp.Model;

namespace Emp.Interface
{
    public interface IEmployee
    {
        List<EmployeeModel> GetEmployees();

        bool InsertEmployee(EmployeeModel employee);
    }
}
