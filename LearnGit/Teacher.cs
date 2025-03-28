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
    }
}
