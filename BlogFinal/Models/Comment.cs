﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlogFinal.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int? PostId { get; set; }
        public Post? Post { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public string? UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
