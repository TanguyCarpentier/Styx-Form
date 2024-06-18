using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Windows.Forms.Timer;

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
        

        public Joueur(Point initialPosition, Image texture, Size size) : base(initialPosition, texture, size)
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

        public void Bonus_Lyre()
        {
            if (!estMort)
            {
                Timer gameTimer = new Timer();
                gameTimer.Interval = 300; // 300 ms

                int tempEcoule = 0;
                int tempArret = 10000; // 10 secondes

                gameTimer.Tick += (sender, e) =>
                {
                    if (tempEcoule >= tempArret)
                    {
                        // cas où le tempEcoule est supérieur ou égal à tempArret
                        gameTimer.Stop();
                        Invincible = false;
                        ModeTueur = false;
                    }
                    else
                    {
                        // cas où le timer n'est pas fini
                        Invincible = true;
                        ModeTueur = true;
                        tempEcoule += gameTimer.Interval;
                    }
                };

                gameTimer.Start();
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
                    Bonus_Lyre();
                    return(Position);
            }       
            
            return Position;
        }

    }
}
