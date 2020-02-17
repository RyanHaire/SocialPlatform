using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialPlatform.Models
{
    public class User
    {
        public int Id { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsVerified { get; set; }

        // ONLINE, OFFLINE, AWAY
        public string OnlineStatus { get; set; }
        public List<User> Friends { get; set; }
        public List<Message> Messages { get; set; }
        public List<Conversation> Conversations { get; set; }
        public List<Post> Posts { get; set; }
    }
}