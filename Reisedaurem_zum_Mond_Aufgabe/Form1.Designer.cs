namespace Reisedaurem_zum_Mond_Aufgabe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.InTagenradioButton = new System.Windows.Forms.RadioButton();
            this.InStundenradioButton = new System.Windows.Forms.RadioButton();
            this.berechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Geschwindigkeit = new System.Windows.Forms.TextBox();
            this.Ausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InTagenradioButton
            // 
            this.InTagenradioButton.AutoSize = true;
            this.InTagenradioButton.Location = new System.Drawing.Point(102, 91);
            this.InTagenradioButton.Name = "InTagenradioButton";
            this.InTagenradioButton.Size = new System.Drawing.Size(97, 24);
            this.InTagenradioButton.TabIndex = 0;
            this.InTagenradioButton.TabStop = true;
            this.InTagenradioButton.Text = "In Tagen";
            this.InTagenradioButton.UseVisualStyleBackColor = true;
            // 
            // InStundenradioButton
            // 
            this.InStundenradioButton.AutoSize = true;
            this.InStundenradioButton.Location = new System.Drawing.Point(282, 91);
            this.InStundenradioButton.Name = "InStundenradioButton";
            this.InStundenradioButton.Size = new System.Drawing.Size(113, 24);
            this.InStundenradioButton.TabIndex = 1;
            this.InStundenradioButton.TabStop = true;
            this.InStundenradioButton.Text = "In Stunden";
            this.InStundenradioButton.UseVisualStyleBackColor = true;
            this.InStundenradioButton.CheckedChanged += new System.EventHandler(this.InStundenradioButton_CheckedChanged);
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(57, 422);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(456, 63);
            this.berechnen.TabIndex = 2;
            this.berechnen.Text = "Reisedauer berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geschwindigkeit Km/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ausgabe Reisedauer";
            // 
            // Geschwindigkeit
            // 
            this.Geschwindigkeit.Location = new System.Drawing.Point(314, 223);
            this.Geschwindigkeit.Name = "Geschwindigkeit";
            this.Geschwindigkeit.Size = new System.Drawing.Size(211, 26);
            this.Geschwindigkeit.TabIndex = 4;
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(282, 537);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.Size = new System.Drawing.Size(211, 26);
            this.Ausgabe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 612);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Geschwindigkeit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.InStundenradioButton);
            this.Controls.Add(this.InTagenradioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton InTagenradioButton;
        private System.Windows.Forms.RadioButton InStundenradioButton;
        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Geschwindigkeit;
        private System.Windows.Forms.TextBox Ausgabe;
    }
}

