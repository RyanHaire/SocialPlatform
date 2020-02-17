using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialPlatform.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}