using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemeTeletonElectronique
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Les deux champs sont nécéssaires");
            }
            else if (textBoxUser.Text == "téléton 2021" && textBoxPass.Text == "Don@2021")
            {
                FormMain formMain = new FormMain();
                formMain.Visible = true;
                formMain.Activate();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrects");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
