using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SGI
{
    /// <summary>
    /// Logique d'interaction pour SGIArt.xaml
    /// </summary>
    public partial class SGIArt : Window
    {
        Gestion gestion = new Gestion();

        public SGIArt()
        {
            InitializeComponent();
        }

        private void btnAddCons_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtNomC.Text;
            string prenom = txtPrenomC.Text;
            string id = txtIDC.Text;

            if (!String.IsNullOrEmpty(nom)
                && !String.IsNullOrEmpty(prenom)
                && !String.IsNullOrEmpty(id))
            {
                Conservateur c = new Conservateur(id, nom, prenom);
                gestion.AddConservateur(c);
                MessageBox.Show("Conservateur ajouté avec succes!!", "Ajout Conservateur", MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Tous les champs sont requis!", "Erreur");
            
        }

        private void btnListCons_Click(object sender, RoutedEventArgs e)
        {
            txtAffichage.Text = gestion.AfficherConservateus();
        }

        private void btnAddARt_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtNomA.Text;
            string prenom = txtPrenomA.Text;
            string id = txtIDA.Text;

            if (!String.IsNullOrEmpty(nom)
                && !String.IsNullOrEmpty(prenom)
                && !String.IsNullOrEmpty(id))
            {
                Artiste a = new Artiste(id, nom, prenom);
                gestion.AddArtiste(a);
                MessageBox.Show("Artiste ajouté avec succes!!", "Ajout Artiste", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Tous les champs sont requis!", "Erreur");
        }

        private void btnListArt_Click(object sender, RoutedEventArgs e)
        {
            txtAffichage.Text = gestion.AfficherArtistes();
        }

        private void btnAddO_Click(object sender, RoutedEventArgs e)
        {
            string id = txtIDO.Text;
            string titre = txtTitre.Text;
            string annee = txtAnnee.Text;
            double valeur = double.Parse(txtVal.Text);
            string idArt = txtIDAO.Text;
            string idCons = txtIDCO.Text;
            
            char etat = 'E';

            if (rbEntrepose.IsChecked == true)
                etat = 'I';

            if (!String.IsNullOrEmpty(id)
                && !String.IsNullOrEmpty(titre)
                && !String.IsNullOrEmpty(id)
                && !String.IsNullOrEmpty(annee)
                && !String.IsNullOrEmpty(valeur.ToString())
                && !String.IsNullOrEmpty(idArt)
                && !String.IsNullOrEmpty(idCons))

            {
                if (gestion.ValidIDArtiste(idArt) && gestion.ValidIDConservateur(idCons))
                {
                    Oeuvre oeuv = new Oeuvre(id, titre, annee, valeur, etat, idArt, idCons);
                    gestion.AddOeuvre(oeuv);
                    MessageBox.Show("Oeuvre ajoutée avec succes!!", "Ajout Oeuvre", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                    MessageBox.Show("L'artiste ou Le conservateur est inexistant!", "Erreur");


            }
            else
                MessageBox.Show("Tous les champs sont requis!", "Erreur");

        }

        private void btnListO_Click(object sender, RoutedEventArgs e)
        {
            txtAffichage.Text = gestion.AfficherOeuvres();
        }

        private void btnListAO_Click(object sender, RoutedEventArgs e)
        {
            txtAffichage.Text = gestion.AfficherArtistes();
        }

        private void btnlistCO_Click(object sender, RoutedEventArgs e)
        {
            txtAffichage.Text = gestion.AfficherConservateus();
        }

        private void btnSell_Click(object sender, RoutedEventArgs e)
        {
            Vendre vente = new Vendre(gestion);
            vente.ShowDialog();
        }
    }
}
