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
    public partial class SelectPSD : Form
    {
        public SelectPSD()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormJeuStix formJeuStix = new FormJeuStix(txtPseudo.Text);
            formJeuStix.Show();
            this.Hide();
        }



        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pseudo Param = new Pseudo();
            Param.Show();
            this.Hide();
        }
    }
}
