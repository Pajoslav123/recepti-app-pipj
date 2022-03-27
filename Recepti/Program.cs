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
            Korisnik k1 = new Korisnik("ivana", "123", "Ivana", "Ivanic");
            Korisnik k2 = new Korisnik("stefan", "123", "Stefan", "Tot");
            Korisnik k3 = new Korisnik("jelena", "123", "Jelena", "Jovanovic");

            Util.registrovaniKorisnici.Add(k1);
            Util.registrovaniKorisnici.Add(k2);
            Util.registrovaniKorisnici.Add(k3);

            Recept r1 = new Recept("Sarma", "Motaj kupus", "Kuvano", k1);
            Recept r2 = new Recept("Pasulj", "Ubaci pasulj u vodu", "Kuvano", k1);
            Recept r3 = new Recept("Cevapi", "Isprzi meso", "Rostilj", k3);
            Recept r4 = new Recept("Cevapi", "Isprzi meso", "Rostilj", k3);
            Recept r5 = new Recept("Cevapi", "Isprzi meso", "Rostilj", k3);
            Recept r6 = new Recept("Cevapi", "Isprzi meso", "Rostilj", k3);
            Recept r7 = new Recept("Cevapi", "Isprzi meso", "Rostilj", k3);
            Util.recepti.Add(r1);
            Util.recepti.Add(r2);
            Util.recepti.Add(r3);
          //  Util.recepti.Add(r4);
            //Util.recepti.Add(r5);
            //Util.recepti.Add(r6);
            //Util.recepti.Add(r7);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ReceptList r = new ReceptList();
            Application.Run(r);
        }
    }
}
