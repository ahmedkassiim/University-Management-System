using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.Domain.Entities
{
    public class Student
    {
        [Key]
        public int StuId { get; set; }
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string Phone { get; set; } = default!;

        public int DepartmentId { get; set; }  // FK Column 
        public Department Departments { get; set; }  // NP 1 to M [Department]



    }
}
