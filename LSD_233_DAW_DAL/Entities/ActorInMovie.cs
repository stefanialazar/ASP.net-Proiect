using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL.Entities
{
    public class ActorInMovie
    {
        public int ActorInMovieId { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
