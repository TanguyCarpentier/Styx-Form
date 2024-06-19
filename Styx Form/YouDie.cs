﻿using System;
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
    public partial class YouDie : Form
    {
        public YouDie()
        {
            InitializeComponen();
        }

        private void InitializeComponen()
        {
            this.BackgroundImage = Properties.Resources.You_died; // Assurez-vous d'ajouter une image GameOverBackground dans vos ressources
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.None;

            Button btnReturnToMenu = new Button();
            btnReturnToMenu.Text = "Retour au menu principal";
            btnReturnToMenu.Size = new Size(200, 50);
            btnReturnToMenu.Location = new Point((this.ClientSize.Width - btnReturnToMenu.Width) / 2, (this.ClientSize.Height - btnReturnToMenu.Height) / 2);
            btnReturnToMenu.Click += new EventHandler(this.BtnReturnToMenu_Click);
            this.Controls.Add(btnReturnToMenu);
        }

        private void BtnReturnToMenu_Click(object sender, EventArgs e)
        {
            // Logique pour retourner au menu principal
            // Exemple:
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
