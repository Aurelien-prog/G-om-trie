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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_géométrie
{
    /// <summary>
    /// Logique d'interaction pour PageExercice.xaml
    /// </summary>
    
    public partial class PageExercice : Page
    {
        public PageExercice(int id, (int, int, double) choix)
        {
            InitializeComponent();
            var truc = choix;
            switch (id)
            {
                case 0:
                    GenerCarre(truc);
                    break;
                case 1:
                    GenerRectangle(truc);
                    break;
                case 2:
                    GenerRond(truc);
                    break;
                case 3:
                    GenerEllipse(truc);
                    break;
                case 4:
                    GenerTriangle(truc);
                    break;
                default:
                    break;
            }
        }

        //FONCTION AFFICHAGE DES VALEURS POUR CHAQUES FORMES
        public void GenerCarre((int, int, double) choix)
        {
             var cotes = choix;
             AffichageValeur(cotes.Item1, "Côté =", -1, "", -1, "");
             
        }

        public void GenerRectangle((int, int, double) choix)
        {
            var cotes = choix;
            AffichageValeur(cotes.Item1, "Hauteur =", cotes.Item2, "Largeur =", -1, "");
            
        }        

        public void GenerRond((int, int, double) choix)
        {
            var cotes = choix;
            AffichageValeur(cotes.Item1, "Rayon =", -1, "", -1, "");
            
        }

        public void GenerEllipse((int, int, double) choix)
        {
            var cotes = choix;
            AffichageValeur(cotes.Item1, "Petit rayon =", cotes.Item2, "Grand rayon =", -1, "");
            
        }

        public void GenerTriangle((int, int, double) choix)
        {
            var cotes = choix;
            AffichageValeur(cotes.Item1, "Côté 1 =", cotes.Item2, "Côté 2 =", Convert.ToInt32(cotes.Item3), "Hypothénuse =");
            
        }

        //AFFICHAGE DES VALEURS
        public void AffichageValeur(int Valeur1, string strValeur1, int Valeur2, string strValeur2, int Valeur3, string strValeur3)
        {
            if (Valeur1 != -1)
            {
                txtValeur1.Text = Convert.ToString(Valeur1);
                lblValeur1.Content = strValeur1;
            }
            else
            {
                txtValeur1.Visibility = Visibility.Hidden;
                lblValeur1.Visibility = Visibility.Hidden;
            }

            if (Valeur2 != -1)
            {
                txtValeur2.Text = Convert.ToString(Valeur2);
                lblValeur2.Content = strValeur2;
            }
            else
            {
                txtValeur2.Visibility = Visibility.Hidden;
                lblValeur2.Visibility = Visibility.Hidden;
            }

            if (Valeur3 != -1)
            {
                txtValeur3.Text = Convert.ToString(Valeur3);
                lblValeur3.Content = strValeur3;
            }
            else
            {
                txtValeur3.Visibility = Visibility.Hidden;
                lblValeur3.Visibility = Visibility.Hidden;
            }

        }

    }
}
