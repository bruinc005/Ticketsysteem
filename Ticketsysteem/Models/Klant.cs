using System.Collections.Generic;

namespace Ticketsysteem.Models
{
    public class Klant : Gebruiker
    {
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
