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
            lblScore = new Label();
            lblNbVie = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLaby
            // 
            pnlLaby.Anchor = AnchorStyles.None;
            pnlLaby.AutoSize = true;
            pnlLaby.Location = new Point(568, 0);
            pnlLaby.Margin = new Padding(3, 4, 3, 4);
            pnlLaby.Name = "pnlLaby";
            pnlLaby.Size = new Size(800, 749);
            pnlLaby.TabIndex = 0;
            // 
            // lblPseudoJoueur
            // 
            lblPseudoJoueur.Anchor = AnchorStyles.None;
            lblPseudoJoueur.AutoSize = true;
            lblPseudoJoueur.BackColor = Color.FromArgb(221, 181, 118);
            lblPseudoJoueur.Location = new Point(67, 590);
            lblPseudoJoueur.Name = "lblPseudoJoueur";
            lblPseudoJoueur.Size = new Size(202, 20);
            lblPseudoJoueur.TabIndex = 0;
            lblPseudoJoueur.Text = "Pseudo du Joueur :";
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.None;
            lblScore.BackColor = Color.FromArgb(221, 181, 118);
            lblScore.Location = new Point(67, 620);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(101, 20);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score : ( Score )";
            // 
            // lblNbVie
            // 
            lblNbVie.Anchor = AnchorStyles.None;
            lblNbVie.AutoSize = true;
            lblNbVie.BackColor = Color.FromArgb(221, 181, 118);
            lblNbVie.Location = new Point(67, 653);
            lblNbVie.Name = "lblNbVie";
            lblNbVie.Size = new Size(80, 20);
            lblNbVie.TabIndex = 2;
            lblNbVie.Text = "Vie : ( Vie )";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(45, 553);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 168);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormJeuStyx
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 749);
            Controls.Add(lblPseudoJoueur);
            Controls.Add(lblNbVie);
            Controls.Add(lblScore);
            Controls.Add(pnlLaby);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormJeuStyx";
            Text = "FormJeuStyx";
            Load += FormJeuStyx_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblPseudoJoueur;
        private Label lblScore;
        private Label lblNbVie;
        private PictureBox pictureBox1;
    }
}