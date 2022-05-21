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
    class ClasseEllipse : ClasseRond
    {
        private int Rayon1;
        private int Rayon2;
        private double inutil1;
        public Ellipse Dessin()
        {
            Ellipse myEllipse = new Ellipse();
            myEllipse.Fill = Brushes.Yellow;
            myEllipse.StrokeThickness = 2;
            myEllipse.Stroke = Brushes.Black;
            myEllipse.Width = Rayon2 * 10;
            myEllipse.Height = Rayon1 * 10;

            return myEllipse;
        }

        public new(int, int, double) Init()
        {
            inutil1 = inutil1 + 1;
            Rayon1 = base.Init();
            Rayon2 = Rayon1 * 2;
            Console.WriteLine(Rayon1 + " " + Rayon2);
            return (Rayon1, Rayon2, inutil1);
        }

        public double Perimetre()
        {
            double peri = Math.Round(2 * Math.PI * Math.Sqrt((Math.Pow(Rayon1, 2) + Math.Pow(Rayon2, 2)) / 2), 2);
            return peri;
        }

        public double Surface()
        {
            double surf = Rayon1 * Rayon2 * Math.PI;
            return Math.Round(surf, 2);
        }
    }    
}
