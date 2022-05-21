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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nul1;
        double nul;
        int question = 0;
        int juste = 0;
        int fausse = 0;
        int pourcentage;
        double perimetre;
        double surface;
        int idPage;
        public MainWindow()
        {
            InitializeComponent();
        }

        //APPUIE SUR LES BOUTONS DE CHOIX DES FORMES
        private void btnCarre_Click(object sender, RoutedEventArgs e)
        {
            
            ClasseCarre carre = new ClasseCarre();
            var cotes = carre.Init();
            nul1 = cotes.Item2;
            nul = cotes.Item3;
            perimetre = carre.Perimetre();
            surface = carre.Surface();
            Rectangle carreCanvas = carre.Dessin();
            CanvasForme.Children.Clear();
            CanvasForme.Children.Add(carreCanvas);
            ChangerPage(0, cotes, perimetre, surface);
        }

        private void btnRectangle_Click(object sender, RoutedEventArgs e)
        {
            
            ClasseRectangle rectangle = new ClasseRectangle();
            var cotes = rectangle.Init();
            nul = cotes.Item3;
            perimetre = rectangle.Perimetre();
            surface = rectangle.Surface();
            Rectangle rectangleCanvas = rectangle.Dessin();
            CanvasForme.Children.Clear();
            CanvasForme.Children.Add(rectangleCanvas);
            ChangerPage(1, cotes, perimetre, surface);
        }

        private void btnRond_Click(object sender, RoutedEventArgs e)
        {
            
            ClasseCercle cercle = new ClasseCercle();
            var rayon = cercle.Init();
            nul1 = rayon.Item2;
            nul = rayon.Item3;
            perimetre = cercle.Perimetre();
            surface = cercle.Surface();
            Ellipse cercleCanvas = cercle.Dessin();
            CanvasForme.Children.Clear();
            CanvasForme.Children.Add(cercleCanvas);
            ChangerPage(2, rayon, perimetre, surface);
        }

        private void btnEllipse_Click(object sender, RoutedEventArgs e)
        {
            
            ClasseEllipse ellipse = new ClasseEllipse();
            var cotes = ellipse.Init();
            nul = cotes.Item3;
            surface = ellipse.Surface();
            perimetre = ellipse.Perimetre();
            Ellipse ellipseCanvas = ellipse.Dessin();
            CanvasForme.Children.Clear();
            CanvasForme.Children.Add(ellipseCanvas);
            ChangerPage(3, cotes, perimetre, surface);
        }

        private void btnTriangle_Click(object sender, RoutedEventArgs e)
        {
            ClasseTriangle triangle = new ClasseTriangle();
            var cotes = triangle.Init();
            perimetre = triangle.Perimetre();
            surface = triangle.Surface();
            Polygon triangleCanvas = triangle.Dessin();
            CanvasForme.Children.Clear();
            CanvasForme.Children.Add(triangleCanvas);
            ChangerPage(4, cotes, perimetre, surface);

        }

        //RENDRE VISIBLE OU INVISIBLE LES OBJETS SELON LES PAGES
        public void ChangerPage(int id, (int, int, double) coter, double peri, double surf)
        {
            idPage = id;
            var essai = coter;
            Menu.Visibility = Visibility.Visible;
            btnRetour.Visibility = Visibility.Visible;
            btnRecommencer.Visibility = Visibility.Visible;
            btnCarre.Visibility = Visibility.Hidden;
            btnRectangle.Visibility = Visibility.Hidden;
            btnRond.Visibility = Visibility.Hidden;
            btnEllipse.Visibility = Visibility.Hidden;
            btnTriangle.Visibility = Visibility.Hidden;
            frmCarre.Visibility = Visibility.Hidden;
            frmRectangle.Visibility = Visibility.Hidden;
            frmRond.Visibility = Visibility.Hidden;
            frmEllipse.Visibility = Visibility.Hidden;
            frmTriangle.Visibility = Visibility.Hidden;
            txtChoix.Visibility = Visibility.Hidden;
            btnQuitter.Visibility = Visibility.Hidden;
            frmRect.Visibility = Visibility.Hidden;
            Rnbrquest.Visibility = Visibility.Hidden;
            Rrepjust.Visibility = Visibility.Hidden;
            Rrepfauss.Visibility = Visibility.Hidden;
            Rpourcen.Visibility = Visibility.Hidden;
            txtnbrquest.Visibility = Visibility.Hidden;
            txtrepjust.Visibility = Visibility.Hidden;
            txtrepfauss.Visibility = Visibility.Hidden;
            txtpourcen.Visibility = Visibility.Hidden;
            txtTitre.Visibility = Visibility.Hidden;
            btnValider.Visibility = Visibility.Visible;
            txtRepPeri.Visibility = Visibility.Visible;
            txtRepSurf.Visibility = Visibility.Visible;
            txtQuestionPeri.Visibility = Visibility.Visible;
            txtQuestionSurf.Visibility = Visibility.Visible;
            CanvasForme.Visibility = Visibility.Visible;
            txtScore.Visibility = Visibility.Hidden;
            Menu.Content = new PageExercice(id, essai);
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Hidden;
            btnCarre.Visibility = Visibility.Visible;
            btnRectangle.Visibility = Visibility.Visible;
            btnRond.Visibility = Visibility.Visible;
            btnEllipse.Visibility = Visibility.Visible;
            btnTriangle.Visibility = Visibility.Visible;
            btnRetour.Visibility = Visibility.Hidden;
            btnRecommencer.Visibility = Visibility.Hidden;
            frmCarre.Visibility = Visibility.Visible;
            frmRectangle.Visibility = Visibility.Visible;
            frmRond.Visibility = Visibility.Visible;
            frmEllipse.Visibility = Visibility.Visible;
            frmTriangle.Visibility = Visibility.Visible;
            txtChoix.Visibility = Visibility.Visible;
            btnQuitter.Visibility = Visibility.Visible;
            frmRect.Visibility = Visibility.Visible;
            Rnbrquest.Visibility = Visibility.Visible;
            Rrepjust.Visibility = Visibility.Visible;
            Rrepfauss.Visibility = Visibility.Visible;
            Rpourcen.Visibility = Visibility.Visible;
            txtnbrquest.Visibility = Visibility.Visible;
            txtrepjust.Visibility = Visibility.Visible;
            txtrepfauss.Visibility = Visibility.Visible;
            txtpourcen.Visibility = Visibility.Visible;
            txtTitre.Visibility = Visibility.Hidden;
            btnValider.Visibility = Visibility.Hidden;
            txtRepPeri.Visibility = Visibility.Hidden;
            txtRepSurf.Visibility = Visibility.Hidden;
            txtQuestionPeri.Visibility = Visibility.Hidden;
            txtQuestionSurf.Visibility = Visibility.Hidden;
            txtScore.Visibility = Visibility.Visible;
            txtRepSurf.Text = "Surface";
            txtRepPeri.Text = "Périmètre";
            txtRepPeri.Background = Brushes.White;
            txtRepSurf.Background = Brushes.White;
        }

        //FONCTION BOUTON DE REINITIALISATION
        private void btnRecommencer_Click(object sender, RoutedEventArgs e)
        {
            txtRepSurf.Text = "Surface";
            txtRepPeri.Text = "Périmètre";
            txtRepPeri.Background = Brushes.White;
            txtRepSurf.Background = Brushes.White;

            switch (idPage)
            {
                case 0:
                    ClasseCarre carre = new ClasseCarre();
                    var cotes = carre.Init();
                    perimetre = carre.Perimetre();
                    surface = carre.Surface();
                    Rectangle carreCanvas = carre.Dessin();
                    CanvasForme.Children.Clear();
                    CanvasForme.Children.Add(carreCanvas);
                    ChangerPage(0, cotes, perimetre, surface);
                    break;
                case 1:
                    ClasseRectangle rectangle = new ClasseRectangle();
                    var rec = rectangle.Init();
                    perimetre = rectangle.Perimetre();
                    surface = rectangle.Surface();
                    Rectangle rectangleCanvas = rectangle.Dessin();
                    CanvasForme.Children.Clear();
                    CanvasForme.Children.Add(rectangleCanvas);
                    ChangerPage(1, rec, perimetre, surface);
                    break;
                case 2:
                    ClasseCercle cercle = new ClasseCercle();
                    var rayon = cercle.Init();
                    perimetre = cercle.Perimetre();
                    surface = cercle.Surface();
                    Ellipse cercleCanvas = cercle.Dessin();
                    CanvasForme.Children.Clear();
                    CanvasForme.Children.Add(cercleCanvas);
                    ChangerPage(2, rayon, perimetre, surface);
                    break;
                case 3:
                    ClasseEllipse ellipse = new ClasseEllipse();
                    var elli = ellipse.Init();
                    surface = ellipse.Surface();
                    perimetre = ellipse.Perimetre();
                    Ellipse ellipseCanvas = ellipse.Dessin();
                    CanvasForme.Children.Clear();
                    CanvasForme.Children.Add(ellipseCanvas);
                    ChangerPage(3, elli, perimetre, surface);
                    break;
                case 4:
                    ClasseTriangle triangle = new ClasseTriangle();
                    var tri = triangle.Init();
                    perimetre = triangle.Perimetre();
                    surface = triangle.Surface();
                    Polygon triangleCanvas = triangle.Dessin();
                    CanvasForme.Children.Clear();
                    CanvasForme.Children.Add(triangleCanvas);
                    ChangerPage(4, tri, perimetre, surface);
                    break;
                default:
                    break;
            }
        }

        //FONCTION BOUTON POUR QUITTER L'APPLICATION
        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //FONCTION STATISTIQUES APRES VALIDATION DES REPONSES
        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            
            if(txtRepSurf.Text == Convert.ToString(surface))
            {
                juste = juste + 1;
                question = question + 1;
                txtRepSurf.Background = Brushes.Green;
            }
            else
            {
                fausse = fausse + 1;
                question = question + 1;
                txtRepSurf.Background = Brushes.Red;
            }

            if (txtRepPeri.Text == Convert.ToString(perimetre))
            {
                juste = juste + 1;
                question = question + 1;
                txtRepPeri.Background = Brushes.Green;
            }
            else
            {
                fausse = fausse + 1;
                question = question + 1;
                txtRepPeri.Background = Brushes.Red;
            }

            Rnbrquest.Text = Convert.ToString(question);
            Rrepjust.Text = Convert.ToString(juste);
            Rrepfauss.Text = Convert.ToString(fausse);
            pourcentage = (100 / question) * juste;
            Rpourcen.Text = Convert.ToString(pourcentage);
        }

        private void txtRepSurf_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtRepPeri.Text == "Périmètre" || txtRepSurf.Text == "Surface")
            {
                btnValider.IsEnabled = false;
            }
            else
            {
                btnValider.IsEnabled = true;
            }
        }

        private void txtRepPeri_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtRepPeri.Text == "Périmètre" || txtRepSurf.Text == "Surface")
            {
                btnValider.IsEnabled = false;
            }
            else
            {
                btnValider.IsEnabled = true;
            }
        }
    }
}
