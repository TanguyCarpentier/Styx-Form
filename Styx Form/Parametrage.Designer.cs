namespace Styx_Form
{
    partial class Pseudo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pBCasque = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            btnQuitter = new Button();
            btnScoreBoard = new Button();
            btnJoueur = new Button();
            ((System.ComponentModel.ISupportInitialize)pBCasque).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pBCasque
            // 
            pBCasque.Image = Properties.Resources.casque_off;
            pBCasque.Location = new Point(17, 337);
            pBCasque.Name = "pBCasque";
            pBCasque.Size = new Size(74, 72);
            pBCasque.TabIndex = 0;
            pBCasque.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuitter);
            groupBox1.Controls.Add(btnScoreBoard);
            groupBox1.Controls.Add(btnJoueur);
            groupBox1.Controls.Add(pBCasque);
            groupBox1.Location = new Point(171, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MenuPrincipal";
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(147, 287);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(221, 51);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += button3_Click;
            // 
            // btnScoreBoard
            // 
            btnScoreBoard.Location = new Point(147, 205);
            btnScoreBoard.Name = "btnScoreBoard";
            btnScoreBoard.Size = new Size(221, 51);
            btnScoreBoard.TabIndex = 2;
            btnScoreBoard.Text = "ScoreBoard";
            btnScoreBoard.UseVisualStyleBackColor = true;
            // 
            // btnJoueur
            // 
            btnJoueur.Location = new Point(147, 126);
            btnJoueur.Name = "btnJoueur";
            btnJoueur.Size = new Size(221, 51);
            btnJoueur.TabIndex = 1;
            btnJoueur.Text = "Jouer";
            btnJoueur.UseVisualStyleBackColor = true;
            btnJoueur.Click += btnJoueur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Parametrage";
            ((System.ComponentModel.ISupportInitialize)pBCasque).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBCasque;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button btnJoueur;
        private Button btnQuitter;
        private Button btnScoreBoard;
    }
}
