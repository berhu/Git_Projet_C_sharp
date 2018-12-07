using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fractions
{
    public class Fraction
    {
        private int d;
        private int n;



        public int D
        {
            get
            {
                return d;
            }

        }

        public int N
        {
            get
            {
                return n;
            }

        }

        public Fraction()
        {
            int d = 0;
            int n = 0;
        }

        public Fraction(int _d, int _n)
        {
            int n = _n;
            int d = _d;
        }

    }
}