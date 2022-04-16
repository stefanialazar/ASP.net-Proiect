using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL.Entities
{
    public class Phase
    {
        public int PhaseId { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
