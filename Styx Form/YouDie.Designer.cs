namespace Styx_Form
{
    partial class YouDie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouDie));
            btnReturnToMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnReturnToMenu).BeginInit();
            SuspendLayout();
            // 
            // btnReturnToMenu
            // 
            btnReturnToMenu.BackgroundImage = (Image)resources.GetObject("btnReturnToMenu.BackgroundImage");
            btnReturnToMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturnToMenu.Location = new Point(263, 291);
            btnReturnToMenu.Name = "btnReturnToMenu";
            btnReturnToMenu.Size = new Size(266, 115);
            btnReturnToMenu.TabIndex = 0;
            btnReturnToMenu.TabStop = false;
            // 
            // YouDie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturnToMenu);
            Name = "YouDie";
            Text = "YouDie";
            ((System.ComponentModel.ISupportInitialize)btnReturnToMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnReturnToMenu;
    }
}