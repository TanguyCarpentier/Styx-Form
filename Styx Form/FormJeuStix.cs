using Styx_Biblio_Jeu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Timer = System.Windows.Forms.Timer;

namespace Styx_Form
{
    public partial class FormJeuStyx : Form
    {
        private Joueur joueur;
        private Timer gameTimer;
        //private PictureBox joueurPictureBox;
        private Plateau Laby;
        private Point Spawn;
        private int compt1=0;
        private int compt2 = 0;

        public FormJeuStyx(string Pseudo)
        {
            InitializeComponent();

            Laby = new Plateau(40, 40);


            this.WindowState = FormWindowState.Maximized;

            Spawn = pnlLaby.Location;
            Spawn.X += -280;
            Spawn.Y += 10;

            // Initialisation de Joueur
            joueur = new Joueur(Spawn, Styx_Form.Properties.Resources.over, new Size(30, 28));



            // Initialisation du Timer
            gameTimer = new Timer();
            gameTimer.Interval = 100; // 100 ms = 0.1 seconde
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            // Ajout du gestionnaire d'événements pour les touches
            this.KeyDown += FormJeuStyx_KeyDown;
            // Ajout du gestionnaire d'événements pour le dessin du panel
            this.pnlLaby.Paint += new PaintEventHandler(pnlLaby_Paint);

            // Configuration du panel

            pnlLaby.AutoSize = true;
            pnlLaby.BorderStyle = BorderStyle.FixedSingle;
            pnlLaby.BackColor = ColorTranslator.FromHtml("#0c1015");


            // Création du quadrillage de PictureBox
            CreateGrid(Laby);
            CenterPanel(pnlLaby);

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Déplacement du Joueur

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
                    joueur.Move(Laby);
                    break;
                case Keys.Down:
                    joueur.CurrentDirection = Direction.Down;
                    joueur.Move(Laby);
                    break;
                case Keys.Left:
                    joueur.CurrentDirection = Direction.Left;
                    joueur.Move(Laby);
                    break;
                case Keys.Right:
                    joueur.CurrentDirection = Direction.Right;
                    joueur.Move(Laby);
                    break;
            }
        }

        private void pnlLaby_Paint(object sender, PaintEventArgs e)
        {
            // Dessiner le Joueur
            joueur.Draw(e.Graphics);
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

        private void CreateGrid(Plateau Laby)
        {
            pnlLaby.SuspendLayout();


            
            Laby.Generatelaby();// appel tab
            int Y1 = 0;
            for (int j = 0; j < 41; j++)
            {
                
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

                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(10, 10); //définition de la taille                                           
                                maNouvellePictureBox.Image = Properties.Resources.mur3;
                                if (l == 0 && j == 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, 0);
                                    l++;
                                }
                                else if (l == 0 && j != 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, Y1 += 30);
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

                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(30, 10); //définition de la taille                                           
                                maNouvellePictureBox.Image = Properties.Resources.mur3;
                                if (l == 0 && j == 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, 0);
                                    l++;
                                }
                                else if (l == 0 && j != 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, Y1 += 30);
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

                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
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


                        string cellValue = Laby.tab[j, i];
                        switch (Laby.tab[j, i])
                        {

                            case "fla":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.flamme;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "flo":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.flocon;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "bal":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.balance;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "vit":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.chaussure;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "coe":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.coeur;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "bou":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.bouclier;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "exp":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.multiplicateur_exp;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "lyre":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.lyre2;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "dash":
                                maNouvellePictureBox = new PictureBox();
                                maNouvellePictureBox.Image = Properties.Resources.plume;
                                maNouvellePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                maNouvellePictureBox.Height = 30;
                                maNouvellePictureBox.Width = 30;
                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel

                                x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                compt1++;
                                break;
                            case "|":
                                maNouvellePictureBox = new PictureBox();

                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(10, 30); //définition de la taille 
                                                                              //maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D; // définition du type de bordure
                                maNouvellePictureBox.Image = Properties.Resources.mur3;
                                if (l == 0)
                                {
                                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                    maNouvellePictureBox.Location = new Point(0, Y1 += 10);
                                    l++;
                                }

                                else
                                {

                                    if (compt1==0)
                                    {

                                        x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 40;
                                        y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                        compt1 = 0;

                                    }
                                    else {
                                        x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 30;
                                        y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                        compt1 = 0;
                                    }
                                    


                                    maNouvellePictureBox.Location = new Point(x, y);

                                }

                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                break;
                            case " ":
                                maNouvellePictureBox = new PictureBox();

                                maNouvellePictureBox.Name = $"pic{j}{i}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                                maNouvellePictureBox.Size = new Size(10, 30);

                                if (compt1 == 0)
                                {

                                    x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 40;
                                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                    compt1 = 0;

                                }
                                else
                                {
                                    x = pnlLaby.Controls[nbPicDansPanel - 1].Location.X + 30;
                                    y = pnlLaby.Controls[nbPicDansPanel - 1].Location.Y;
                                    compt1 = 0;
                                }
                                maNouvellePictureBox.Location = new Point(x, y);
                                pnlLaby.Controls.Add(maNouvellePictureBox);
                                pnlLaby.ResumeLayout();
                                
                                break;
                            case "esp":
                                compt2++;

                                break;

                        }
                    }


                }
            }
        }

        private void FormJeuStyx_Load(object sender, EventArgs e)
        {

        }
    }
}