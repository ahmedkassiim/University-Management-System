using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University.Domain.Entities
{
    public class DepartmentSubject
    {

        [Key]
        public int DeptSubId { get; set; }
        public int DepartmentId { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; } = default!;
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; } = default!;
    }
}
