﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGit
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public Person(int Id, string Name, DateTime birthDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.BirthDate = birthDate;
        }
    }
}
