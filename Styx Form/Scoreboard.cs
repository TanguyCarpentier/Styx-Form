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
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }


        private void Scoreboard_Load(object sender, EventArgs e)
        {

        }

        private void RETOUR_Click(object sender, EventArgs e)
        {
            Pseudo Param = new Pseudo();
            Param.Show();
            this.Hide();
        }
    }
}
