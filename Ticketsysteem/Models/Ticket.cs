using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticketsysteem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [ForeignKey("Applicatie")]
        public int ApplicatieId { get; set; }

        public virtual Applicatie Applicatie { get; set; }

        [ForeignKey("Klant")]
        public int KlantId { get; set; }

        public virtual Klant Klant { get; set; }

        [Required]
        public string Onderwerp { get; set; }

        public string Omschrijving { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
    }
}
