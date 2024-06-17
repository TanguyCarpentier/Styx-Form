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

            this.WindowState = FormWindowState.Maximized;
            CenterPanel(pnlLaby);


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

            pnlLaby.AutoSize = true;
            pnlLaby.BorderStyle = BorderStyle.FixedSingle;
            pnlLaby.BackColor = Color.Yellow;

            // Création du quadrillage de PictureBox
            CreateGrid();

            /*joueurPictureBox = new PictureBox
            {
                Size = joueur.Size,
                Location = joueur.Position,
                Image = joueur.Texture,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pnlLaby.Controls.Add(joueurPictureBox);
            joueurPictureBox.BringToFront();
            */

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
        private void CenterPanel(Panel panel)
        {
            // Calculer les nouvelles positions pour centrer le panel
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;

            // Définir la position du panel
            panel.Location = new Point(x, y);
        }

        private void CreateGrid()
        {
            pnlLaby.SuspendLayout();
            Plateau Laby = new Plateau(40, 40);


            Laby.Generatelaby();
            int Y1 = 0;
            for (int j = 0; j < 41; j++)
            {
                int comp = 0;
                int l = 0;
                for (int i = 0; i < 41; i++)
                {
                    int x = 0, y = 0;
                    if (j % 2 == 0)
                    {
                        PictureBox maNouvellePictureBox;
                        int nbPicDansPanel = pnlLaby.Controls.Count;
                        switch (Laby.tab[j, i])
                        {
                            case "+":
                                maNouvellePictureBox = new PictureBox();

                                maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(10, 10); //définition de la taille                                           
                                maNouvellePictureBox.Image = Properties.Resources.mur;
                                if (l == 0 && j == 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, 0);
                                    l++;
                                }
                                else if (l == 0 && j != 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, Y1 += 25);
                                    l++;
                                }

                                else
                                {


                                    x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 30;
                                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;

                                    maNouvellePictureBox.Location = new Point(x, y);
                                }


                                // ajout de la picturebox créée à la collection des contrôles du panel pour qu'elle apparaisse dans le formulaire
                                pnlLaby.Controls.Add(maNouvellePictureBox);

                                pnlLaby.ResumeLayout();
                                break;
                            case "---":
                                maNouvellePictureBox = new PictureBox();

                                maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(30, 10); //définition de la taille                                           
                                maNouvellePictureBox.Image = Properties.Resources.mur;
                                if (l == 0 && j == 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, 0);
                                    l++;
                                }
                                else if (l == 0 && j != 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, Y1 += 25);
                                    l++;
                                }
                                else
                                {
                                    x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;

                                    maNouvellePictureBox.Location = new Point(x, y);
                                }


                                // ajout de la picturebox créée à la collection des contrôles du panel pour qu'elle apparaisse dans le formulaire
                                pnlLaby.Controls.Add(maNouvellePictureBox);

                                pnlLaby.ResumeLayout();
                                break;
                            case "   ":
                                maNouvellePictureBox = new PictureBox();

                                maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(30, 10);
                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                break;
                        }




                    }
                    else
                    {

                        PictureBox maNouvellePictureBox; //déclaration d'un nouvel objet picturebox
                        int nbPicDansPanel = pnlLaby.Controls.Count; // nombre de picturebox actuel dans le panel
                        if (i % 2 == 0)
                        {
                            switch (Laby.tab[j, i])
                            {
                                case "|":
                                    maNouvellePictureBox = new PictureBox();

                                    maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                    maNouvellePictureBox.Size = new Size(10, 25); //définition de la taille 
                                                                                  //maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D; // définition du type de bordure
                                    maNouvellePictureBox.Image = Properties.Resources.mur;
                                    if (l == 0)
                                    {
                                        // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                        maNouvellePictureBox.Location = new Point(0, Y1 += 10);
                                        l++;
                                    }
                                    else
                                    {

                                        if (i % 2 == 0)
                                        {

                                            x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 40;
                                            y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;

                                        }
                                        // sinon, on prend récupère la localisation X de la dernière créée et on ajoute 50 (hauteur d'1 picturebox + 10 à sa localisation Y 


                                        maNouvellePictureBox.Location = new Point(x, y);

                                    }

                                    pnlLaby.Controls.Add(maNouvellePictureBox);
                                    pnlLaby.ResumeLayout();
                                    break;
                                case " ":
                                    maNouvellePictureBox = new PictureBox();

                                    maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                    maNouvellePictureBox.Size = new Size(10, 25);

                                    x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 40;
                                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                    maNouvellePictureBox.Location = new Point(x, y);
                                    pnlLaby.Controls.Add(maNouvellePictureBox);
                                    pnlLaby.ResumeLayout();
                                    break;
                                case "esp":
                                    maNouvellePictureBox = new PictureBox();

                                    maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                    maNouvellePictureBox.Size = new Size(40, 25);
                                    x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                    maNouvellePictureBox.Location = new Point(x, y);
                                    pnlLaby.Controls.Add(maNouvellePictureBox);
                                    pnlLaby.ResumeLayout();
                                    break;
                            }
                        }

                    }
                }
            }
        }
    }
}