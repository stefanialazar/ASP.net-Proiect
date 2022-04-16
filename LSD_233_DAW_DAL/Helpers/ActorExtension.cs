using LSD_233_DAW_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSD_233_DAW_DAL.Helpers
{
    public static class ActorExtension
    {
        public static IQueryable<Actor> IncludeMovie(this IQueryable<Actor> actors)
        {
            return actors.Include(x => x.ActorsInMovies);
        }

        public static IQueryable<Actor> WhereClauses(this IQueryable<Actor> actors)
        {
            return actors
                .IncludeMovie()
                .Where(x => x.ActorFirstName == "Chris");

        }
    }
}
