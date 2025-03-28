using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    public class Employee : Person
    { 
        public decimal Salary { get; set; }
        public string Department { get; set; } = string.Empty;

        public Employee(int Id, string Name, DateTime birthDate, decimal Salary, string Department) : base(Id, Name, birthDate)
        {
            this.Salary = Salary;
            this.Department = Department;
        }
    }
}
