using System;
using System.Windows.Forms;
using System.Media;

namespace Styx_Form
{
    public partial class Pseudo : Form
    {
        SoundPlayer player = new SoundPlayer(@"D:\T�l�chargements\Hell.wav");
        bool isSoundPlaying = false;

        public Pseudo()
        {
            InitializeComponent();
            player.Load();

            // D�marrer la lecture du son au d�marrage de l'application
            player.PlayLooping();
            isSoundPlaying = true;
            pb_son.Visible = false;     // Cache l'ic�ne de lecture
            pb_soncoupe.Visible = true; // Affiche l'ic�ne de pause
        }

        private void btnJoueur_Click(object sender, EventArgs e)
        {
            SelectPSD PSD = new SelectPSD();
            PSD.Show();
            this.Hide();
        }

        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            Scoreboard score = new Scoreboard();
            score.Show();
            this.Hide();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
