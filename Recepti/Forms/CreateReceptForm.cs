using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recepti.Model;
using Recepti;
namespace Recepti.Forms
{
    public partial class CreateReceptForm : Form
    {
        private Label lblNaziv = new Label();
        private Label lblTip = new Label();
        private Label lblOpis = new Label();
        private ComboBox cbTip = new ComboBox();
        private TextBox txtNaziv = new TextBox();
        private TextBox txtOpis = new TextBox();
        private Button btnExit = new Button();
        private Button btnSave = new Button();
        public CreateReceptForm()
        {
            InitializeComponent();
            initView();
        }

        public void initView()
        {
            Size = new Size(400, 800);

            lblNaziv.Text = "Naziv";
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(40, 70);
            Controls.Add(lblNaziv);

            txtNaziv.Location = new Point(100, 70);
            txtNaziv.Width = 150;
            Controls.Add(txtNaziv);

            txtOpis.Location = new Point(40, 220);
            txtOpis.Size = new Size(200, 400);
            txtOpis.Multiline = true;
            Controls.Add(txtOpis);

            cbTip.Location = new Point(100, 130);
            cbTip.Items.AddRange(new object[] {
            "Kuvano",
            "Rostilj",
            "Dezert",
            "Corba/Supa"});
            cbTip.Width = 150;
            Controls.Add(cbTip);

            lblTip.Text = "Tip";
            lblTip.AutoSize = true;
            lblTip.Location = new Point(40, 130);
            Controls.Add(lblTip);

            lblOpis.Text = "Opis";
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(40, 190);
            Controls.Add(lblOpis);

            btnSave.Text = "Save";
            btnSave.Location = new Point(ClientRectangle.Width / 2, ClientRectangle.Height - 30);
            Controls.Add(btnSave);

            btnExit.Text = "Cancel";
            btnExit.Click += btnExit_Click;
            btnExit.Location = new Point(300, ClientRectangle.Height - 30);
            Controls.Add(btnExit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Recept r = new Recept(txtNaziv.Text, txtOpis.Text, cbTip.Text, Util.logovaniKorisnik);
            this.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateReceptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
