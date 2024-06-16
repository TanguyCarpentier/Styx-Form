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
            this.pnlLaby = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlLaby
            // 
            this.pnlLaby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLaby.Location = new System.Drawing.Point(0, 0);
            this.pnlLaby.Name = "pnlLaby";
            this.pnlLaby.Size = new System.Drawing.Size(800, 600);
            this.pnlLaby.TabIndex = 0;
            // 
            // FormJeuStyx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlLaby);
            this.Name = "FormJeuStyx";
            this.Text = "FormJeuStyx";
            this.ResumeLayout(false);
        }
    }
}