namespace Styx_Form
{
    partial class FormJeuStix
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
            pnlLaby = new Panel();
            SuspendLayout();
            // 
            // pnlLaby
            // 
            pnlLaby.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLaby.Location = new Point(328, 81);
            pnlLaby.Margin = new Padding(4, 5, 4, 5);
            pnlLaby.Name = "pnlLaby";
            pnlLaby.Size = new Size(986, 690);
            pnlLaby.TabIndex = 0;
            // 
            // FormJeuStix
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1976, 1028);
            Controls.Add(pnlLaby);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormJeuStix";
            Text = "FormJeuStix";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLaby;
    }
}