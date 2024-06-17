using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Styx_Biblio_Jeu
{
    public class Joueur : Entite
    {
        
        public bool estMort;
        public int Speed;
        

        public Joueur(Point initialPosition, Image texture, Size size) : base(initialPosition, texture, size)
        {
            posPixel = initialPosition;
            Speed = 2;
            estMort = false;
            Position = new Point (1,1);
            Size = size;
            Texture = texture;
            StartLaby = initialPosition;
        }

        public void Move(Plateau ptab)
        {
            if (CollisionMur(ptab))
            {
                //CurrentDirection = direction;
                switch (CurrentDirection)
                {
                    case Direction.Up:
                        Position = new Point(Position.X, Position.Y - Speed);
                        break;
                    case Direction.Down:
                        Position = new Point(Position.X, Position.Y + Speed);
                        break;
                    case Direction.Left:
                        Position = new Point(Position.X - Speed, Position.Y);
                        break;
                    case Direction.Right:
                        Position = new Point(Position.X + Speed, Position.Y);
                        break;
                }
                ConversionCoo();
            }
        }

        public void Draw(Graphics g)
        {
            if (!estMort)
                g.DrawImage(Texture, new Rectangle(posPixel, Size));
        }

     
    }
}
