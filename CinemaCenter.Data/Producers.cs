using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCenter.Data
{
    public class Producers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public int YearWork { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Невалиден имейл адрес")]
        public string Email { get; set; }

        public ICollection<ProducersFilms> ProducersFilms { get; set; }
    }
}
