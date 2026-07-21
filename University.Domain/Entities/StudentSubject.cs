using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace University.Domain.Entities
{
    public class StudentSubject
    {
        [Key]
        public int StuSubId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("StudentId")]
        public Student Students { get; set; } = default!;
        [ForeignKey("SubjectId")]
        public Subject Subjects { get; set; } = default!;
    }
}
