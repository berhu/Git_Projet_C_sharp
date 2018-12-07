using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExoPoint
{
    public class Point
    {
        private float x;
        private float y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public void Deplacer(float _movex, float _movey)
        {
            this.x += _movex;
            this.y += _movey;
        }
        public string Afficher()
        {
            return "Le point se situe à l'abscisse " + this.x + " et à l'ordonnée " + this.y + "";
        }
        public Point SymX()
        {
            Point symx = new Point { x = this.x, y = -this.y };
            return symx;
        }
        public Point SymY()
        {
            Point symy = new Point { x = -this.x, y = this.y };
            return symy;
        }
        public Point SymOr()
        {
            Point symor = new Point { x = -this.x, y = -this.y };
            return symor;
        }
        public void Permute()
        {
            float T;
            T = x;
            this.x = y;
            this.y = T;
        }


    }
}