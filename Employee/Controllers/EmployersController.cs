using Emp.Interface;
using Emp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        private readonly IEmployee _emplo;

        public EmployersController(IEmployee emplo)
        {
            _emplo = emplo;
        }

        [HttpGet]
        public List<EmployeeModel> GetEmployers()
        {
            return _emplo.GetEmployees();
        }

        public bool InsertEmployee(EmployeeModel employee)
        {
            _emplo.InsertEmployee(employee);
            return true;
        }
    }
}
