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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pseudo));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pb_son = new PictureBox();
            pb_soncoupe = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_son).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_soncoupe).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(224, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 153);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnJoueur_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(224, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 153);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnScoreBoard_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(224, 213);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(258, 153);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += btnClick;
            // 
            // pb_son
            // 
            pb_son.BackColor = Color.Transparent;
            pb_son.BackgroundImage = (Image)resources.GetObject("pb_son.BackgroundImage");
            pb_son.BackgroundImageLayout = ImageLayout.Stretch;
            pb_son.Location = new Point(568, 255);
            pb_son.Name = "pb_son";
            pb_son.Size = new Size(77, 55);
            pb_son.TabIndex = 11;
            pb_son.TabStop = false;
            pb_son.Click += pb_son_Click;
            // 
            // pb_soncoupe
            // 
            pb_soncoupe.BackColor = Color.Transparent;
            pb_soncoupe.BackgroundImage = (Image)resources.GetObject("pb_soncoupe.BackgroundImage");
            pb_soncoupe.BackgroundImageLayout = ImageLayout.Stretch;
            pb_soncoupe.Location = new Point(568, 255);
            pb_soncoupe.Name = "pb_soncoupe";
            pb_soncoupe.Size = new Size(77, 55);
            pb_soncoupe.TabIndex = 12;
            pb_soncoupe.TabStop = false;
            pb_soncoupe.Click += pb_soncoupe_Click;
            // 
            // Pseudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pb_son);
            Controls.Add(pb_soncoupe);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pseudo";
            Text = "Parametrage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_son).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_soncoupe).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pb_son;
        private PictureBox pb_soncoupe;
    }
}
