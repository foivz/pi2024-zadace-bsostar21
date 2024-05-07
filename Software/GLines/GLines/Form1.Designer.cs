namespace GLines
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
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(192, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "GLines";
            // 
            // gumbZaposlenici
            // 
            this.gumbZaposlenici.BackColor = System.Drawing.Color.Black;
            this.gumbZaposlenici.ForeColor = System.Drawing.Color.White;
            this.gumbZaposlenici.Location = new System.Drawing.Point(186, 210);
            this.gumbZaposlenici.Name = "gumbZaposlenici";
            this.gumbZaposlenici.Size = new System.Drawing.Size(119, 48);
            this.gumbZaposlenici.TabIndex = 1;
            this.gumbZaposlenici.Text = "ZAPOSLENICI";
            this.gumbZaposlenici.UseVisualStyleBackColor = false;
            this.gumbZaposlenici.Click += new System.EventHandler(this.gumbZaposlenici_Click);
            // 
            // gumbPutnici
            // 
            this.gumbPutnici.BackColor = System.Drawing.Color.Black;
            this.gumbPutnici.ForeColor = System.Drawing.Color.White;
            this.gumbPutnici.Location = new System.Drawing.Point(495, 210);
            this.gumbPutnici.Name = "gumbPutnici";
            this.gumbPutnici.Size = new System.Drawing.Size(111, 48);
            this.gumbPutnici.TabIndex = 2;
            this.gumbPutnici.Text = "PUTNICI";
            this.gumbPutnici.UseVisualStyleBackColor = false;
            this.gumbPutnici.Click += new System.EventHandler(this.gumbPutnici_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gumbPutnici);
            this.Controls.Add(this.gumbZaposlenici);
            this.Controls.Add(this.label1);
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

