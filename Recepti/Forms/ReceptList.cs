using Recepti.Model;
using Recepti.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepti.Forms
{
    public partial class ReceptList : Form
    {
        private Button LoginBtn = new Button();
        private Button LogoutBtn = new Button();
        private Button CreateRecept = new Button();
        private Label LogovanUserLbl = new Label();
        private Panel ReceptContainer = new Panel();

        public ReceptList()
        {
            InitializeComponent();
            InitView();
        }

        private void ReceptList_Load(object sender, EventArgs e)
        {

        }
        
        private void InitView()
        {
            this.ClientSize = new Size(800,600);

            CreateRecept.Text = "Kreiraj recept";
            CreateRecept.Top = 50;
            CreateRecept.Left = 650;
            CreateRecept.Hide();
            CreateRecept.Click += CreateRecept_Click;
            Controls.Add(CreateRecept);
            

            LoginBtn.Text = "Login";
            LoginBtn.Top = 50; 
            LoginBtn.Left = 580;
            LoginBtn.Click += LoginBtn_Click;
            Controls.Add(LoginBtn);

            LogoutBtn.Text = "Logout";
            LogoutBtn.Top = 50;
            LogoutBtn.Left = 580;
            LogoutBtn.Click += LogoutBtn_Click;
            Controls.Add(LogoutBtn);
            LogoutBtn.Hide();

            LogovanUserLbl.Location = new Point(580, 25);
            Controls.Add(LogovanUserLbl);

            ReceptContainer.Size = new Size(700, 490);
            ReceptContainer.BackColor = Color.Gray;
            ReceptContainer.Location = new Point(50, 100);
            ReceptContainer.AutoScroll = true;
            Controls.Add(ReceptContainer);

            displayRecept(false);
        }
        public void displayRecept(bool naknadno)
        {
            ReceptContainer.Controls.Clear();
            int y=0;
            int spacing = 20;

            foreach (Recept r in Util.recepti)
            {
                ReceptView view = new ReceptView(r, new Point(100, y + spacing));
                ReceptContainer.Controls.Add(view);
                y += view.Height + spacing;

            }

            if (naknadno)
            {
                foreach(Recept r in Util.recepti)
                {
                    y += 60;
                }
                ReceptContainer.Controls.Add(new ReceptView(Util.recepti.Last(), new Point(100, y)));
            }

                

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForma form = new LoginForma(this);
            form.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Util.logout();
            LogoutBtn.Hide();
            LoginBtn.Show();
            CreateRecept.Hide();
            LogovanUserLbl.Text = "";
        }
        private void CreateRecept_Click(object sender, EventArgs e)
        {
            CreateReceptForm crf = new CreateReceptForm(this);
            crf.Show();
        }
        public void logovanjeUspesno()
        {
            if (Util.logovaniKorisnik != null)
            {
                LogovanUserLbl.Text = "Dobrodosli " + Util.logovaniKorisnik.Ime + " " + Util.logovaniKorisnik.Prezime;
                LoginBtn.Hide();
                CreateRecept.Show();
                LogoutBtn.Show();
            }
        }

    }
}
