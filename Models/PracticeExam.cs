using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sbsc.Models
{
    public class PracticeExam
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public List<Question> Questions { get; set; }

    }
}