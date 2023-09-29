using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class Conservateur
    {
        private string id;
        private string nom;
        private string prenom;
        private double comm;


        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public double Comm { get => comm; set => comm = value; }

        public Conservateur(string id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.comm = 0;
        }

        public override string ToString()
        {
            return "Nom: "+nom+" "+prenom+"\n"
                +"ID Conservateur: "+id+"\n"
                + "Commission: " + comm;
        }
    }
}
