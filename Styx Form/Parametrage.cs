  namespace Styx_Form
{
    public partial class Pseudo : Form
    {
        public Pseudo()
        {
            InitializeComponent();

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

       
        private void pb_Casque_Click(object sender, EventArgs e)
        {
            if (pb_Casque.Image != Styx_Form.Properties.Resources.son)
                pb_Casque.Image = Styx_Form.Properties.Resources.son;
            else
            {
                pb_Casque.Image = Styx_Form.Properties.Resources.son_coupé;
            }
        }
    }
}