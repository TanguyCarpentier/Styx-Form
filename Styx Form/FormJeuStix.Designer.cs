namespace Styx_Form
{
    partial class FormJeuStyx
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLaby;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeuStyx));
            pnlLaby = new Panel();
            paramètre = new Button();
            SuspendLayout();
            // 
            // pnlLaby
            // 
            pnlLaby.Anchor = AnchorStyles.None;
            pnlLaby.AutoSize = true;
            pnlLaby.Location = new Point(289, 0);
            pnlLaby.Name = "pnlLaby";
            pnlLaby.Size = new Size(700, 562);
            pnlLaby.TabIndex = 0;
            
            // 
            // paramètre
            // 
            paramètre.Location = new Point(1191, 12);
            paramètre.Name = "paramètre";
            paramètre.Size = new Size(75, 23);
            paramètre.TabIndex = 1;
            paramètre.Text = "paramètre";
            paramètre.UseVisualStyleBackColor = true;
            paramètre.Click += paramètre_Click;
            // 
            // FormJeuStyx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 562);
            Controls.Add(paramètre);
            Controls.Add(pnlLaby);
            DoubleBuffered = true;
            Name = "FormJeuStyx";
            Text = "FormJeuStyx";
            
            ResumeLayout(false);
            PerformLayout();
        }

        private Button paramètre;
    }
}