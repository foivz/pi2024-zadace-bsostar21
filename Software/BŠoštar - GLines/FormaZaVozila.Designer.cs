namespace BŠoštar___GLines
{
    partial class FormaZaVozila
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
            this.txtPretrazivanjeVozila = new System.Windows.Forms.TextBox();
            this.dgvVozilo = new System.Windows.Forms.DataGridView();
            this.gumbDodajVozilo = new System.Windows.Forms.Button();
            this.gumbAzurirajVozilo = new System.Windows.Forms.Button();
            this.gumbObrisiVozilo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(415, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pretraživanje:";
            // 
            // txtPretrazivanjeVozila
            // 
            this.txtPretrazivanjeVozila.Location = new System.Drawing.Point(418, 50);
            this.txtPretrazivanjeVozila.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.txtPretrazivanjeVozila.Name = "txtPretrazivanjeVozila";
            this.txtPretrazivanjeVozila.Size = new System.Drawing.Size(148, 20);
            this.txtPretrazivanjeVozila.TabIndex = 4;
            // 
            // dgvVozilo
            // 
            this.dgvVozilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilo.Location = new System.Drawing.Point(22, 100);
            this.dgvVozilo.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.dgvVozilo.Name = "dgvVozilo";
            this.dgvVozilo.RowHeadersWidth = 51;
            this.dgvVozilo.RowTemplate.Height = 24;
            this.dgvVozilo.Size = new System.Drawing.Size(543, 179);
            this.dgvVozilo.TabIndex = 5;
            // 
            // gumbDodajVozilo
            // 
            this.gumbDodajVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbDodajVozilo.ForeColor = System.Drawing.Color.Transparent;
            this.gumbDodajVozilo.Location = new System.Drawing.Point(22, 307);
            this.gumbDodajVozilo.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.gumbDodajVozilo.Name = "gumbDodajVozilo";
            this.gumbDodajVozilo.Size = new System.Drawing.Size(82, 41);
            this.gumbDodajVozilo.TabIndex = 10;
            this.gumbDodajVozilo.Text = "Dodaj";
            this.gumbDodajVozilo.UseVisualStyleBackColor = false;
            this.gumbDodajVozilo.Click += new System.EventHandler(this.gumbDodajVozilo_Click);
            // 
            // gumbAzurirajVozilo
            // 
            this.gumbAzurirajVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbAzurirajVozilo.ForeColor = System.Drawing.Color.Transparent;
            this.gumbAzurirajVozilo.Location = new System.Drawing.Point(127, 307);
            this.gumbAzurirajVozilo.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.gumbAzurirajVozilo.Name = "gumbAzurirajVozilo";
            this.gumbAzurirajVozilo.Size = new System.Drawing.Size(82, 41);
            this.gumbAzurirajVozilo.TabIndex = 11;
            this.gumbAzurirajVozilo.Text = "Ažuriraj";
            this.gumbAzurirajVozilo.UseVisualStyleBackColor = false;
            this.gumbAzurirajVozilo.Click += new System.EventHandler(this.gumbAzurirajVozilo_Click);
            // 
            // gumbObrisiVozilo
            // 
            this.gumbObrisiVozilo.BackColor = System.Drawing.Color.Black;
            this.gumbObrisiVozilo.ForeColor = System.Drawing.Color.Transparent;
            this.gumbObrisiVozilo.Location = new System.Drawing.Point(232, 307);
            this.gumbObrisiVozilo.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.gumbObrisiVozilo.Name = "gumbObrisiVozilo";
            this.gumbObrisiVozilo.Size = new System.Drawing.Size(82, 41);
            this.gumbObrisiVozilo.TabIndex = 12;
            this.gumbObrisiVozilo.Text = "Obriši";
            this.gumbObrisiVozilo.UseVisualStyleBackColor = false;
            this.gumbObrisiVozilo.Click += new System.EventHandler(this.gumbObrisiVozilo_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(482, 307);
            this.button5.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 41);
            this.button5.TabIndex = 14;
            this.button5.Text = "Natrag";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormaZaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gumbObrisiVozilo);
            this.Controls.Add(this.gumbAzurirajVozilo);
            this.Controls.Add(this.gumbDodajVozilo);
            this.Controls.Add(this.dgvVozilo);
            this.Controls.Add(this.txtPretrazivanjeVozila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaZaVozila";
            this.Text = "FormaZaVozila";
            this.Load += new System.EventHandler(this.FormaZaVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretrazivanjeVozila;
        private System.Windows.Forms.DataGridView dgvVozilo;
        private System.Windows.Forms.Button gumbDodajVozilo;
        private System.Windows.Forms.Button gumbAzurirajVozilo;
        private System.Windows.Forms.Button gumbObrisiVozilo;
        private System.Windows.Forms.Button button5;
    }
}