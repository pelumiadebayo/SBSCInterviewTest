using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sbsc.Models
{
    public class SupportThread
    {
        [Key]
        public int Id { get; set; }
        public string SupportId { get; set; }
        public string Message { get; set; }
        public string SupportingFile { get; set; }
        public string ApplicationUserId { get; set; }
    }
}