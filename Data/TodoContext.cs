using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Todo.api.Entities;

namespace Todo.api.Data
{
    public class TodoContext(DbContextOptions<TodoContext> options) : IdentityDbContext<User>(options)
    {
        public DbSet<Todos> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            
        }
    }
}
