using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    public static class Godkjenningstyper
    {
        private static string[] godkjenningstyper = 
        {
            "index:", "KONTROLLORGAN01", "KONTROLLORGAN01B", "KONTROLLORGAN02",
            "KONTROLLORGAN03", "KONTROLLORGAN04", "KONTROLLORGAN05",
            
            "BILVERKSTED01", "BILVERKSTED01B", "BILVERKSTED02", 
            "BILVERKSTED03", "BILVERKSTEDALLE",

            "MOTORSYKKELOGMOPED", "BILSKADE", "SKADEVERKSTED01",
            "SKADEVERKSTED02", "FARTSSKRIVER", "BILBREMSE", 
            "BILDIESEL", "HJULUTRUSTNING", "PABYGGER", 

            "ALKOLASVERKSTED", "BILELEKTRODRIVSTOFFANLEGG", "TRAKTOR", 
            "LYSUTSTYR", "HENGERESPALOPSBREMSEANLEGG", "EKSOSANLEGG", 
            "GASSDRIFTANLEGG", "BILGLASS",

        };
       
       public static string[] HentGodkjenningstyper() {
        return godkjenningstyper;
       }
    }
}
