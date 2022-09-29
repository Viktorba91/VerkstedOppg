using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    public class Fylke
    {
        public string FylkeNavn { get; private set; }
        public int MinPostnummer { get; private set; }
        public int MaxPostnummer { get; private set; }

        //For gjeldende fylker som har ekstra postnummer utenfor opprinnelig rekkefølge
        public int MinPostNummer2 { get; private set; }
        public int MaxPostNummer2 { get; private set; }

        public Fylke(int fylkeId)

        {
            // Utfordringer med å sette opp Array eller liste oppsett for dette

            //Sjekker for valgt fylke, setter postnummer og deretter returnerer verdiene:
            if (fylkeId == 1)
            {
                FylkeNavn = "Oslo";
                MinPostnummer = 0;
                MaxPostnummer = 1300;
            }
            else if (fylkeId == 2)
            {
                FylkeNavn = "Akershus";
                MinPostnummer = 1300;
                MaxPostnummer = 1500;
                MinPostNummer2 = 1900;
                MaxPostNummer2 = 2100;
            }
            else if (fylkeId == 3)
            {
                FylkeNavn = "Østfold";
                MinPostnummer = 1500;
                MaxPostnummer = 1800;
            }
            else if (fylkeId == 4) 
            { 
                int[] Hedmark = { 2100, 2600 };
                FylkeNavn = "Hedmark";
                MinPostnummer = 2100;
                MaxPostnummer = 2600;
            }
            else if (fylkeId == 5) 
            {
                FylkeNavn = "Oppland";
                MinPostnummer = 2600;
                MaxPostnummer = 2900;
            }
            else if (fylkeId == 6)
            {
                FylkeNavn = "Vestfold";
                MinPostnummer = 3000;
                MaxPostnummer = 3200;
            }
            else if (fylkeId == 7)
            {
                FylkeNavn = "Buskerud";
                MinPostnummer = 3200;
                MaxPostnummer = 3600;
            }
            else if (fylkeId == 8)
            {
                FylkeNavn = "Telemark";
                MinPostnummer = 3600;
                MaxPostnummer = 3900;
            }
            else if (fylkeId == 9)
            {
                FylkeNavn = "Rogaland";
                MinPostnummer = 4000;
                MaxPostnummer = 4400;
                MinPostNummer2 = 5500;
                MaxPostNummer2 = 5599;
            }
            else if (fylkeId == 10)
            {
                FylkeNavn = "Vest-Agder";
                MinPostnummer = 4400;
                MaxPostnummer = 4700;
            }
            else if (fylkeId == 11)
            {
                FylkeNavn = "Aust-Agder";
                MinPostnummer = 4700;
                MaxPostnummer = 4999;
            }
            else if (fylkeId == 12)
            {
                FylkeNavn = "Hordaland";
                MinPostnummer = 5000;
                MaxPostnummer = 5900;
            }
            else if (fylkeId == 13)
            {
                FylkeNavn = "Sogn og Fjordane";
                MinPostnummer = 5700;
                MaxPostnummer = 5900;
                MinPostNummer2 = 6700;
                MaxPostNummer2 = 6900;
            }
            else if (fylkeId == 14)
            {
                FylkeNavn = "Møre og Romsdal";
                MinPostnummer = 6000;
                MaxPostnummer = 6600;
            }
            else if (fylkeId == 15)
            {
                FylkeNavn = "Sør-Trøndelag";
                MinPostnummer = 7000;
                MaxPostnummer = 7500;
                MinPostNummer2 = 7700;
                MaxPostNummer2 = 7800;
            }
            else if (fylkeId == 16)
            {
                FylkeNavn = "Nord-Trøndelag";
                MinPostnummer = 7500;
                MaxPostnummer = 7700;
                MinPostNummer2 = 7800;
                MaxPostNummer2 = 7900;
            }
            else if (fylkeId == 17)
            {
                FylkeNavn = "Nordland";
                MinPostnummer = 7900;
                MaxPostnummer = 8400;
                MinPostNummer2 = 8500;
                MaxPostNummer2 = 8900;
            }
            else if (fylkeId == 18)
            {
                FylkeNavn = "Troms";
                MinPostnummer = 8400;
                MaxPostnummer = 8500;
                MinPostNummer2 = 9000;
                MaxPostNummer2 = 9500;
            }
            else if (fylkeId == 19)
            {
                FylkeNavn = "Finnmark";
                MinPostnummer = 9500;
                MaxPostnummer = 9900;
            }

        }
        
    }
    
}




       


        
    

