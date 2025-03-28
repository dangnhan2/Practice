using System;
using LearnGit.Service;

namespace LearnGit
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Hello World!");
            Method method = new Method();
            Employee employee = new Employee(1, "John", new DateTime(1990, 1, 1), 1000, "Scient");
            Teacher teacher = new Teacher(1, "John", new DateTime(1990, 1, 1), "Math", 10);

            method.AddEmployee(employee);
            method.AddTeacher(teacher);
        }
    }
}
