using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Verksted
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Oppretter funksjoner, verksted liste og godkjenningstype index liste:
            var funksjoner = new Funksjoner();
            List<Verksted> verkstedListe = funksjoner.HentAlleVerksted();
            List<int> godkjenningIntListe = new List<int>();
            
            //Oppsett av meny
            Menu meny = new Menu();
            // Fylke, bruker velger en |fylkeId (integer)| som input og vil returneres
            int fylkeId = meny.velgFylke();
            Fylke fylke = new Fylke(fylkeId);

            //Deklarerer lokale variabler til å være lik minimum og maksimum postnummer innen valgt fylke:
            int minPostNr = fylke.MinPostnummer;
            int maxPostNr = fylke.MaxPostnummer;

            // Oppretter og henter ut verksteder fra valgt fylke:
            List<Verksted> fylkeListe = new List<Verksted>(); 
            fylkeListe = funksjoner.ValgtFylkeVerkstedListe(verkstedListe, fylkeListe, fylke, minPostNr, maxPostNr);
            
            
            //Kjør gjennom enda en gang hvis flere postnummer
            Console.WriteLine(fylke.MinPostNummer2);
            if (fylke.MinPostNummer2 != 0)
            {
                minPostNr = fylke.MinPostNummer2;
                maxPostNr = fylke.MaxPostNummer2;
                fylkeListe = funksjoner.ValgtFylkeVerkstedListe(verkstedListe, fylkeListe, fylke, minPostNr, maxPostNr);
            }

            Console.WriteLine($"Fant {fylkeListe.Count()} verksted i {fylke.FylkeNavn} fylke.");

            //Henter ut valgte godkjenningstyper
            godkjenningIntListe = meny.velgGodkjenninger(godkjenningIntListe, fylke);
            string[] godkjenningstyper = Godkjenningstyper.HentGodkjenningstyper();

            //Oppretter filtrert liste og sjekker godkjennings kriteriene:
            List<Verksted> filterListe = new List<Verksted>();
            filterListe = funksjoner.SjekkGodkjenninger(fylkeListe, godkjenningIntListe, godkjenningstyper);

            //Printer til konsoll alle verksted basert på brukersøk:
            PrintUtFilterListe printVerksted = new PrintUtFilterListe();
            printVerksted.PrintUtListe(filterListe);

            
            Console.WriteLine($"\nFant {filterListe.Count()} verksteder i {fylke.FylkeNavn} som har gjeldende godkjenningstype(r): ");
            string godkjenningstyperString = "";

            foreach (var typeId in godkjenningIntListe)
            {
                if (godkjenningIntListe.Count() > 0) { 
                godkjenningstyperString += godkjenningstyper[typeId] + ". ";
                }
                else
                {
                    Console.WriteLine("Ingen godkjenningstyper var lagt til.");
                }
            }
            Console.WriteLine(godkjenningstyperString);
           
        }




        

       
    }
}