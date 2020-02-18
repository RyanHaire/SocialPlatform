using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialPlatform.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}