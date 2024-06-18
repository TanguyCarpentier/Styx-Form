using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Timers.Timer;


namespace Styx_Biblio_Jeu
{
    public class Joueur : Entite
    {
        
        public bool estMort;
        public int Speed;
        public bool Dash1PickUp;
        public int DashSpeed;
        public bool Invincible;
        public bool ModeTueur;
        public int MultiplicateurScore;
        

        public Joueur(Point initialPosition, System.Drawing.Image texture, Size size) : base(initialPosition, texture, size)
        {
            posPixel = initialPosition;
            Speed = 2;
            estMort = false;
            Position = new Point (1,1);
            Size = size;
            Texture = texture;
            StartLaby = initialPosition;
            Dash1PickUp = false;
            DashSpeed = 4;
            Invincible = false;
            ModeTueur = false;
            MultiplicateurScore = 1;

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

        public void Dash(Plateau ptab)
        {
            if (!estMort && Dash1PickUp)
            {
                Dash1PickUp = false;
                int i = 0;

                Invincible = true;
                ModeTueur = true;

                while(i < DashSpeed)
                {
                    Move(ptab);
                }
                Invincible = false;
                ModeTueur = false;

            }
        }

        public async Task Bonus_Lyre()
        {
            if (!estMort)
            {
                Invincible = true;
                ModeTueur = true;

                await Task.Delay(10000); // Attendre 10 secondes

                Invincible = false;
                ModeTueur = false;
            }
        }
        public async Task Bonus_Exp()
        {
            if (!estMort)
            {
                MultiplicateurScore = 2;

                await Task.Delay(10000); // Attendre 10 secondes

                MultiplicateurScore = 1;
            }
        }


        public Point CollisionEntiteNM(Plateau Lab, Jeu jeu)
        {
            
            string parcour = Lab.AfficheCase(Position.X, Position.Y);

            switch (parcour)
            {
                case "fla":
                    Lab.tab[Position.Y, Position.X] = "esp";
                    jeu.score += 1*MultiplicateurScore;
                    Lab.compFlamme -= 1;
                    return (Position);

                case "dash":
                    Lab.tab[Position.Y, Position.X] = "esp";
                    jeu.score += 1*MultiplicateurScore;
                    Lab.compArtefact -= 1;
                    if (!Dash1PickUp)
                    {
                        Dash1PickUp = true;
                    }
                    return (Position);

                case "lyre":
                    Lab.tab[Position.Y, Position.X] = "esp";
                    jeu.score += 1*MultiplicateurScore;
                    Lab.compArtefact -= 1;
                    Bonus_Lyre();
                    return (Position);

                case "exp":
                    Lab.tab[Position.Y, Position.X] = "esp";
                    jeu.score += 1 * MultiplicateurScore;
                    Lab.compArtefact -= 1;
                    Bonus_Exp();
                    return(Position);

            }       
            
            return Position;
        }

    }
}
