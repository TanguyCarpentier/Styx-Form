using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styx_Biblio_Jeu
{
    public abstract class Entite
    {
        public Point Position { get; set; }
        public Direction CurrentDirection { get; set; }
        public Image Texture { get; set; }
        public Size Size { get; set; }

        public Entite(Point initialPosition, Image texture, Size size)
        {
            Position = initialPosition;
            Texture = texture;
            CurrentDirection = Direction.Right;
            Size = size;
        }

        public bool CollisionMur(Plateau Lab)
        {
            
            Point calculPos = Position;
            switch (CurrentDirection)
            {
                case Direction.Right:
                    calculPos.X += 1;
                    break;
                case Direction.Left:
                    calculPos.X -= 1;
                    break;
                case Direction.Up: 
                    calculPos.Y -= 1;
                    break;
                case Direction.Down:
                    calculPos.Y += 1;
                    break;
                default :
                    throw new Exception("La direction est introuvable");
            }

            if (calculPos.X < 0 || calculPos.X >= Lab.Largeur || calculPos.Y < 0 || calculPos.Y >= Lab.Hauteur)
            {
                return false; // Considérer comme une collision si hors limites
            }

            string parcour = Lab.AfficheCase(calculPos.X, calculPos.Y);

            if (parcour!="|" && parcour!= "---")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Size RecupSize()
        {
            return Size;
        }
        public Point RecupPosition()
        {
            return Position;
        }
        public Image RecupTexture()
        {
            return Texture;
        }
        public Direction RecupDirection()
        {
            return CurrentDirection;
        }
    }
    
}