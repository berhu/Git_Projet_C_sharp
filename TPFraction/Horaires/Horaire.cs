using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horaires
{
    class Horaire
    {
        int heure;
        int minute;
        int seconde;

        public Horaire(int _heure, int _minute, int _seconde)
        {
            this.heure = _heure;
            this.minute = _minute;
            this.seconde = _seconde;
        }
        public Horaire()
        {
            this.heure = 0;
            this.minute = 0;
            this.seconde = 0;
        }
        private Horaire reduire()
        {
            return this;
        }
    }
}
