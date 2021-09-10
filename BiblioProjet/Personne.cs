using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// objet personne, qui contient les infos que les objets
// donateurs et commanditaires partagent et peuvent en heriter
namespace BiblioProjet
{
    public class Personne
    {
        private string prenom;
        private string surnom;

        public Personne(string prenom, string surnom)
        {
            this.prenom = prenom;
            this.surnom = surnom;
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public string Surnom
        {
            get { return this.surnom; }
            set { this.surnom = value; }
        }
        public override string ToString()
        {
            return this.prenom + " " + this.surnom;
        }
    }
}
