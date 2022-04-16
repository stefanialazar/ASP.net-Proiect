using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<ActorInMovie> ActorsInMovies { get; set; }
    }
}
