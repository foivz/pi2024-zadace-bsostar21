namespace GLines
{
    partial class FormaDodajLiniju
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
            this.gumbDodajLiniju = new System.Windows.Forms.Button();
            this.gumbNatrag = new System.Windows.Forms.Button();
            this.txtPolaznaStanica = new System.Windows.Forms.TextBox();
            this.txtNazivStanice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdredisnaStanica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrijemePutovanja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gumbDodajLiniju
            // 
            this.gumbDodajLiniju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gumbDodajLiniju.ForeColor = System.Drawing.Color.White;
            this.gumbDodajLiniju.Location = new System.Drawing.Point(338, 178);
            this.gumbDodajLiniju.Margin = new System.Windows.Forms.Padding(15);
            this.gumbDodajLiniju.Name = "gumbDodajLiniju";
            this.gumbDodajLiniju.Size = new System.Drawing.Size(119, 48);
            this.gumbDodajLiniju.TabIndex = 33;
            this.gumbDodajLiniju.Text = "Dodaj";
            this.gumbDodajLiniju.UseVisualStyleBackColor = false;
            // 
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbNatrag.ForeColor = System.Drawing.Color.White;
            this.gumbNatrag.Location = new System.Drawing.Point(338, 252);
            this.gumbNatrag.Margin = new System.Windows.Forms.Padding(15);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(119, 48);
            this.gumbNatrag.TabIndex = 32;
            this.gumbNatrag.Text = "Odustani";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbNatrag_Click);
            // 
            // txtPolaznaStanica
            // 
            this.txtPolaznaStanica.Location = new System.Drawing.Point(27, 130);
            this.txtPolaznaStanica.Name = "txtPolaznaStanica";
            this.txtPolaznaStanica.Size = new System.Drawing.Size(181, 22);
            this.txtPolaznaStanica.TabIndex = 31;
            // 
            // txtNazivStanice
            // 
            this.txtNazivStanice.Location = new System.Drawing.Point(27, 56);
            this.txtNazivStanice.Name = "txtNazivStanice";
            this.txtNazivStanice.Size = new System.Drawing.Size(181, 22);
            this.txtNazivStanice.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Polazna stanica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Naziv: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Odredišna stanica:";
            // 
            // txtOdredisnaStanica
            // 
            this.txtOdredisnaStanica.Location = new System.Drawing.Point(27, 204);
            this.txtOdredisnaStanica.Name = "txtOdredisnaStanica";
            this.txtOdredisnaStanica.Size = new System.Drawing.Size(181, 22);
            this.txtOdredisnaStanica.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Vrijeme putovanja: ";
            // 
            // txtVrijemePutovanja
            // 
            this.txtVrijemePutovanja.Location = new System.Drawing.Point(27, 278);
            this.txtVrijemePutovanja.Name = "txtVrijemePutovanja";
            this.txtVrijemePutovanja.Size = new System.Drawing.Size(181, 22);
            this.txtVrijemePutovanja.TabIndex = 37;
            // 
            // FormaDodajLiniju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(481, 329);
            this.Controls.Add(this.txtVrijemePutovanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOdredisnaStanica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gumbDodajLiniju);
            this.Controls.Add(this.gumbNatrag);
            this.Controls.Add(this.txtPolaznaStanica);
            this.Controls.Add(this.txtNazivStanice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaDodajLiniju";
            this.Text = "FormaDodajLiniju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbDodajLiniju;
        private System.Windows.Forms.Button gumbNatrag;
        private System.Windows.Forms.TextBox txtPolaznaStanica;
        private System.Windows.Forms.TextBox txtNazivStanice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdredisnaStanica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrijemePutovanja;
    }
}