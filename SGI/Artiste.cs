using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class Artiste
    {
        private string id;
        private string nom;
        private string prenom;
      


        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
       

        public Artiste(string id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
          
        }

        public override string ToString()
        {
            return "Nom: " + nom + " " + prenom + "\n"
                + "ID Artiste: " + id;
                
        }
    }
}
