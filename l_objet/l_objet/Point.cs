using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_objet
{

    public class Point
    {
        public double X;
        public double Y;

        //public Point Dot(ref int X, ref int Y)
        //{
        //    Point dot = new Point();
        //}

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public void Deplacer(double _moveX, double _moveY)
        {
            this.X = _moveX;
            this.Y = _moveY;
        }
        public string Affichage()
        {
            return "Le point se situe à l'abscisse "+this.X+" et à l'ordonnée "+this.Y+"";
        }
        //public string Affichage2()
        //{
        //    return "Le point se situe à l'abscisse" + X + " et à l'ordonnée " + Y + "";
        //}
        public Point SymY()
        {
            Point dotInvord = new Point { X = X, Y = -Y };
            return dotInvord;
        }
        public Point SymX()
        {
            Point dotInvAbsc = new Point { X = -X, Y = Y };
            return dotInvAbsc;
        }
        public Point SymOrigine()
        {
            Point dotInvOrig = new Point { X = 0 - X, Y = 0 - Y };
            return dotInvOrig;
        }
        public void Permute()
        {
            double T;
            T = X;
            this.X = Y;
            this.Y = T;

        }
    }
}
