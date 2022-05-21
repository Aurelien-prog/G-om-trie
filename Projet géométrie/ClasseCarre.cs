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
    class ClasseCarre : Classe4Angles
    {
        private int Côté;
        private int inutil1;
        private double inutil2;

        public Rectangle Dessin()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.Fill = Brushes.Blue;
            myRectangle.Width = Côté * 20;
            myRectangle.Height = Côté * 20;
            myRectangle.Stretch = Stretch.Fill;
            myRectangle.Stroke = Brushes.Black;
            myRectangle.StrokeThickness = 1;

            return myRectangle;
        }

        public new (int, int, double) Init()
        {
            inutil1 = inutil1 + 1;
            inutil2 = inutil2 + 1;
            Côté = base.Init();
            return (Côté, inutil1, inutil2);
        }

        public double Perimetre()
        {
            double peri = Côté * 4;
            return peri;
        }

        public double Surface()
        {
            double surface = Math.Pow(Côté, 2);
            return surface;
        }
    }
}
