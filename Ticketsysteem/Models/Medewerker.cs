using System.Collections.Generic;

namespace Ticketsysteem.Models
{
    public class Medewerker : Gebruiker
    {
        public virtual ICollection<Applicatie> Applicaties { get; set; }
    }
}
