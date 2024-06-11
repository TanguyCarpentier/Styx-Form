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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(72, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 571);
            panel1.TabIndex = 0;
            // 
            // FormJeuStix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 617);
            Controls.Add(panel1);
            Name = "FormJeuStix";
            Text = "FormJeuStix";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}