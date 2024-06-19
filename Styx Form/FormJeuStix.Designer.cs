namespace Styx_Form
{
    partial class FormJeuStyx
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLaby;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeuStyx));
            pnlLaby = new Panel();
            lblPseudoJoueur = new Label();
            lblNbVie = new Label();
            SuspendLayout();
            // 
            // pnlLaby
            // 
            pnlLaby.Anchor = AnchorStyles.None;
            pnlLaby.AutoSize = true;
            pnlLaby.Location = new Point(330, 0);
            pnlLaby.Margin = new Padding(3, 4, 3, 4);
            pnlLaby.Name = "pnlLaby";
            pnlLaby.Size = new Size(800, 749);
            pnlLaby.TabIndex = 0;
            // 
            // lblPseudoJoueur
            // 
            lblPseudoJoueur.AutoSize = true;
            lblPseudoJoueur.BackColor = Color.SandyBrown;
            lblPseudoJoueur.Location = new Point(76, 552);
            lblPseudoJoueur.Name = "lblPseudoJoueur";
            lblPseudoJoueur.Size = new Size(132, 20);
            lblPseudoJoueur.TabIndex = 1;
            lblPseudoJoueur.Text = "Pseudo du Joueur :";
            // 
            // lblNbVie
            // 
            lblNbVie.AutoSize = true;
            lblNbVie.BackColor = Color.SandyBrown;
            lblNbVie.Location = new Point(76, 591);
            lblNbVie.Name = "lblNbVie";
            lblNbVie.Size = new Size(117, 20);
            lblNbVie.TabIndex = 2;
            lblNbVie.Text = "Nombre de Vie: ";
            // 
            // FormJeuStyx
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1461, 749);
            Controls.Add(lblNbVie);
            Controls.Add(lblPseudoJoueur);
            Controls.Add(pnlLaby);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormJeuStyx";
            Text = "FormJeuStyx";
            Load += FormJeuStyx_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPseudoJoueur;
        private Label lblNbVie;
    }
}