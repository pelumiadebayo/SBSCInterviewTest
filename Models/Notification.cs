using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sbsc.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }

    }
}