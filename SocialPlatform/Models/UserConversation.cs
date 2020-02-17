using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SocialPlatform.Models
{
    public class UserConversation
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int ConversationId { get; set; }

    }
}