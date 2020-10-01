using System.ComponentModel;

namespace GimpiesWinForms
{
    partial class ManagerMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.managerUitloggen = new System.Windows.Forms.Button();
            this.schoenenAanpassen = new System.Windows.Forms.Button();
            this.schoenenToevoegen = new System.Windows.Forms.Button();
            this.managerAfsluiten = new System.Windows.Forms.Button();
            this.schoenenVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managerUitloggen
            // 
            this.managerUitloggen.Location = new System.Drawing.Point(211, 453);
            this.managerUitloggen.Name = "managerUitloggen";
            this.managerUitloggen.Size = new System.Drawing.Size(348, 98);
            this.managerUitloggen.TabIndex = 0;
            this.managerUitloggen.Text = "Uitloggen";
            this.managerUitloggen.UseVisualStyleBackColor = true;
            this.managerUitloggen.Click += new System.EventHandler(this.button1_Click);
            // 
            // schoenenAanpassen
            // 
            this.schoenenAanpassen.Location = new System.Drawing.Point(211, 190);
            this.schoenenAanpassen.Name = "schoenenAanpassen";
            this.schoenenAanpassen.Size = new System.Drawing.Size(348, 98);
            this.schoenenAanpassen.TabIndex = 1;
            this.schoenenAanpassen.Text = "Schoenen aanpassen";
            this.schoenenAanpassen.UseVisualStyleBackColor = true;
            this.schoenenAanpassen.Click += new System.EventHandler(this.schoenenAanpassen_Click);
            // 
            // schoenenToevoegen
            // 
            this.schoenenToevoegen.Location = new System.Drawing.Point(211, 64);
            this.schoenenToevoegen.Name = "schoenenToevoegen";
            this.schoenenToevoegen.Size = new System.Drawing.Size(348, 98);
            this.schoenenToevoegen.TabIndex = 2;
            this.schoenenToevoegen.Text = "Schoenen toevoegen";
            this.schoenenToevoegen.UseVisualStyleBackColor = true;
            this.schoenenToevoegen.Click += new System.EventHandler(this.schoenenToevoegen_Click);
            // 
            // managerAfsluiten
            // 
            this.managerAfsluiten.Location = new System.Drawing.Point(211, 594);
            this.managerAfsluiten.Name = "managerAfsluiten";
            this.managerAfsluiten.Size = new System.Drawing.Size(348, 98);
            this.managerAfsluiten.TabIndex = 3;
            this.managerAfsluiten.Text = "Afsluiten";
            this.managerAfsluiten.UseVisualStyleBackColor = true;
            this.managerAfsluiten.Click += new System.EventHandler(this.button4_Click);
            // 
            // schoenenVerwijderen
            // 
            this.schoenenVerwijderen.Location = new System.Drawing.Point(211, 318);
            this.schoenenVerwijderen.Name = "schoenenVerwijderen";
            this.schoenenVerwijderen.Size = new System.Drawing.Size(348, 98);
            this.schoenenVerwijderen.TabIndex = 4;
            this.schoenenVerwijderen.Text = "Schoenen Verwijderen";
            this.schoenenVerwijderen.UseVisualStyleBackColor = true;
            this.schoenenVerwijderen.Click += new System.EventHandler(this.schoenenVerwijderen_Click);
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 778);
            this.Controls.Add(this.schoenenVerwijderen);
            this.Controls.Add(this.managerAfsluiten);
            this.Controls.Add(this.schoenenToevoegen);
            this.Controls.Add(this.schoenenAanpassen);
            this.Controls.Add(this.managerUitloggen);
            this.Name = "ManagerMainMenu";
            this.Text = "Gimpies Voorraadbeheer | Manager Home";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button schoenenAanpassen;
        private System.Windows.Forms.Button schoenenToevoegen;
        private System.Windows.Forms.Button schoenenVerwijderen;

        private System.Windows.Forms.Button managerAfsluiten;
        private System.Windows.Forms.Button managerUitloggen;

        #endregion
    }
}