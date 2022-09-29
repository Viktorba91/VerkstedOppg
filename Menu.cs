using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    internal class Menu
    {
        // ------------------- Fylke Valg Meny -----------------------
        public int velgFylke()
        {
            Console.WriteLine("Velkommen til Verksted listen!\n");
            Console.WriteLine("Vennligst velg ett fylke ved å skrive inn gjeldende indeks nummer: \n");
            Console.WriteLine(" 1) Oslo      2) Akershus     3) Østfold      4) Hedmark\n");
            Console.WriteLine(" 5) Oppland   6) Vestfold     7) Buskerud     8) Telemark\n");
            Console.WriteLine(" 9) Rogaland  10) Vest-Agder  11) Aust-Agder  12) Hordaland\n");
            Console.WriteLine("13) Sogn og Fjordane   14) Møre og Romsdal    15) Sør-Trøndelag\n");
            Console.WriteLine("16) Nord-Trøndelag     17) Nordland           18) Troms\n");
            Console.WriteLine("19) Finnmark");

            int fylkeId = 0;
            bool isValid = false;
            var userInput = "";

            //Sikkerhetsløkke for riktig format/tall input
            while (isValid == false)
            {
                userInput = Console.ReadLine();
                Int32.TryParse(userInput, out fylkeId);

                if (fylkeId > 0 && fylkeId < 20)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Feil format/tall valgt, vennligst velg et tall fra 1 til 20.");
                }
            }
            return fylkeId;
        }


        // ------------------- GodkjenningsType Valg Meny -----------------------
        public List<int> velgGodkjenninger(List<int> godkjenningId, Fylke fylke)
        {
            var userInput = "";
            int godkjenningIndex = 0;
            var isAdding = true;
            string[] godkjenningstyper = Godkjenningstyper.HentGodkjenningstyper();

            Console.WriteLine($"Velg godkjenningstyper du vil filtrere på, ");
            Console.WriteLine($"eller tast 0 for å vise alle verksted som finnes i {fylke.FylkeNavn} \n");
            Console.WriteLine(" 1) Kontrollorgan01    2) Kontrollorgan01B    3) Kontrollorgan02 \n");
            Console.WriteLine(" 4) Kontrollorgan03    5) Kontrollorgan04     6) Kontrollorgan05 \n");
            Console.WriteLine(" 7) BILVERKSTED01      8) BILVERKSTED01B      9) BILVERKSTED02 \n");
            Console.WriteLine("10) BILVERKSTED03     11) BILVERKSTEDALLE    12) MOTORSYKKELOGMOPED \n");
            Console.WriteLine("13) BILSKADE          14) SKADEVERKSTED01    15) SKADEVERKSTED02\n");
            Console.WriteLine("16) FARTSSKRIVER      17) BILBREMSE          18) BILDIESEL \n");
            Console.WriteLine("19) HJULUTRUSTNING    20) PÅBYGGER           21) ALKOLÅSVERKSTED \n");
            Console.WriteLine("22) BILELEKTRODRIVSTOFFANLEGG  23) TRAKTOR    24) LYSUTSTYR \n");
            Console.WriteLine("25) HENGERESPÅLØPSBREMSEANLEGG  26) EKSOSANLEGG \n"); 

            //Legger til valgte godkjenningstyper
            while (isAdding)
            {
                userInput = Console.ReadLine();
                Int32.TryParse(userInput, out godkjenningIndex);
                if (godkjenningIndex > 0 && godkjenningIndex < 27 && !godkjenningId.Contains(godkjenningIndex))
                {
                    godkjenningId.Add(godkjenningIndex);
                    Console.WriteLine(godkjenningstyper[godkjenningIndex] + " er lagt til, velg flere å legge til, " +
                        "eller tast (0) for å finne gjeldende verksteder");
                }
                else if (godkjenningIndex == 0)
                {
                    isAdding = false;
                }
                else if (godkjenningId.Contains(godkjenningIndex))
                {
                    Console.WriteLine("Listen har allerede lagt til " + godkjenningstyper[godkjenningIndex]);
                }
                else
                {
                    Console.WriteLine("Feil format/tall valgt, vennligst velg et tall fra 1 til 20.");
                }
            }
            return godkjenningId;
        }
    }
}

