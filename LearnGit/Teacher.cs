using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    public class Teacher : Person
    {
        public string Subject { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; }

        public Teacher(int Id, string Name, DateTime birthDate, string Subject, int YearsOfExperience) : base(Id, Name, birthDate)
        {
            this.Subject = Subject;
            this.YearsOfExperience = YearsOfExperience;
        }
    }
}
