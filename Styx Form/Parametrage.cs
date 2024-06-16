  namespace Styx_Form
{
    public partial class Pseudo : Form
    {
        public Pseudo()
        {
            InitializeComponent();

        }





        private void pBCasque_Click(object sender, EventArgs e)
        {
            if (pBCasque.Image != Styx_Form.Properties.Resources.casque_on)
                pBCasque.Image = Styx_Form.Properties.Resources.casque_on;
            else
            {
                pBCasque.Image = Styx_Form.Properties.Resources.casque_off;
            }
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

        private void pBCasque_Click_1(object sender, EventArgs e)
        {

        }
    }
}