using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    internal class PrintUtFilterListe
    {
        public void PrintUtListe(List<Verksted> filterListe)
        {
            foreach (var verksted in filterListe)
            {
                Console.WriteLine($"Navn: {verksted.Bedriftsnavn}");
                Console.WriteLine($"Adresse: {verksted.Adresse}");
                Console.WriteLine($"Postnummer: {verksted.Postnummer}");
                Console.WriteLine($"Poststed: {verksted.Poststed}");
                Console.WriteLine($"Godkjenningstyper: {verksted.Godkjenningstyper}");
                Console.WriteLine($"Organisasjonsnummer: {verksted.Organisasjonsnummer}");
                Console.WriteLine($"Godkjenningsnummer: {verksted.Godkjenningsnummer}");
            }
        }
}
}
