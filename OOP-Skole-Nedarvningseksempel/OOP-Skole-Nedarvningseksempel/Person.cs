using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Skole_Nedarvningseksempel
{
    class Person
    {
        //Get set variabler
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }

        //Default Constructor //Nødvendig
        public Person()
        {
        }

        public Person(string fnavn, string enavn, string adr)
        {
            Fornavn = fnavn;
            Efternavn = enavn;
            Adresse = adr;
        }
    }

    class Personale : Person
    {
        public Personale()
        {
        }

        public string LønKontoNr { get; set; }

        public Personale(string fnavn, string enavn, string adr, string lkto) :  base (fnavn, enavn, adr)
        {
            LønKontoNr = lkto;
        }
    }

    class Elev : Person
    {
        public Elev()
        {
        }

        public int StudieNr { get; set; }

        public Elev(string fnavn, string enavn, string adr, int stunr) : base(fnavn, enavn, adr)
        {
            StudieNr = stunr;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
