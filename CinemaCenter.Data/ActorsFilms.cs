using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Data
{
    public class ActorsFilms
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Actor))]
        public int ActorId { get; set; }
        public Actors? Actor { get; set; }

        [ForeignKey(nameof(Film))]
        public int FilmId { get; set; }
        public Films? Film { get; set; }
    }
}
