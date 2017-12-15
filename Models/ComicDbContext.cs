using Microsoft.EntityFrameworkCore;
using Azurepeakswebcomic.Models.Entities;

namespace Azurepeakswebcomic.Models
{
    public class ComicDbContext : DbContext
    {
        public DbSet<Comic> Comics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./Azurepeakswebcomic.db");
        } 
        
    }
    
}