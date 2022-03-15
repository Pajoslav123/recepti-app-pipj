using Recepti.Forms;
using Recepti.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepti
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Korisnik k1 = new Korisnik("ivana","123","Ivana","Ivanic");
            Korisnik k2 = new Korisnik("stefan", "123", "Stefan", "Tot");
            Korisnik k3 = new Korisnik("jelena", "123", "Jelena", "Jovanovic");

            Util.registrovaniKorisnici.Add(k1);
            Util.registrovaniKorisnici.Add(k2);
            Util.registrovaniKorisnici.Add(k3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ReceptList r = new ReceptList();
            Application.Run(r);
        }
    }
}
