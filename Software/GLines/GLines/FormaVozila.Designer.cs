namespace GLines
{
    partial class FormaVozila
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
            this.gumbDodajVozilo = new System.Windows.Forms.Button();
            this.gumbAzurirajVozilo = new System.Windows.Forms.Button();
            this.gumbObrisiVozilo = new System.Windows.Forms.Button();
            this.gumbNatrag = new System.Windows.Forms.Button();
            this.dgvVozilo = new System.Windows.Forms.DataGridView();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(292, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis vozila";
            // 
            // gumbDodajVozilo
            // 
            this.gumbDodajVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbDodajVozilo.ForeColor = System.Drawing.Color.White;
            this.gumbDodajVozilo.Location = new System.Drawing.Point(24, 358);
            this.gumbDodajVozilo.Margin = new System.Windows.Forms.Padding(15);
            this.gumbDodajVozilo.Name = "gumbDodajVozilo";
            this.gumbDodajVozilo.Size = new System.Drawing.Size(119, 48);
            this.gumbDodajVozilo.TabIndex = 7;
            this.gumbDodajVozilo.Text = "Dodaj";
            this.gumbDodajVozilo.UseVisualStyleBackColor = false;
            // 
            // gumbAzurirajVozilo
            // 
            this.gumbAzurirajVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbAzurirajVozilo.ForeColor = System.Drawing.Color.White;
            this.gumbAzurirajVozilo.Location = new System.Drawing.Point(173, 358);
            this.gumbAzurirajVozilo.Margin = new System.Windows.Forms.Padding(15);
            this.gumbAzurirajVozilo.Name = "gumbAzurirajVozilo";
            this.gumbAzurirajVozilo.Size = new System.Drawing.Size(119, 48);
            this.gumbAzurirajVozilo.TabIndex = 8;
            this.gumbAzurirajVozilo.Text = "Ažuriraj";
            this.gumbAzurirajVozilo.UseVisualStyleBackColor = false;
            // 
            // gumbObrisiVozilo
            // 
            this.gumbObrisiVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbObrisiVozilo.ForeColor = System.Drawing.Color.White;
            this.gumbObrisiVozilo.Location = new System.Drawing.Point(322, 358);
            this.gumbObrisiVozilo.Margin = new System.Windows.Forms.Padding(15);
            this.gumbObrisiVozilo.Name = "gumbObrisiVozilo";
            this.gumbObrisiVozilo.Size = new System.Drawing.Size(119, 48);
            this.gumbObrisiVozilo.TabIndex = 9;
            this.gumbObrisiVozilo.Text = "Obriši";
            this.gumbObrisiVozilo.UseVisualStyleBackColor = false;
            // 
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbNatrag.ForeColor = System.Drawing.Color.White;
            this.gumbNatrag.Location = new System.Drawing.Point(657, 358);
            this.gumbNatrag.Margin = new System.Windows.Forms.Padding(15);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(119, 48);
            this.gumbNatrag.TabIndex = 10;
            this.gumbNatrag.Text = "Natrag";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbNatrag_Click);
            // 
            // dgvVozilo
            // 
            this.dgvVozilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilo.Location = new System.Drawing.Point(25, 122);
            this.dgvVozilo.Name = "dgvVozilo";
            this.dgvVozilo.RowHeadersWidth = 51;
            this.dgvVozilo.RowTemplate.Height = 24;
            this.dgvVozilo.Size = new System.Drawing.Size(751, 218);
            this.dgvVozilo.TabIndex = 11;
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(560, 43);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(216, 22);
            this.txtPretrazivanje.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pretraživanje: ";
            // 
            // FormaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.dgvVozilo);
            this.Controls.Add(this.gumbNatrag);
            this.Controls.Add(this.gumbObrisiVozilo);
            this.Controls.Add(this.gumbAzurirajVozilo);
            this.Controls.Add(this.gumbDodajVozilo);
            this.Controls.Add(this.label1);
            this.Name = "FormaVozila";
            this.Text = "FormaVozila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbDodajVozilo;
        private System.Windows.Forms.Button gumbAzurirajVozilo;
        private System.Windows.Forms.Button gumbObrisiVozilo;
        private System.Windows.Forms.Button gumbNatrag;
        private System.Windows.Forms.DataGridView dgvVozilo;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label label2;
    }
}