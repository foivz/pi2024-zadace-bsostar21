namespace GLines
{
    partial class FormaDodajStanicu
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
            this.gumbDodajStanicu = new System.Windows.Forms.Button();
            this.gumbNatrag = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNazivStanice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumbDodajStanicu
            // 
            this.gumbDodajStanicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gumbDodajStanicu.ForeColor = System.Drawing.Color.White;
            this.gumbDodajStanicu.Location = new System.Drawing.Point(338, 30);
            this.gumbDodajStanicu.Margin = new System.Windows.Forms.Padding(15);
            this.gumbDodajStanicu.Name = "gumbDodajStanicu";
            this.gumbDodajStanicu.Size = new System.Drawing.Size(119, 48);
            this.gumbDodajStanicu.TabIndex = 27;
            this.gumbDodajStanicu.Text = "Dodaj";
            this.gumbDodajStanicu.UseVisualStyleBackColor = false;
            // 
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbNatrag.ForeColor = System.Drawing.Color.White;
            this.gumbNatrag.Location = new System.Drawing.Point(338, 104);
            this.gumbNatrag.Margin = new System.Windows.Forms.Padding(15);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(119, 48);
            this.gumbNatrag.TabIndex = 26;
            this.gumbNatrag.Text = "Odustani";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbNatrag_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(27, 130);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(181, 22);
            this.txtAdresa.TabIndex = 22;
            // 
            // txtNazivStanice
            // 
            this.txtNazivStanice.Location = new System.Drawing.Point(27, 56);
            this.txtNazivStanice.Name = "txtNazivStanice";
            this.txtNazivStanice.Size = new System.Drawing.Size(181, 22);
            this.txtNazivStanice.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Adresa: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Naziv: ";
            // 
            // FormaDodajStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(481, 182);
            this.Controls.Add(this.gumbDodajStanicu);
            this.Controls.Add(this.gumbNatrag);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNazivStanice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaDodajStanicu";
            this.Text = "FormaDodajStanicu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbDodajStanicu;
        private System.Windows.Forms.Button gumbNatrag;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNazivStanice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}