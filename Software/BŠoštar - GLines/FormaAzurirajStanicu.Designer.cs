﻿namespace BŠoštar___GLines
{
    partial class FormaAzurirajStanicu
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
            this.gumbOdustani = new System.Windows.Forms.Button();
            this.gumbAzurirajStanicu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresaStanice = new System.Windows.Forms.TextBox();
            this.txtNazivStanice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumbOdustani
            // 
            this.gumbOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbOdustani.ForeColor = System.Drawing.Color.Transparent;
            this.gumbOdustani.Location = new System.Drawing.Point(503, 111);
            this.gumbOdustani.Margin = new System.Windows.Forms.Padding(20);
            this.gumbOdustani.Name = "gumbOdustani";
            this.gumbOdustani.Size = new System.Drawing.Size(110, 51);
            this.gumbOdustani.TabIndex = 31;
            this.gumbOdustani.Text = "Odustani";
            this.gumbOdustani.UseVisualStyleBackColor = false;
            this.gumbOdustani.Click += new System.EventHandler(this.gumbOdustani_Click);
            // 
            // gumbAzurirajStanicu
            // 
            this.gumbAzurirajStanicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gumbAzurirajStanicu.ForeColor = System.Drawing.Color.Transparent;
            this.gumbAzurirajStanicu.Location = new System.Drawing.Point(353, 111);
            this.gumbAzurirajStanicu.Margin = new System.Windows.Forms.Padding(20);
            this.gumbAzurirajStanicu.Name = "gumbAzurirajStanicu";
            this.gumbAzurirajStanicu.Size = new System.Drawing.Size(110, 51);
            this.gumbAzurirajStanicu.TabIndex = 30;
            this.gumbAzurirajStanicu.Text = "Ažuriraj";
            this.gumbAzurirajStanicu.UseVisualStyleBackColor = false;
            this.gumbAzurirajStanicu.Click += new System.EventHandler(this.gumbAzurirajStanicu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adresa stanice:";
            // 
            // txtAdresaStanice
            // 
            this.txtAdresaStanice.Location = new System.Drawing.Point(28, 140);
            this.txtAdresaStanice.Name = "txtAdresaStanice";
            this.txtAdresaStanice.Size = new System.Drawing.Size(224, 22);
            this.txtAdresaStanice.TabIndex = 28;
            // 
            // txtNazivStanice
            // 
            this.txtNazivStanice.Location = new System.Drawing.Point(28, 62);
            this.txtNazivStanice.Name = "txtNazivStanice";
            this.txtNazivStanice.Size = new System.Drawing.Size(224, 22);
            this.txtNazivStanice.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Naziv stanice:";
            // 
            // FormaAzurirajStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(632, 183);
            this.Controls.Add(this.gumbOdustani);
            this.Controls.Add(this.gumbAzurirajStanicu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdresaStanice);
            this.Controls.Add(this.txtNazivStanice);
            this.Controls.Add(this.label1);
            this.Name = "FormaAzurirajStanicu";
            this.Text = "FormaAzurirajStanicu";
            this.Load += new System.EventHandler(this.FormaAzurirajStanicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbOdustani;
        private System.Windows.Forms.Button gumbAzurirajStanicu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresaStanice;
        private System.Windows.Forms.TextBox txtNazivStanice;
        private System.Windows.Forms.Label label1;
    }
}