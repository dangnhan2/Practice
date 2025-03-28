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

        public void PrintEmployee()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, BirthDate: {employee.BirthDate}, Salary: {employee.Salary}, Department: {employee.Department}");
            }
        }

        public void PrintTeacher()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Id: {teacher.Id}, Name: {teacher.Name}, BirthDate: {teacher.BirthDate}, Subject: {teacher.Subject}, YearsOfExperience: {teacher.YearsOfExperience}");
            }
        }
    }
}
