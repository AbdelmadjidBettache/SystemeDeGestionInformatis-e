﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Password;

            if (!String.IsNullOrEmpty(user)
               && !String.IsNullOrEmpty(pass))
            {
                if (user =="SGI" && pass =="admin")
                {
                    SGIArt fenetre = new SGIArt();
                    fenetre.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Les informations introduites ne sont pas valides!", "Identification", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                MessageBox.Show("Tous les champs sont requis!", "Identification", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
