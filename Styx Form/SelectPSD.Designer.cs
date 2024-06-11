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
            textBox1 = new TextBox();
            btnPlay = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnQuit);
            groupBox2.Controls.Add(btnRetour);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btnPlay);
            groupBox2.Location = new Point(140, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(437, 320);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pseudo";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(360, 279);
            btnQuit.Margin = new Padding(3, 2, 3, 2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(60, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quitter";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += button2_Click;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(14, 279);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(60, 29);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 122);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Entrer Pseudo";
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(129, 215);
            btnPlay.Margin = new Padding(3, 2, 3, 2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(193, 38);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Jouer";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // SelectPSD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBox1;
        private Button btnPlay;
    }
}