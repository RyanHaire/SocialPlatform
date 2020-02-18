using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SocialPlatform.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
       
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }
        //public bool IsVerified { get; set; }

        // ONLINE, OFFLINE, AWAY
        public string OnlineStatus { get; set; }
        public SessionToken Token { get; set; }
        public virtual List<User> Friends { get; set; }
        public virtual List<Message> Messages { get; set; }
        public virtual List<Conversation> Conversations { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}