using System;

namespace LearnGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee = new Employee(1, "John", new DateTime(1990, 1, 1), 1000, "Scient");
        }
    }
}
