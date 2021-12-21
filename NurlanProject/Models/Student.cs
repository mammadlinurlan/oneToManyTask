﻿using System;
namespace NurlanProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
