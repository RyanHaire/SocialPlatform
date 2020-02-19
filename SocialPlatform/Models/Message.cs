using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialPlatform.Models
{
    public class Message
    {
        public int Id { get; set; }
        // navigation property
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}