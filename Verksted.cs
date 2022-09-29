using System.Text.Json;


namespace Verksted
{
    public class Verksted
    {
        public string? Bedriftsnavn { get; set; }
        public string? Adresse { get; set; }
        public Object Postnummer { get; set; }
        public string? Poststed { get; set; }
        public string? Godkjenningstyper { get; set; }
        public int Organisasjonsnummer { get; set; }
        public int Godkjenningsnummer { get; set; }

    }
}
