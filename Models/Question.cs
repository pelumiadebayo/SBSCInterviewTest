﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sbsc.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int CourseId { get; set; }
        public string ExamQuestion { get; set; }

    }
}