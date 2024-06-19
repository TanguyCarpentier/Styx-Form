namespace Styx_Form
{
    partial class PauseJeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PauseJeu));
            pictureBox1 = new PictureBox();
            pbMenuPrincipal = new PictureBox();
            pb_son = new PictureBox();
            pb_soncoupe = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_son).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_soncoupe).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(210, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pbContinuer_Click;
            // 
            // pbMenuPrincipal
            // 
            pbMenuPrincipal.BackColor = Color.Transparent;
            pbMenuPrincipal.BackgroundImage = (Image)resources.GetObject("pbMenuPrincipal.BackgroundImage");
            pbMenuPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pbMenuPrincipal.Location = new Point(210, 143);
            pbMenuPrincipal.Name = "pbMenuPrincipal";
            pbMenuPrincipal.Size = new Size(258, 153);
            pbMenuPrincipal.TabIndex = 1;
            pbMenuPrincipal.TabStop = false;
            pbMenuPrincipal.Click += pbMenuPrincipal_Click;
            // 
            // pb_son
            // 
            pb_son.BackColor = Color.Transparent;
            pb_son.BackgroundImage = (Image)resources.GetObject("pb_son.BackgroundImage");
            pb_son.BackgroundImageLayout = ImageLayout.Stretch;
            pb_son.Location = new Point(560, 241);
            pb_son.Name = "pb_son";
            pb_son.Size = new Size(77, 55);
            pb_son.TabIndex = 12;
            pb_son.TabStop = false;
            pb_son.Click += pb_son_Click;
            // 
            // pb_soncoupe
            // 
            pb_soncoupe.BackColor = Color.Transparent;
            pb_soncoupe.BackgroundImage = (Image)resources.GetObject("pb_soncoupe.BackgroundImage");
            pb_soncoupe.BackgroundImageLayout = ImageLayout.Stretch;
            pb_soncoupe.Location = new Point(560, 241);
            pb_soncoupe.Name = "pb_soncoupe";
            pb_soncoupe.Size = new Size(77, 55);
            pb_soncoupe.TabIndex = 13;
            pb_soncoupe.TabStop = false;
            pb_soncoupe.Click += pb_soncoupe_Click;
            // 
            // PauseJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(pb_son);
            Controls.Add(pbMenuPrincipal);
            Controls.Add(pictureBox1);
            Controls.Add(pb_soncoupe);
            Name = "PauseJeu";
            Text = "PauseJeu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_son).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_soncoupe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbMenuPrincipal;
        private PictureBox pb_son;
        private PictureBox pb_soncoupe;
    }
}