using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styx_Form
{
    public partial class FormJeuStix : Form
    {
        public FormJeuStix()
        {
            int n = 0;
            InitializeComponent();
            for (int j = 0; j < 41; j++)
            {
                int l = 0;
                for (int i = 0; i < 41; i++)
                {
                    if (j % 2 == 0)
                    {
                        
                        PictureBox maNouvellePictureBox; //déclaration d'un nouvel objet picturebox
                        int nbPicDansPanel = panel1.Controls.Count; // nombre de picturebox actuel dans le panel
                        if (i % 2 == 0)
                        {


                            // suspension de la logique d'affichage du panel
                            panel1.SuspendLayout();

                            // instanciation et configuration de la nouvelle picturebox
                            maNouvellePictureBox = new PictureBox();

                            maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                            maNouvellePictureBox.Size = new Size(10, 15); //définition de la taille 
                                                                          //maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D; // définition du type de bordure
                            maNouvellePictureBox.Image = Properties.Resources.murhaut1;
                        }
                        else
                        {


                            // suspension de la logique d'affichage du panel
                            panel1.SuspendLayout();

                            // instanciation et configuration de la nouvelle picturebox
                            maNouvellePictureBox = new PictureBox();

                            maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                            maNouvellePictureBox.Size = new Size(30, 15); //définition de la taille 
                                                                          //maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D; // définition du type de bordure
                            maNouvellePictureBox.Image = Properties.Resources.murhaut1;
                        }


                        // s'il n'y a aucune picturebox dans le panel
                        if (l == 0)
                        {
                            // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                            maNouvellePictureBox.Location = new Point(0, 20*j);
                            l++;
                        }
                        else
                        {
                            int x = 0, y = 0;
                            if (i % 2 == 0)
                            {

                                x = panel1.Controls[nbPicDansPanel - 1].Location.X + 30;
                                y = panel1.Controls[nbPicDansPanel - 1].Location.Y;
                                n = 0;
                            }
                            // sinon, on prend récupère la localisation X de la dernière créée et on ajoute 50 (hauteur d'1 picturebox + 10 à sa localisation Y 
                            else
                            {
                                x = panel1.Controls[nbPicDansPanel - 1].Location.X + 10;
                                y = panel1.Controls[nbPicDansPanel - 1].Location.Y;
                                n++;
                            }

                            maNouvellePictureBox.Location = new Point(x, y);

                        }
                        // ajout de la picturebox créée à la collection des contrôles du panel pour qu'elle apparaisse dans le formulaire
                        panel1.Controls.Add(maNouvellePictureBox);

                        panel1.ResumeLayout();
                    }
                    else
                    {
                        
                        PictureBox maNouvellePictureBox; //déclaration d'un nouvel objet picturebox
                        int nbPicDansPanel = panel1.Controls.Count; // nombre de picturebox actuel dans le panel
                        if (i % 2 == 0)
                        {


                            // suspension de la logique d'affichage du panel
                            panel1.SuspendLayout();

                            // instanciation et configuration de la nouvelle picturebox
                            maNouvellePictureBox = new PictureBox();

                            maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                            maNouvellePictureBox.Size = new Size(10, 25); //définition de la taille 
                                                                          //maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D; // définition du type de bordure
                            maNouvellePictureBox.Image = Properties.Resources.murhaut1;
                            if (l == 0)
                            {
                                // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                                maNouvellePictureBox.Location = new Point(0, 20 * j);
                                l++;
                            }
                            else
                            {
                                int x = 0, y = 0;
                                if (i % 2 == 0)
                                {

                                    x = panel1.Controls[nbPicDansPanel - 1].Location.X + 40;
                                    y = panel1.Controls[nbPicDansPanel - 1].Location.Y;

                                }
                                // sinon, on prend récupère la localisation X de la dernière créée et on ajoute 50 (hauteur d'1 picturebox + 10 à sa localisation Y 


                                maNouvellePictureBox.Location = new Point(x, y);

                            }
                            panel1.Controls.Add(maNouvellePictureBox);
                        }
                        


                        // s'il n'y a aucune picturebox dans le panel
                        
                        // ajout de la picturebox créée à la collection des contrôles du panel pour qu'elle apparaisse dans le formulaire
                       

                        panel1.ResumeLayout();
                    }
                }
                    
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
