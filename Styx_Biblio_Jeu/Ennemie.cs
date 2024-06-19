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
        public string Name;
        public bool estMort;
        private Random random;
        public int Speed;

        public Ennemie(string name, Point PosLaby, Point initialPosition, System.Drawing.Image texture, Size size) : base(PosLaby, texture, size)
        {

            Name = name;
            posPixel = initialPosition;
            Speed = 2;
            estMort = false;
            Position = initialPosition;
            Size = size;
            Texture = texture;
            random = new Random();
            ConversionCoo();

        }

        public void Move(Plateau ptab, Joueur joueur)
        {
            if (!estMort)
            {
                CurrentDirection = GetNextDirection(ptab);
                if (CollisionMur(ptab))
                {

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
                    if (Position == joueur.Position)
                    {
                        joueur.InterractionMob(this);
                    }
                }
            }
        }

        private Direction GetNextDirection(Plateau ptab)
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
