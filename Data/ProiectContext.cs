using LSD233_DAW.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LSD233_DAW.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options) { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ActorInMovie> ActorsInMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One - One ( Role - Actor )
            modelBuilder.Entity<Role>()
                .HasOne(a => a.Actor)
                .WithOne(r => r.Role)
                .HasForeignKey<Role>(a => a.ActorId);

            // One - Many ( Phase - Movie )
            modelBuilder.Entity<Movie>()
                .HasOne(p => p.Phase)
                .WithMany(m => m.Movies)
                .HasForeignKey(p => p.PhaseId);

            // Many - Many ( Actor - Movie )
            modelBuilder.Entity<ActorInMovie>().HasKey(aim => new { aim.ActorId, aim.MovieId });

            modelBuilder.Entity<ActorInMovie>()
                .HasOne(a => a.Actor)
                .WithMany(aim => aim.ActorsInMovies)
                .HasForeignKey(a => a.ActorId);

            modelBuilder.Entity<ActorInMovie>()
               .HasOne(m => m.Movie)
               .WithMany(aim => aim.ActorsInMovies)
               .HasForeignKey(m => m.MovieId);

            base.OnModelCreating(modelBuilder);
        }
    };
}
