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
        private LoginForma form = new LoginForma();

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

            LoginBtn.Text = "Login";
            LoginBtn.Top = 30; 
            LoginBtn.Left = 580;
            LoginBtn.Click += LoginBtn_Click;
            Controls.Add(LoginBtn);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        public void logovanjeUspesno()
        {
            LoginBtn.Hide();
        }
    }
}
