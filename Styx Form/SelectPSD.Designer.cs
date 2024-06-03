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
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            btnQuitter = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btnQuitter);
            groupBox2.Location = new Point(160, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(499, 426);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pseudo";
            // 
            // button2
            // 
            button2.Location = new Point(412, 372);
            button2.Name = "button2";
            button2.Size = new Size(68, 39);
            button2.TabIndex = 5;
            button2.Text = "Quitter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 372);
            button1.Name = "button1";
            button1.Size = new Size(68, 39);
            button1.TabIndex = 4;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Entrer Pseudo";
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(147, 287);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(221, 51);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Jouer";
            btnQuitter.UseVisualStyleBackColor = true;
            // 
            // SelectPSD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "SelectPSD";
            Text = "SelectPSD";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Button btnQuitter;
    }
}