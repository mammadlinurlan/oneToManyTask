using System;
using System.Collections.Generic;

namespace NurlanProject.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Speciality { get; set; }
        public string GroupNo { get; set; }
        public List<Student> Students { get; set; }
    }
}
