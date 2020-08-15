using System;
using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options) {

        }

        public DbSet<Value> Values { get; set;}
        public DbSet<Activity> Activities { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Value>()
                .HasData(
                    new Value {Id=1, Name="Hello, Ched"},
                    new Value {Id=2, Name="Hello, Angie"},
                    new Value {Id=3, Name="Hello, Kyndal"},
                    new Value {Id=4, Name="Hello, Brantly"},
                    new Value {Id=5, Name="Hello, Noah"}
                );
        }
    }
}
