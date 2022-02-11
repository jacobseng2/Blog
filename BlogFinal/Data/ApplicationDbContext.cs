using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlogFinal.Models;

namespace BlogFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BlogFinal.Models.Post> Post { get; set; }
        public DbSet<BlogFinal.Models.Comment> Comment { get; set; }
    }
}