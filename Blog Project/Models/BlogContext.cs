using Microsoft.EntityFrameworkCore;

namespace Blog_Project.Models
{
    public class BlogContext:DbContext
    {

        public virtual DbSet<post> Posts { get; set; }
        public virtual DbSet<Auther> Authers{ get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=BlogApp;Integrated Security=True;Trust Server Certificate=True");
        }
        
    }
}
