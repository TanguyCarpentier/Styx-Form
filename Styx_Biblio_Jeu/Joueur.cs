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
        public int Speed { get; set; }

        public Joueur(Point initialPosition, Image texture, Size size) :base (initialPosition, texture, size)
        {

            this.Speed = 1;
            Speed = 1;
            estMort = false;
            this.Position = initialPosition;
            this.Size = size;
            this.Texture = texture;

        }

        public void Move()
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
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Texture, new Rectangle(Position, Size));
        }
    }
}
