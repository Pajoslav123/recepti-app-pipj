using Recepti.Model;
using Recepti.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepti
{
    static class Util
    {
        public static Korisnik logovaniKorisnik;
        public static List<Korisnik> registrovaniKorisnici  = new List<Korisnik>();
        public static List<Recept> recepti = new List<Recept>();

        public static bool login(string username, string password)
        {
            foreach(Korisnik k in registrovaniKorisnici)
            {
                if (k.KorisnickoIme.Equals(username) && k.Sifra.Equals(password))
                {
                    logovaniKorisnik = k;
                    return true;
                }
            }
            return false;

            //return registrovaniKorisnici.Find(k => { return k.KorisnickoIme.Equals(username) && k.Sifra.Equals(password); }) != null;
        }
       
        public static void logout()
        {
            logovaniKorisnik = null;
        }
    }
}
