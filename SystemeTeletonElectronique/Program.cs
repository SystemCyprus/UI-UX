using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioProjet;

namespace SystemeTeletonElectronique
{
    static class Program
    {
        // objet statique du projet  GestionnaireSTE
        public static GestionnaireSTE steGestionnaire = new GestionnaireSTE();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLogin());

        }

        public static void Quitter()
        {
            //On s'assure que l'utilisateur veut fermer
            DialogResult reponse;
            reponse = MessageBox.Show("Desirez vous quitter ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si c'est le cas, on ferme
            if (reponse == DialogResult.Yes)
                Application.Exit();
        }
    }
}
