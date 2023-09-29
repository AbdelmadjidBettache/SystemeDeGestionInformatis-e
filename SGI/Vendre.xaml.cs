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
    /// Logique d'interaction pour Vendre.xaml
    /// </summary>
    public partial class Vendre : Window
    {
        Gestion ges ;

        public Vendre(Gestion g)
        {
            InitializeComponent();
            ges = g;
        }

        private void btnVendre_Click(object sender, RoutedEventArgs e)
        {
            if (ges.vendreOeuvre(txtIDOV.Text, double.Parse(txtPrix.Text)))
            {
                MessageBox.Show("Vente réussie");
            } 
            else
                MessageBox.Show("Vente éronnée!");

        }
    }
}
