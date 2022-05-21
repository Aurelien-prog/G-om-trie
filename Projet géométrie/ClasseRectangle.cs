using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Projet_géométrie
{
    class ClasseRectangle : Classe4Angles
    {
        private int Largeur;
        private int Hauteur;
        private double inutil;

        public Rectangle Dessin()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.Fill = Brushes.Brown;
            myRectangle.Width = Largeur * 10;
            myRectangle.Height = Hauteur * 10;
            myRectangle.HorizontalAlignment = HorizontalAlignment.Center;
            myRectangle.VerticalAlignment = VerticalAlignment.Center;

            return myRectangle;
        }

        public new(int, int, double) Init()
        {
            inutil = inutil + 1;
            Hauteur = base.Init();
            Largeur = Hauteur * 2;
            return (Hauteur, Largeur, inutil);
        }

        public double Perimetre()
        {
            double peri = 2 * Hauteur + 2 * Largeur;
            return peri;
        }

        public double Surface()
        {
            double surf = Largeur * Hauteur;
            return surf;
        }

        //public void InitLongueur() { UneValeur = Init(); }

        public double Perimetre(int Largeur) { return (UneValeur + Largeur) * 2; }
        public double Surface(int Largeur) { return UneValeur * Largeur; }
    }    
}
