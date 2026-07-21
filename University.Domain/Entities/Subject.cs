using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime Proied { get; set; }
        public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
        public ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>();
    }
}
