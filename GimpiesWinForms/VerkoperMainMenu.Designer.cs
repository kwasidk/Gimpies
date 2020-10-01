using System.ComponentModel;

namespace GimpiesWinForms
{
    partial class VerkoperMainMenu
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
            this.schoenenOverzich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoenenOverzich
            // 
            this.schoenenOverzich.Location = new System.Drawing.Point(200, 131);
            this.schoenenOverzich.Name = "schoenenOverzich";
            this.schoenenOverzich.Size = new System.Drawing.Size(334, 104);
            this.schoenenOverzich.TabIndex = 0;
            this.schoenenOverzich.Text = "button1";
            this.schoenenOverzich.UseVisualStyleBackColor = true;
            this.schoenenOverzich.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerkoperMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.schoenenOverzich);
            this.Name = "VerkoperMainMenu";
            this.Text = "VerkoperMainMenu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button schoenenOverzich;

        #endregion
    }
}