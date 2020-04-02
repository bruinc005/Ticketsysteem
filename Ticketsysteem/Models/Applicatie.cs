using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticketsysteem.Models
{
    public class Applicatie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Beheerder")]
        public int MedewerkerID { get; set; }

        public virtual Medewerker Beheerder { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
