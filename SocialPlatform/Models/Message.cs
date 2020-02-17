using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialPlatform.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        // navigation property
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}