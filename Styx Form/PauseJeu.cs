using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Styx_Form
{
    public partial class PauseJeu : Form
    {
        SoundPlayer player = new SoundPlayer(Styx_Form.Properties.Resources.Hell);
        bool isSoundPlaying = false;
        private Form parentForm;

        public PauseJeu(Form parent)
        {
            InitializeComponent();
            player.Load();
        

            // Démarrer la lecture du son au démarrage de l'application
            player.PlayLooping();
            isSoundPlaying = true;
            pb_son.Visible = false;     // Cache l'icône de lecture
            pb_soncoupe.Visible = true; // Affiche l'icône de pause
            parentForm = parent;
        }

        private void pbContinuer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_soncoupe_Click(object sender, EventArgs e)
        {
            if (isSoundPlaying)
            {
                player.Stop();
                isSoundPlaying = false;
                pb_soncoupe.Visible = false;  // Cache le bouton de pause
                pb_son.Visible = true;    // Affiche le bouton de lecture
            }
        }

        private void pb_son_Click(object sender, EventArgs e)
        {
            if (!isSoundPlaying)
            {
                player.PlayLooping();
                isSoundPlaying = true;
                pb_son.Visible = false;    // Cache le bouton de lecture
                pb_soncoupe.Visible = true;  // Affiche le bouton de pause
            }
            else
            {
                player.Stop();
                isSoundPlaying = false;
                pb_soncoupe.Visible = false;  // Cache le bouton de pause
                pb_son.Visible = true;    // Affiche le bouton de lecture
            }
        }

        private void pbMenuPrincipal_Click(object sender, EventArgs e)
        {


            Pseudo Param = new Pseudo();
            Param.Show();
            parentForm.Close(); // Close the parent form
            this.Close(); // Close the PauseJeu form

        }
    }
}
