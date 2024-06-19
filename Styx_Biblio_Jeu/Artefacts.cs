using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styx_Biblio_Jeu
{
    public class Artefacts : Entite
    {
        public Artefacts(Point initialPosition, Image texture, Size size) : base(initialPosition, texture, size)
        {
            Position = initialPosition;

        }
    }
}
