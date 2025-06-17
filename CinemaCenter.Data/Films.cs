using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Data
{
    public class Films
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Studios))]
        public int StudioId { get; set; }
        public Studios? Studio { get; set; }

        [ForeignKey(nameof(Directors))]
        public int DirectorId { get; set; }
        public Directors? Director { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        [Range(1900,2025)]
        public int YearPublished { get; set; }

        public ICollection<ActorsFilms> ActorsFilms { get; set; }

        public ICollection<ProducersFilms> ProducersFilms { get; set; }
    }
}
