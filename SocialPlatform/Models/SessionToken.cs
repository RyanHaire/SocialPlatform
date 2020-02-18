
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialPlatform.Models
{
    public class SessionToken
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Token { get; set; }
        public User User { get; set; }
    }
}