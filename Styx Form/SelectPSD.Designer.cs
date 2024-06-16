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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPSD));
            txtPseudo = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ptnQuitter = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptnQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtPseudo
            // 
            txtPseudo.Location = new Point(285, 95);
            txtPseudo.Margin = new Padding(3, 2, 3, 2);
            txtPseudo.Name = "txtPseudo";
            txtPseudo.Size = new Size(157, 23);
            txtPseudo.TabIndex = 6;
            txtPseudo.Text = "Entrer Pseudo";
            txtPseudo.TextChanged += txtPseudo_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(190, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 82);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(190, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 117);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnPlay_Click;
            // 
            // ptnQuitter
            // 
            ptnQuitter.BackColor = Color.Transparent;
            ptnQuitter.BackgroundImage = (Image)resources.GetObject("ptnQuitter.BackgroundImage");
            ptnQuitter.BackgroundImageLayout = ImageLayout.Stretch;
            ptnQuitter.Location = new Point(541, 243);
            ptnQuitter.Name = "ptnQuitter";
            ptnQuitter.Size = new Size(131, 65);
            ptnQuitter.TabIndex = 12;
            ptnQuitter.TabStop = false;
            ptnQuitter.Click += ptnQuitter_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(34, 243);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(131, 65);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // SelectPSD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox3);
            Controls.Add(ptnQuitter);
            Controls.Add(pictureBox2);
            Controls.Add(txtPseudo);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SelectPSD";
            Text = "SelectPSD";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptnQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPseudo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox ptnQuitter;
        private PictureBox pictureBox3;
    }
}