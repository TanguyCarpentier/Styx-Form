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
            for (int i = 0; i < 3600; i++)
            {
                PictureBox maNouvellePictureBox; //déclaration d'un nouvel objet picturebox
                int nbPicDansPanel = panel1.Controls.Count; // nombre de picturebox actuel dans le panel

                // suspension de la logique d'affichage du panel
                panel1.SuspendLayout();

                // instanciation et configuration de la nouvelle picturebox
                maNouvellePictureBox = new PictureBox();

                maNouvellePictureBox.Name = $"pic{nbPicDansPanel + 1}"; // définition du nom de la picturebox en fonction du nombre de picturebox dans le panel
                maNouvellePictureBox.Size = new Size(10, 10); //définition de la taille 
                maNouvellePictureBox.BorderStyle = BorderStyle.Fixed3D; // définition du type de bordure


                // s'il n'y a aucune picturebox dans le panel
                if (nbPicDansPanel == 0)
                {
                    // positionnement de la première picturebox en fonction de la largeur interne (ClientSize) du panel

                    maNouvellePictureBox.Location = new Point(0, 0);
                }
                else
                {
                    int x = 0, y = 0;
                    if (n == 60)
                    {
                        x = 0;
                        y = panel1.Controls[nbPicDansPanel - 1].Location.Y + 10;
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
        }
    }
}
