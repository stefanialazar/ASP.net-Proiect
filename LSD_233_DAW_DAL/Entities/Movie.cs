using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string MovieTrailerURL { get; set; }
        public int PhaseId { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual ICollection<ActorInMovie> ActorsInMovies { get; set; }
    }
}
