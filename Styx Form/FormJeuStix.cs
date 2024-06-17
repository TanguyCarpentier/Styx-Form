using Styx_Biblio_Jeu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Styx_Form
{
    public partial class FormJeuStyx : Form
    {
        private Joueur joueur;
        private Timer gameTimer;
        private PictureBox joueurPictureBox;

        public FormJeuStyx(string Pseudo)
        {
            InitializeComponent();

            // Initialisation de Joueur
            joueur = new Joueur(new Point(50, 50), Styx_Form.Properties.Resources.TestPlay, new Size(25, 25));

            

            // Initialisation du Timer
            gameTimer = new Timer();
            gameTimer.Interval = 50; // 100 ms = 0.1 seconde
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            // Ajout du gestionnaire d'événements pour les touches
            this.KeyDown += FormJeuStyx_KeyDown;
            // Ajout du gestionnaire d'événements pour le dessin du panel
            this.pnlLaby.Paint += new PaintEventHandler(pnlLaby_Paint);

            // Configuration du panel
            pnlLaby.Size = new Size(600, 600);
            pnlLaby.BorderStyle = BorderStyle.FixedSingle;

            // Création du quadrillage de PictureBox
            CreateGrid();

            joueurPictureBox = new PictureBox
            {
                Size = joueur.Size,
                Location = joueur.Position,
                Image = joueur.Texture,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pnlLaby.Controls.Add(joueurPictureBox);
            joueurPictureBox.BringToFront();

            Plateau Laby = new Plateau(400, 400);

            Laby.Generatelaby();

            string test = Laby.tab[1, 1];

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Déplacement du Joueur
            joueur.Move();

            // Redessiner le panel
            pnlLaby.Invalidate();
        }

        private void FormJeuStyx_KeyDown(object sender, KeyEventArgs e)
        {
            // Gestion des touches de direction
            switch (e.KeyCode)
            {
                case Keys.Up:
                    joueur.CurrentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    joueur.CurrentDirection = Direction.Down;
                    break;
                case Keys.Left:
                    joueur.CurrentDirection = Direction.Left;
                    break;
                case Keys.Right:
                    joueur.CurrentDirection = Direction.Right;
                    break;
            }
        }

        private void pnlLaby_Paint(object sender, PaintEventArgs e)
        {
            // Dessiner le Joueur
            //joueur.Draw(e.Graphics);
        }

        private void CreateGrid()
        {
            int n = 0;
            for (int i = 0; i < 3600; i++)
            {
                PictureBox maNouvellePictureBox = new PictureBox();
                int nbPicDansPanel = pnlLaby.Controls.Count;

                // Suspension de la logique d'affichage du panel
                pnlLaby.SuspendLayout();

                // Configuration de la nouvelle PictureBox
                maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}";
                maNouvellePictureBox.Size = new Size(10, 10);
                maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D;

                // Positionnement de la PictureBox
                int x = 0, y = 0;
                if (n == 60)
                {
                    x = 0;
                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y + 10;
                    n = 0;
                }
                else
                {
                    if (nbPicDansPanel > 0)
                    {
                        x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                        y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                    }
                    n++;
                }

                maNouvellePictureBox.Location = new Point(x, y);

                // Ajout de la PictureBox au panel
                pnlLaby.Controls.Add(maNouvellePictureBox);

                // Reprise de la logique d'affichage du panel
                pnlLaby.ResumeLayout();
            }
        }
    }
}