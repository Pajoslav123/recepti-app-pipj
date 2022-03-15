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
    public partial class LoginForma : Form
    {

        private Label lblErr = new Label();

        private Label lblUsername = new Label();
        private Label lblPassword = new Label();
        private TextBox txtUsername = new TextBox();
        private TextBox txtPassword = new TextBox();
        private Button btnLogin = new Button();
        private Button btnCancel = new Button();

        private ReceptList parent;

        public LoginForma()
        {
            InitializeComponent();


            lblUsername.Text = "Korisnicko ime";
            lblUsername.Location = new Point(10, 10);
            Controls.Add(lblUsername);

            txtUsername.Location = new Point(10, 40);
            txtUsername.Width = 180;
            txtUsername.TextChanged += reseTxt;
            Controls.Add(txtUsername);

            lblPassword.Text = "Lozinka";
            lblPassword.Location = new Point(10, 70);
            Controls.Add(lblPassword);

            txtPassword.Location = new Point(10, 100);
            txtPassword.Width = 180;
            txtPassword.TextChanged += reseTxt;
            txtPassword.PasswordChar = '*';
            Controls.Add(txtPassword);

            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            btnLogin.Location = new Point(10, 130);
            Controls.Add(btnLogin);

            lblErr.Text = "";
            lblErr.ForeColor = Color.Red;
            lblErr.Location = new Point(10, 170);
            lblErr.Width = 300;
            Controls.Add(lblErr);

            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            btnCancel.Location = new Point(120, 130);
            Controls.Add(btnCancel);
        }

        private void reseTxt(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtUsername.ForeColor = Color.Black;
            lblErr.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Util.login(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                this.parent.logovanjeUspesno();
            }
            else
            {
                lblErr.Text = "Proverite lozinku/username!";
                txtUsername.ForeColor = Color.Red;
                txtPassword.ForeColor = Color.Red;

            }
        }
        

    }
}
