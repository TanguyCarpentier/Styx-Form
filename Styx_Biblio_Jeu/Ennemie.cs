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
        private Random random;
        public int Speed;

        public Ennemie(Point PosLaby,Point initialPosition, System.Drawing.Image texture, Size size) : base(initialPosition, texture, size)
        {

            posPixel = initialPosition;
            Speed = 2;
            estMort = false;
            Position = PosLaby;
            Size = size;
            Texture = texture;
            random = new Random();
            ConversionCoo();

        }

        public void Move(Plateau ptab, Joueur joueur)
        {
            if (CollisionMur(ptab))
            {
                Direction nextDirection = GetNextDirection();
                switch (nextDirection)
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
                        Position = new Point(Position.X + Speed);
                        break;
                }
                ConversionCoo();
            }
        }

        private Direction GetNextDirection()
        {

            Direction[] directions = [Direction.Up, Direction.Down, Direction.Left, Direction.Right];
            return directions[random.Next(directions.Length)];
        }

        public void Draw(Graphics g)
        {
            if (!estMort)
                g.DrawImage(Texture, new Rectangle(posPixel, Size));
        }

        public bool VerifMort()
        {
            return estMort;
        }
    }

}
