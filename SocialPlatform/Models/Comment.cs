using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SocialPlatform.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public Post Post { get; set; }
        public string Text { get; set; }
    }
}