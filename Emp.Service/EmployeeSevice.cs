using Emp.Interface;
using Emp.Model;

namespace Emp.Service
{
    public class EmployeeSevice:IEmployee
    {
        private readonly AppDbContext _dbContext;

        public EmployeeSevice(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public bool InsertEmployee(EmployeeModel employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }

        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> empModels = new List<EmployeeModel>();
            EmployeeModel empModel = new EmployeeModel
            {
                Id = 1,
                Empname = "afzar",
                Designation = "developer",
                DOJ = "17/07/2024",
                Empno = 89776565,
                Empemail = "moh@proteam",
                Empidcardno = 878668767,
                Empsalary = 10000,
                Company = "proteam"
            };
            empModels.Add(empModel);
            return empModels;
        }
    }
}
