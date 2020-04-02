using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticketsysteem.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }

        [Required]
        public string Voornaam { get; set; }

        public string Tussenvoegsels { get; set; }

        [Required]
        public string Achternaam { get; set; }

        public string EmailAdres { get; set; }

        public string Telefoonnummer { get; set; }

        [NotMapped]
        public string VolledigeNaam => $"{Voornaam} {Tussenvoegsels} {Achternaam}";
    }
}
