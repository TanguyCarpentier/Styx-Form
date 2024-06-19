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

        public void Move(Plateau ptab, Joueur joueur, Jeu partie)
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

                    Point[] tabPos = new Point[5];

                    tabPos[0] = Position;
                    CurrentDirection=Direction.Right;
                    if (CollisionMur(ptab))
                        tabPos[1] = new Point(Position.X + 2, Position.Y);
                    CurrentDirection = Direction.Down;
                    if (CollisionMur(ptab))
                        tabPos[2] = new Point(Position.X, Position.Y + 2);
                    CurrentDirection = Direction.Up;
                    if (CollisionMur(ptab))
                        tabPos[3] = new Point(Position.X, Position.Y - 2);
                    CurrentDirection = Direction.Left;
                    if (CollisionMur(ptab))
                        tabPos[4] = new Point(Position.X - 2, Position.Y);

                    foreach (Point p in tabPos)
                    {
                        if (p == joueur.Position)
                        {
                            joueur.InterractionMob(this, partie);
                        }
                    }
                    
                }
            }
        }

        private Direction GetNextDirection(Plateau ptab)
        {

            Direction[] directions = [Direction.Up, Direction.Down, Direction.Left, Direction.Right];
            List<Direction> directionList = new List<Direction>(directions);

            CurrentDirection = Direction.Right;
            if (!CollisionMur(ptab))
                directionList.Remove(Direction.Right);
            CurrentDirection = Direction.Down;
            if (!CollisionMur(ptab))
                directionList.Remove(Direction.Down);
            CurrentDirection = Direction.Up;
            if (!CollisionMur(ptab) )
                directionList.Remove(Direction.Up);
            CurrentDirection = Direction.Left;
            if (!CollisionMur(ptab))
                directionList.Remove(Direction.Left);


            return directionList[random.Next(directionList.Count)];
        }

        public Direction GetOppositeDirection(Direction dir)
        {
            if (dir==Direction.Left) return Direction.Right;
            if (dir==Direction.Right) return Direction.Left;
            if (dir==Direction.Up) return Direction.Down;
            if (dir==Direction.Down) return Direction.Up;
            return Direction.Right;
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
