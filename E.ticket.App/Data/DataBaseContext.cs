using E.ticket.App.Models;
using Microsoft.EntityFrameworkCore;

namespace E.ticket.App.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<MovieInActor> MovieInActors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        #region onmodel creat        
        protected override void OnModelCreating(ModelBuilder buiilder)
        {
            HasKey(buiilder);
            base.OnModelCreating(buiilder);
        }
        protected void HasKey(ModelBuilder buiilder)
        {
            buiilder.Entity<MovieInActor>().HasOne(p => p.Movie).WithMany(p => p.MovieInActors)
                .HasForeignKey(p => p.MovieId);
            buiilder.Entity<MovieInActor>().HasOne(p => p.Actor).WithMany(p => p.MovieInActors)
                .HasForeignKey(p => p.ActorId);
        }
        #endregion
    }
}
