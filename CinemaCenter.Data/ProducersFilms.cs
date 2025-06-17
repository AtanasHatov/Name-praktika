using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Data
{
    public class ProducersFilms
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Producer))]
        public int ProducerId { get; set; }
        public Producers? Producer { get; set; }

        [ForeignKey(nameof(Film))]
        public int FilmId { get; set; }
        public Films? Film { get; set; }
    }
}
