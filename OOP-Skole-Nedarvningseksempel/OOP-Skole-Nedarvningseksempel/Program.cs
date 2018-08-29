using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Skole_Nedarvningseksempel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fornavn, Efternavn, Adresse. Nedarves fra Person Klassen kun LønKntoNr er unikt for Personale klassen
            Personale p1 = new Personale { Fornavn = "Biver", Efternavn = "Jensen", Adresse = "Skælbæksgade", LønKontoNr = "123456789" };

            //Fornavn, Efternavn, Adresse. Nedarves fra Person Klassen kun StudieNr er unikt for Elev klassen
            Elev e1 = new Elev { Fornavn = "Jim", Efternavn = "Jones", Adresse = "Rockerborgen 4", StudieNr = 987654321 };

            Console.WriteLine("Fornavn : " + p1.Fornavn + " | " + "Efternavn : " + p1.Efternavn + " | " + "Adresse : " + p1.Adresse + " | " + "Lønkonto nr : " + p1.LønKontoNr);

            Console.WriteLine("Fornavn : " + e1.Fornavn + " | " + "Efternavn : " + e1.Efternavn + " | " + "Adresse : " + e1.Adresse + " | " + "Studie nr : " + e1.StudieNr);

            Console.ReadKey();
        }
    }
}
