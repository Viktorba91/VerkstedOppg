using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Verksted
{
    public class Funksjoner
    {
        public List<Verksted> HentAlleVerksted()
        {
            // Henter frem filen fra prosjektet:
            string fileName = "VerkstedInfo.json";
            string jsonString = File.ReadAllText(fileName);

            //Gjør om string filen til inndelt liste:
            List<Verksted>? verkstedListe = JsonSerializer.Deserialize<List<Verksted>>(jsonString);
            return verkstedListe;
        }

        //Programmet printer ut alle verksted som er funnet ift fylke via postnummer grense.
        // List ut Verksteder:
        public List<Verksted> ValgtFylkeVerkstedListe(List<Verksted> verkstedListe, List<Verksted> fylkeListe,
            Fylke fylke, int minPostNr, int maxPostNr)
        {
            string stringPostNr = "";
            int postNr = 0;
            foreach (var verksted in verkstedListe)
            {
                stringPostNr = verksted.Postnummer.ToString();
                if (Int32.TryParse(stringPostNr, out postNr))
                {
                    if (postNr > minPostNr && postNr < maxPostNr || postNr == maxPostNr || postNr == minPostNr)
                    {
                        fylkeListe.Add(verksted);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return fylkeListe;
        }

        //Henter inn listen for alle verksted i fylke, og lager en ny filterListe som så kjører gjennom og finner gjeldende verksted basert på kriteriene:
        public List<Verksted> SjekkGodkjenninger(List<Verksted> fylkeListe, List<int> valgtGodkjenningerListe, string[] godkjenningsArray)
        {
            string forrigeGodkjenning = "";
            int antallGodkjenninger = valgtGodkjenningerListe.Count();
            List <Verksted> filterListe = new List<Verksted>();
            if (valgtGodkjenningerListe.Count() > 0)
            {
                forrigeGodkjenning = godkjenningsArray[valgtGodkjenningerListe[0]];
                foreach (var godkjenning in valgtGodkjenningerListe)
                {
                    string godkjenningsType = godkjenningsArray[godkjenning];
                    filterListe = FilterVerkstedPåType(fylkeListe, filterListe, godkjenningsType, forrigeGodkjenning, antallGodkjenninger);

                    //Forrige godkjenning lagres for å sørge for at den er med i Contains på neste løkkerunde om man har valgt flere godkjenninger
                    forrigeGodkjenning = godkjenningsType;
                }
            }
            else
            {
                filterListe = fylkeListe;
            }
            return filterListe;
        }


        //Går gjennom listen basert på godkjenninger array lengde og legger til gjeldende verksted i filtrert liste:
        public List<Verksted> FilterVerkstedPåType(List<Verksted> verkstedListe,List<Verksted>filterListe, string godkjenningsType, string forrigeGodkjenning, int antallGodkjenninger) 
        {
            
            foreach (var verksted in verkstedListe)
            {
                if (antallGodkjenninger > 0)
                {
                    //Sjekker om innhold av valgt godkjenningstype
                    if (verksted.Godkjenningstyper.Contains(godkjenningsType) && 
                        !filterListe.Contains(verksted) && 
                        verksted.Godkjenningstyper.Contains(forrigeGodkjenning))
                    {
                        filterListe.Add(verksted);
                    }
                }
            }


            return filterListe;
        }

    }
}
