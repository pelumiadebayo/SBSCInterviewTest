using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sbsc.Models
{
    public class Support
    {
        [Key]
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public List<SupportThread> SupportThread { get; set; }

    }
}