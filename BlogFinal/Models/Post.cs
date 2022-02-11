using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogFinal.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string? Title { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public string? Body { get; set; }
        public List<Comment>? Comments { get; set; }
        public IdentityUser? User { get; set; }
        public string? UserId { get; set; }

    }
}
