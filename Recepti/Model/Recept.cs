using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepti.Model
{
    class Recept
    {
        public string Naziv;
        public string Opis;
        public string TipJela;
        public Korisnik Korisnik;

        public Recept(string Naziv, string Opis, string TipJela, Korisnik Korisnik)
        {
            this.Naziv = Naziv;
            this.Opis = Opis;
            this.TipJela = TipJela;
            this.Korisnik = Korisnik;
        }

    }
}
