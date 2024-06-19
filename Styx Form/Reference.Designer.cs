namespace Styx_Form
{
    partial class Reference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reference));
            pbRetour = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbRetour).BeginInit();
            SuspendLayout();
            // 
            // pbRetour
            // 
            pbRetour.BackColor = Color.Transparent;
            pbRetour.BackgroundImage = (Image)resources.GetObject("pbRetour.BackgroundImage");
            pbRetour.BackgroundImageLayout = ImageLayout.Stretch;
            pbRetour.Location = new Point(12, 288);
            pbRetour.Name = "pbRetour";
            pbRetour.Size = new Size(93, 54);
            pbRetour.TabIndex = 0;
            pbRetour.TabStop = false;
            pbRetour.Click += this.pbRetour_Click;
            // 
            // Reference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(pbRetour);
            DoubleBuffered = true;
            Name = "Reference";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbRetour).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbRetour;
    }
}