using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        // FK
        public int UserId { get; set; }
        // Navigation property
        public User User { get; set; }
        public int Text { get; set; }
        public List<Comment> Comments { get; set; }
    }
}