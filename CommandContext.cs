using Microsoft.EntityFrameworkCore;
using LambdaForums.Models;

namespace LambdaForums
{
    public class CommandContext:DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options):base(options)
        {

        }
       public DbSet<ApplicationUser> ApplicationUsers { get; set; }
       public DbSet<Forum> Forums{get;set;}
       public DbSet<Post> Posts{get;set;}
       public DbSet<PostReply> PostReplies{get;set;}
       
    }
}