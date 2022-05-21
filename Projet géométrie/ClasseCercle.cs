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
    class ClasseCercle : ClasseRond
    {
        private int Rayon;
        private int inutil1;
        private double inutil2;
        public Ellipse Dessin()
        {
            Ellipse myCercle = new Ellipse();
            myCercle.Fill = Brushes.Pink;
            myCercle.StrokeThickness = 2;
            myCercle.Stroke = Brushes.Black;
            myCercle.Width = Rayon * 20;
            myCercle.Height = Rayon * 20;

            return myCercle;
        }

        public new (int, int, double) Init()
        {
            inutil1 = inutil1 + 1;
            inutil2 = inutil2 + 1;
            Rayon = base.Init();
            Console.WriteLine(Rayon);
            return (Rayon, inutil1, inutil2);
        }

        public double Perimetre()
        {
            double peri = 2 * Math.PI * Rayon;
            return Math.Round(peri, 2);
        }

        public double Surface()
        {
            double surf = Math.PI * Math.Pow(Rayon, 2);
            return Math.Round(surf, 2);
        }
    }
}
