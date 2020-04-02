using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ticketsysteem.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public int Volgorde { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
