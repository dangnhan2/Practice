using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit.Service
{
    public class Method
    {
        List<Employee> employees = new List<Employee>();
        List<Teacher> teachers = new List<Teacher>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
    }
}
