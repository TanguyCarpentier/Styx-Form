using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styx_Biblio_Jeu
{
    public class Ennemie : Entite
    {
        public bool estMort;

        public Ennemie(Point initialPosition, Image texture, Size size) : base(initialPosition, texture, size)
        {
            estMort = false;
        }
    }

}
