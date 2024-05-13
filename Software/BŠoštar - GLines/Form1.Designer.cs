namespace BŠoštar___GLines
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gumbZaposlenici = new System.Windows.Forms.Button();
            this.gumbPutnici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(294, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(285, 30, 285, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "GLINES";
            // 
            // gumbZaposlenici
            // 
            this.gumbZaposlenici.BackColor = System.Drawing.Color.Black;
            this.gumbZaposlenici.ForeColor = System.Drawing.Color.Transparent;
            this.gumbZaposlenici.Location = new System.Drawing.Point(209, 176);
            this.gumbZaposlenici.Margin = new System.Windows.Forms.Padding(200);
            this.gumbZaposlenici.Name = "gumbZaposlenici";
            this.gumbZaposlenici.Size = new System.Drawing.Size(110, 51);
            this.gumbZaposlenici.TabIndex = 1;
            this.gumbZaposlenici.Text = "Zaposlenici";
            this.gumbZaposlenici.UseVisualStyleBackColor = false;
            // 
            // gumbPutnici
            // 
            this.gumbPutnici.BackColor = System.Drawing.Color.Black;
            this.gumbPutnici.ForeColor = System.Drawing.Color.Transparent;
            this.gumbPutnici.Location = new System.Drawing.Point(463, 176);
            this.gumbPutnici.Margin = new System.Windows.Forms.Padding(200);
            this.gumbPutnici.Name = "gumbPutnici";
            this.gumbPutnici.Size = new System.Drawing.Size(110, 51);
            this.gumbPutnici.TabIndex = 2;
            this.gumbPutnici.Text = "Putnici";
            this.gumbPutnici.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(782, 382);
            this.Controls.Add(this.gumbPutnici);
            this.Controls.Add(this.gumbZaposlenici);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbZaposlenici;
        private System.Windows.Forms.Button gumbPutnici;
    }
}

