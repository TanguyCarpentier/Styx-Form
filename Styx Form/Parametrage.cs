namespace Styx_Form
{
    public partial class Pseudo : Form
    {
        public Pseudo()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJoueur_Click(object sender, EventArgs e)
        {
            SelectPSD PSD = new SelectPSD();
            PSD.Show();
            this.Hide();
        }
    }
}
