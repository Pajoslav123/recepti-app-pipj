using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepti.Model
{
    class Korisnik
    {
        public string KorisnickoIme;
        public string Sifra;
        public string Ime;
        public string Prezime;

        public Korisnik(string KorisnickoIme, string Sifra, string Ime, string Prezime)
        {
            this.KorisnickoIme = KorisnickoIme;
            this.Sifra = Sifra;
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

    }
}
