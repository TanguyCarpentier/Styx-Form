namespace Styx_Form
{
    partial class SelectPSD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnQuit = new Button();
            btnRetour = new Button();
            txtPseudo = new TextBox();
            btnPlay = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnQuit);
            groupBox2.Controls.Add(btnRetour);
            groupBox2.Controls.Add(txtPseudo);
            groupBox2.Controls.Add(btnPlay);
            groupBox2.Location = new Point(200, 15);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(624, 533);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pseudo";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(514, 465);
            btnQuit.Margin = new Padding(4, 3, 4, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(86, 48);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quitter";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += button2_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(20, 465);
            btnRetour.Margin = new Padding(4, 3, 4, 3);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(86, 48);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += button1_Click;
            // 
            // txtPseudo
            // 
            txtPseudo.Location = new Point(184, 203);
            txtPseudo.Margin = new Padding(4, 3, 4, 3);
            txtPseudo.Name = "txtPseudo";
            txtPseudo.Size = new Size(275, 31);
            txtPseudo.TabIndex = 0;
            txtPseudo.Text = "Entrer Pseudo";
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(184, 358);
            btnPlay.Margin = new Padding(4, 3, 4, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(276, 63);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Jouer";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // SelectPSD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SelectPSD";
            Text = "SelectPSD";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnQuit;
        private Button btnRetour;
        private TextBox txtPseudo;
        private Button btnPlay;
    }
}