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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pseudo Param = new Pseudo();
            Param.Show();
            this.Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormJeuStix formJeuStix = new FormJeuStix();
            formJeuStix.Show();
            this.Hide();
        }
    }
}
