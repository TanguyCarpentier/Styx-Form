namespace Styx_Form
{
    partial class Scoreboard
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
            btnJoueur = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnJoueur
            // 
            btnJoueur.Location = new Point(282, 97);
            btnJoueur.Name = "btnJoueur";
            btnJoueur.Size = new Size(221, 51);
            btnJoueur.TabIndex = 2;
            btnJoueur.Text = "Score 1";
            btnJoueur.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(282, 174);
            button1.Name = "button1";
            button1.Size = new Size(221, 51);
            button1.TabIndex = 3;
            button1.Text = "Score 2";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(282, 251);
            button2.Name = "button2";
            button2.Size = new Size(221, 51);
            button2.TabIndex = 4;
            button2.Text = "Score 3";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(63, 348);
            button3.Name = "button3";
            button3.Size = new Size(221, 51);
            button3.TabIndex = 5;
            button3.Text = "Retour";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(508, 348);
            button4.Name = "button4";
            button4.Size = new Size(221, 51);
            button4.TabIndex = 6;
            button4.Text = "Quitter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Scoreboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnJoueur);
            Name = "Scoreboard";
            Text = "Scoreboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJoueur;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}