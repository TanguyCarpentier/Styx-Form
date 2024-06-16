using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Styx_Biblio_Jeu
{
    public class Joueur
    {
        public Point Position { get; set; }
        public Image Texture { get; set; }
        public Direction CurrentDirection { get; set; }
        public Size Size { get; set; }
        public int Speed { get; set; }

        public Joueur(Point initialPosition, Image texture, Size size)
        {
            Position = initialPosition;
            Texture = texture;
            CurrentDirection = Direction.Right;
            Size = size;
            Speed = 5;
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
