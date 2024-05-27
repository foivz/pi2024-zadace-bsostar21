namespace BŠoštar___GLines
{
    partial class FormaZaDodatneInformacije
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
            this.button5 = new System.Windows.Forms.Button();
            this.txtStanica = new System.Windows.Forms.TextBox();
            this.txtKasnjenje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.napomena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(648, 24);
            this.button5.Margin = new System.Windows.Forms.Padding(15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 51);
            this.button5.TabIndex = 39;
            this.button5.Text = "Natrag";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtStanica
            // 
            this.txtStanica.Location = new System.Drawing.Point(28, 62);
            this.txtStanica.Name = "txtStanica";
            this.txtStanica.ReadOnly = true;
            this.txtStanica.Size = new System.Drawing.Size(224, 22);
            this.txtStanica.TabIndex = 44;
            // 
            // txtKasnjenje
            // 
            this.txtKasnjenje.Location = new System.Drawing.Point(28, 140);
            this.txtKasnjenje.Name = "txtKasnjenje";
            this.txtKasnjenje.ReadOnly = true;
            this.txtKasnjenje.Size = new System.Drawing.Size(224, 22);
            this.txtKasnjenje.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Zadnja stanica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Kašnjenje (u minutama):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Vozilo:";
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(28, 218);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.ReadOnly = true;
            this.txtVozilo.Size = new System.Drawing.Size(224, 22);
            this.txtVozilo.TabIndex = 51;
            // 
            // napomena
            // 
            this.napomena.AutoSize = true;
            this.napomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napomena.Location = new System.Drawing.Point(24, 258);
            this.napomena.Margin = new System.Windows.Forms.Padding(15);
            this.napomena.Name = "napomena";
            this.napomena.Size = new System.Drawing.Size(109, 20);
            this.napomena.TabIndex = 52;
            this.napomena.Text = "NAPOMENA:";
            // 
            // FormaZaDodatneInformacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(782, 293);
            this.Controls.Add(this.napomena);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKasnjenje);
            this.Controls.Add(this.txtStanica);
            this.Controls.Add(this.button5);
            this.Name = "FormaZaDodatneInformacije";
            this.Text = "FormaZaDodatneInformacije";
            this.Load += new System.EventHandler(this.FormaZaDodatneInformacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtStanica;
        private System.Windows.Forms.TextBox txtKasnjenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Label napomena;
    }
}