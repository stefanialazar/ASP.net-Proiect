using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LSD_233_DAW_DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LSD_233_DAW_DAL.Configurations
{
    internal class ActorMovieConfiguration : IEntityTypeConfiguration<ActorInMovie>
    {
        public void Configure(EntityTypeBuilder<ActorInMovie> builder)
        {
            builder.HasOne(a => a.Actor)
                .WithMany(aim => aim.ActorsInMovies)
                .HasForeignKey(a => a.ActorId);

            builder.HasOne(m => m.Movie)
               .WithMany(aim => aim.ActorsInMovies)
               .HasForeignKey(m => m.MovieId);
        }
    }
}
