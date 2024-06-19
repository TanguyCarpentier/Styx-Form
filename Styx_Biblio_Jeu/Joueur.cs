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
using Microsoft.VisualBasic;


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
        public int vie;


        public Joueur(Point initialPosition, System.Drawing.Image texture, Size size) : base(initialPosition, texture, size)
        {
            posPixel = initialPosition;
            Speed = 2;
            estMort = false;
            Position = new Point(1, 1);
            Size = size;
            Texture = texture;
            StartLaby = initialPosition;
            Dash1PickUp = false;
            DashSpeed = 4;
            Invincible = false;
            ModeTueur = false;
            MultiplicateurScore = 1;
            vie = 2;

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

        public bool VerifMort()
        {
            if (vie < 1)
            {
                estMort = true;

            }
            else
            {
                estMort = false;
            }
            return estMort;
        }

        public async Task InterractionMob(Ennemie mob)
        {
            if (!estMort)
            {
                if (!Invincible || mob.estMort)
                {
                    vie -= 1;
                    VerifMort();
                    Invincible = true;

                    await Task.Delay(2000); // Attendre 10 secondes

                    Invincible = false;

                }
                else if (ModeTueur)
                {
                    mob.estMort = true;
                }
            }
        }

        public void Dash(Plateau ptab, Jeu partie)
        {
            if (!estMort && Dash1PickUp)
            {
                Dash1PickUp = false;
                int i = 0;

                Invincible = true;
                ModeTueur = true;

                while (i < DashSpeed)
                {
                    i++;
                    Move(ptab);
                    foreach (Ennemie mob in partie.EnnemieList)
                    {
                        if (!mob.estMort)
                        {
                            if (Position == mob.Position)
                            {
                                InterractionMob(mob);
                            }
                        }
                    }
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

        public async Task Bonus_Bou()
        {
            if (!estMort)
            {
                Invincible = true;

                await Task.Delay(10000); // Attendre 10 secondes

                Invincible = false;
            }
        }

        public async Task Bonus_Vitesse(Jeu partie)
        {
            if (!estMort)
            {
                partie.TickSpeed -= 200;

                await Task.Delay(10000);

                partie.TickSpeed += 200;
            }
        }

        public async Task Bonus_Flocon(Jeu partie)
        {
            if (!estMort)
            {
                partie.TickSpeed += 200;

                await Task.Delay(10000);

                partie.TickSpeed += 200;
            }
        }
        public void Bonus_Balance()
        {
            if (!estMort)
            {
                Random rand = new Random();

                int entre1Et2 = rand.Next(2);

                if (entre1Et2 == 0)
                {
                    vie += 1;
                }
                else
                {
                    vie -= 1;
                }
            }
            VerifMort();


        }


        public Point CollisionEntiteNM(Plateau Lab, Jeu jeu)
        {
            if (!estMort)
            {
                string parcour = Lab.AfficheCase(Position.X, Position.Y);

                switch (parcour)
                {
                    case "fla":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compFlamme -= 1;
                        return (Position);

                    case "dash":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        if (!Dash1PickUp)
                        {
                            Dash1PickUp = true;
                        }
                        return (Position);

                    case "lyre":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        Bonus_Lyre();
                        return (Position);

                    case "exp":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        Bonus_Exp();
                        return (Position);

                    case "bou":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        Bonus_Bou();
                        return (Position);

                    case "coe":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        vie += 1;
                        return (Position);

                    case "vit":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        Bonus_Vitesse(jeu);
                        return (Position);

                    case "bal":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        Bonus_Balance();
                        return (Position);

                    case "flo":
                        Lab.tab[Position.Y, Position.X] = "esp";
                        jeu.score += 1 * MultiplicateurScore;
                        Lab.compArtefact -= 1;
                        Bonus_Flocon(jeu);
                        return (Position);

                    default:
                        Point pointe = new Point(0, 0);
                        return (pointe);
                }
            }
            Point point = new Point(0, 0);
            return (point);
        }

    }
}
