﻿namespace Styx_Form
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
            pBCasque.Location = new Point(6, 249);
            pBCasque.Margin = new Padding(3, 2, 3, 2);
            pBCasque.Name = "pBCasque";
            pBCasque.Size = new Size(74, 71);
            pBCasque.TabIndex = 0;
            pBCasque.TabStop = false;
            pBCasque.Click += pBCasque_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuitter);
            groupBox1.Controls.Add(btnScoreBoard);
            groupBox1.Controls.Add(btnJoueur);
            groupBox1.Controls.Add(pBCasque);
            groupBox1.Location = new Point(130, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(437, 320);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MenuPrincipal";
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(129, 215);
            btnQuitter.Margin = new Padding(3, 2, 3, 2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(193, 38);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += button3_Click;
            // 
            // btnScoreBoard
            // 
            btnScoreBoard.Location = new Point(129, 154);
            btnScoreBoard.Margin = new Padding(3, 2, 3, 2);
            btnScoreBoard.Name = "btnScoreBoard";
            btnScoreBoard.Size = new Size(193, 38);
            btnScoreBoard.TabIndex = 2;
            btnScoreBoard.Text = "ScoreBoard";
            btnScoreBoard.UseVisualStyleBackColor = true;
            btnScoreBoard.Click += btnScoreBoard_Click;
            // 
            // btnJoueur
            // 
            btnJoueur.Location = new Point(129, 94);
            btnJoueur.Margin = new Padding(3, 2, 3, 2);
            btnJoueur.Name = "btnJoueur";
            btnJoueur.Size = new Size(193, 38);
            btnJoueur.TabIndex = 1;
            btnJoueur.Text = "Jouer";
            btnJoueur.UseVisualStyleBackColor = true;
            btnJoueur.Click += btnJoueur_Click;
            // 
            // Pseudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pseudo";
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
