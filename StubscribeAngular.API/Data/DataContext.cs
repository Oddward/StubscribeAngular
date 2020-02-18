using Microsoft.EntityFrameworkCore;
using StubscribeAngular.API.Models; //needed?

namespace StubscribeAngular.API.Data
{
    public class DataContext : DbContext
    {
        //DbContextOptions needed for DbContext to do any work
        //base to chain into the constructor of DcContext
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

    
        public DbSet<Value> Values { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubService> SubServices { get; set ; }
        public DbSet<Subscription> Subscriptions { get; set ; }
        public DbSet<Member> Members { get; set ; }
        public DbSet<User> Users { get; set ; }
        public DbSet<Colour> Colours { get; set; }
        
        //seeding etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Colour>().HasData
            (
                new Colour {Id = 1, name = "white"},
                new Colour {Id = 2, name = "yellow"},
                new Colour {Id = 3, name = "blue"},
                new Colour {Id = 4, name = "purple"},
                new Colour {Id = 5, name = "silver"},
                new Colour {Id = 6, name = "brown"},
                new Colour {Id = 7, name = "green"}
            );
            modelBuilder.Entity<SubCategory>().HasData
            (
                new SubCategory {id = 1, name = "Music streaming"},
                new SubCategory {id = 2, name = "Video streaming"},
                new SubCategory {id = 3, name = "Food delivery"},
                new SubCategory {id = 4, name = "Transportation"},
                new SubCategory {id = 5, name = "Courses"},
                new SubCategory {id = 6, name = "Telecommunication"}
            );
            modelBuilder.Entity<SubService>().HasData
            (
                new SubService {id = 1, name = "Spotify", CategoryId = 1},
                new SubService {id = 2, name = "Netflix", CategoryId = 2},
                new SubService {id = 3, name = "Youtube Premium", CategoryId = 2},
                new SubService {id = 4, name = "Uni-fi", CategoryId = 6}
            );
        }
    }
    
}