using Recepti.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepti.Views
{
    class ReceptView : Panel
    {
        private Recept model;
        private Label lblNaziv= new Label();
        private Label lblTip= new Label();
        private Label lblKorisnik= new Label();

        public void Naziv_Enter(object sender, EventArgs e)
        {
            lblNaziv.BackColor = Color.Red;
            Cursor.Current = Cursors.Hand;
        }
        public void Naziv_Leave(object sender, EventArgs e)
        {
            lblNaziv.BackColor = Color.White;
            Cursor.Current = Cursors.Default;
        }
        public void Naziv_Click(object sender, EventArgs e)
        {
            ReceptDetailView r = new ReceptDetailView();
            r.Show();
        }
        public ReceptView(Recept model, Point location)
        {
            this.model = model;
            Size = new Size(500, 120);
            BorderStyle = BorderStyle.Fixed3D;
            BackColor = Color.White;
            Location = location;

            lblNaziv.Text = model.Naziv;
            lblNaziv.AutoSize=true;
            lblNaziv.Location = new Point(20, 20);
            lblNaziv.MouseEnter += Naziv_Enter;
            lblNaziv.Click += Naziv_Click;
            lblNaziv.MouseLeave += Naziv_Leave;
            lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lblNaziv);

            lblTip.Text = model.TipJela;
            lblTip.AutoSize = true;
            lblTip.Location = new Point(20, 50);
            lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lblTip);

            lblKorisnik.Text = model.Korisnik.KorisnickoIme;
            lblKorisnik.AutoSize = true;
            lblKorisnik.Location = new Point(400, 80);
            lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Controls.Add(lblKorisnik);


        }

    }
}
