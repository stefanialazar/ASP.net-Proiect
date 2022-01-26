using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSD233_DAW.Entities.DTOs
{
    public class CreateActorDTOcs
    {
        public int ActorId { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public virtual Role Role { get; set; }
        public virtual List<ActorInMovie> ActorsInMovies { get; set; }
    }
}
