using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Emp.Model
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Empname { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string DOJ { get; set; } = string.Empty;
        public long Empno { get; set; }
        public string Empemail { get; set; } = string.Empty;
        public long Empidcardno { get; set; }
        public double Empsalary { get; set; }
        public string Company { get; set; } = string.Empty;
    }
}
