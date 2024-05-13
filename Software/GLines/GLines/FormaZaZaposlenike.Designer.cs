namespace GLines
{
    partial class FormaZaZaposlenike
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
            this.label2 = new System.Windows.Forms.Label();
            this.gumbVozilo = new System.Windows.Forms.Button();
            this.gumbVozniRed = new System.Windows.Forms.Button();
            this.gumbLinija = new System.Windows.Forms.Button();
            this.gumbStanica = new System.Windows.Forms.Button();
            this.gumbOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(192, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "GLines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(295, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "ZAPOSLENICI ";
            // 
            // gumbVozilo
            // 
            this.gumbVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbVozilo.ForeColor = System.Drawing.Color.White;
            this.gumbVozilo.Location = new System.Drawing.Point(24, 358);
            this.gumbVozilo.Margin = new System.Windows.Forms.Padding(15);
            this.gumbVozilo.Name = "gumbVozilo";
            this.gumbVozilo.Size = new System.Drawing.Size(119, 48);
            this.gumbVozilo.TabIndex = 6;
            this.gumbVozilo.Text = "Vozilo";
            this.gumbVozilo.UseVisualStyleBackColor = false;
            this.gumbVozilo.Click += new System.EventHandler(this.gumbVozilo_Click);
            // 
            // gumbVozniRed
            // 
            this.gumbVozniRed.BackColor = System.Drawing.Color.Black;
            this.gumbVozniRed.ForeColor = System.Drawing.Color.White;
            this.gumbVozniRed.Location = new System.Drawing.Point(471, 358);
            this.gumbVozniRed.Margin = new System.Windows.Forms.Padding(15);
            this.gumbVozniRed.Name = "gumbVozniRed";
            this.gumbVozniRed.Size = new System.Drawing.Size(119, 48);
            this.gumbVozniRed.TabIndex = 7;
            this.gumbVozniRed.Text = "Vozni red";
            this.gumbVozniRed.UseVisualStyleBackColor = false;
            // 
            // gumbLinija
            // 
            this.gumbLinija.BackColor = System.Drawing.Color.Black;
            this.gumbLinija.ForeColor = System.Drawing.Color.White;
            this.gumbLinija.Location = new System.Drawing.Point(322, 358);
            this.gumbLinija.Margin = new System.Windows.Forms.Padding(15);
            this.gumbLinija.Name = "gumbLinija";
            this.gumbLinija.Size = new System.Drawing.Size(119, 48);
            this.gumbLinija.TabIndex = 8;
            this.gumbLinija.Text = "Linija";
            this.gumbLinija.UseVisualStyleBackColor = false;
            this.gumbLinija.Click += new System.EventHandler(this.gumbLinija_Click);
            // 
            // gumbStanica
            // 
            this.gumbStanica.BackColor = System.Drawing.Color.Black;
            this.gumbStanica.ForeColor = System.Drawing.Color.White;
            this.gumbStanica.Location = new System.Drawing.Point(173, 358);
            this.gumbStanica.Margin = new System.Windows.Forms.Padding(15);
            this.gumbStanica.Name = "gumbStanica";
            this.gumbStanica.Size = new System.Drawing.Size(119, 48);
            this.gumbStanica.TabIndex = 9;
            this.gumbStanica.Text = "Stanica";
            this.gumbStanica.UseVisualStyleBackColor = false;
            this.gumbStanica.Click += new System.EventHandler(this.gumbStanica_Click);
            // 
            // gumbOdjava
            // 
            this.gumbOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbOdjava.ForeColor = System.Drawing.Color.White;
            this.gumbOdjava.Location = new System.Drawing.Point(657, 358);
            this.gumbOdjava.Margin = new System.Windows.Forms.Padding(15);
            this.gumbOdjava.Name = "gumbOdjava";
            this.gumbOdjava.Size = new System.Drawing.Size(119, 48);
            this.gumbOdjava.TabIndex = 10;
            this.gumbOdjava.Text = "Odjavi se";
            this.gumbOdjava.UseVisualStyleBackColor = false;
            this.gumbOdjava.Click += new System.EventHandler(this.gumbOdjava_Click);
            // 
            // FormaZaZaposlenike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumbOdjava);
            this.Controls.Add(this.gumbStanica);
            this.Controls.Add(this.gumbLinija);
            this.Controls.Add(this.gumbVozniRed);
            this.Controls.Add(this.gumbVozilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Name = "FormaZaZaposlenike";
            this.Text = "FormaZaZaposlenike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbVozilo;
        private System.Windows.Forms.Button gumbVozniRed;
        private System.Windows.Forms.Button gumbLinija;
        private System.Windows.Forms.Button gumbStanica;
        private System.Windows.Forms.Button gumbOdjava;
    }
}