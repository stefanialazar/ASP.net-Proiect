using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LSD233_DAW.Entities
{
    public class ActorInMovie
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
