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
            pnlLaby = new Panel();
            SuspendLayout();
            // 
            // pnlLaby
            // 
            pnlLaby.Anchor = AnchorStyles.None;
            pnlLaby.AutoSize = true;
            pnlLaby.Location = new Point(0, 0);
            pnlLaby.Name = "pnlLaby";
            pnlLaby.Size = new Size(700, 562);
            pnlLaby.TabIndex = 0;
            // 
            // FormJeuStyx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(700, 562);
            Controls.Add(pnlLaby);
            Name = "FormJeuStyx";
            Text = "FormJeuStyx";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}