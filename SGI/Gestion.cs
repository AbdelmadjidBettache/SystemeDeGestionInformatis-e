using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class Gestion
    {
        List<Conservateur> conservateurs;
        List<Artiste> artistes;
        List<Oeuvre> oeuvres;

        public Gestion()
        {
            conservateurs = new List<Conservateur>();
            artistes = new List<Artiste>();
            oeuvres = new List<Oeuvre>();
        }

        public void AddConservateur(Conservateur conservateur)
        {
            conservateurs.Add(conservateur);
        }

        public string AfficherConservateus()
        {
            string result = "";
            foreach (Conservateur item in conservateurs)
            {
                result += item.ToString()+"\n";
            }
            return result;
        }

        public void AddArtiste(Artiste art)
        {
            artistes.Add(art);
        }

        public string AfficherArtistes()
        {
            string result = "";
            foreach (Artiste item in artistes)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }

        public void AddOeuvre(Oeuvre oeuv)
        {
            oeuvres.Add(oeuv);
        }

        public string AfficherOeuvres()
        {
            string result = "";
            foreach (Oeuvre item in oeuvres)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }

        public bool ValidIDArtiste(string id)
        {
            foreach (Artiste item in artistes)
                if (item.Id == id)
                    return true;
            return false;
        }

        public bool ValidIDConservateur(string id)
        {
            foreach (Conservateur item in conservateurs)
                if (item.Id == id)
                    return true;
            return false;
        }

        public bool vendreOeuvre(string id, double prix)
        {
            foreach (Oeuvre item in oeuvres)
            {
                if (item.Id == id  && prix > item.Valeur && item.Etat == 'E' )
                {
                    item.Etat = 'V';
                    item.Prix = prix;
                    double comm = (prix - item.Valeur)*0.25;

                    foreach (Conservateur cons in conservateurs)
                    {
                        if (cons.Id == item.IdCons)
                        {
                            cons.Comm += comm;
                            return true;
                        }
                    }

                }
            }
            return false;
        }

    }
}
