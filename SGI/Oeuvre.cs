using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class Oeuvre
    {
        private string id;
        private string titre;
        private string annee;
        private double valeur;
        private double prix;
        private char etat;
        private string idArt;
        private string idCons;

        public string Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Annee { get => annee; set => annee = value; }
        public double Valeur { get => valeur; set => valeur = value; }
        public double Prix { get => prix; set => prix = value; }
        public char Etat { get => etat; set => etat = value; }
        public string IdArt { get => idArt; set => idArt = value; }
        public string IdCons { get => idCons; set => idCons = value; }

        public Oeuvre(string id, string titre, string annee, double valeur, char etat, string idArt, string idCons)
        {
            this.id = id;
            this.titre = titre;
            this.annee = annee;
            this.valeur = valeur;
            this.etat = etat;
            this.idArt = idArt;
            this.idCons = idCons;
            this.prix = 0;
        }

        public override string ToString()
        {
            return "Titre: " + titre + "\n"
                + "Annee: " + annee + "\n"
                + "Estimation: " + valeur + "\n"
                + "Etat: " + etat + "\n"
                + "Prix de vente: " + prix + "\n"
                + "ID Artiste: " + idArt + "\n"
                + "ID Conservateur: " + idCons;
        }
    }


}
