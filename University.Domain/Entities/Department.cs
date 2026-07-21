using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<Student> Student { get; set; } = new HashSet<Student>();
        public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
    }
}
