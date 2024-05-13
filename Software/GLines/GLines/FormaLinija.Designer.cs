namespace GLines
{
    partial class FormaLinija
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.dgvLinija = new System.Windows.Forms.DataGridView();
            this.gumbNatrag = new System.Windows.Forms.Button();
            this.gumbObrisiLiniju = new System.Windows.Forms.Button();
            this.gumbAzurirajLiniju = new System.Windows.Forms.Button();
            this.gumbDodajLiniju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinija)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pretraživanje: ";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(560, 43);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(216, 22);
            this.txtPretrazivanje.TabIndex = 28;
            // 
            // dgvLinija
            // 
            this.dgvLinija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinija.Location = new System.Drawing.Point(25, 122);
            this.dgvLinija.Name = "dgvLinija";
            this.dgvLinija.RowHeadersWidth = 51;
            this.dgvLinija.RowTemplate.Height = 24;
            this.dgvLinija.Size = new System.Drawing.Size(751, 218);
            this.dgvLinija.TabIndex = 27;
            // 
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbNatrag.ForeColor = System.Drawing.Color.White;
            this.gumbNatrag.Location = new System.Drawing.Point(657, 358);
            this.gumbNatrag.Margin = new System.Windows.Forms.Padding(15);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(119, 48);
            this.gumbNatrag.TabIndex = 26;
            this.gumbNatrag.Text = "Natrag";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbNatrag_Click);
            // 
            // gumbObrisiLiniju
            // 
            this.gumbObrisiLiniju.BackColor = System.Drawing.Color.Black;
            this.gumbObrisiLiniju.ForeColor = System.Drawing.Color.White;
            this.gumbObrisiLiniju.Location = new System.Drawing.Point(322, 358);
            this.gumbObrisiLiniju.Margin = new System.Windows.Forms.Padding(15);
            this.gumbObrisiLiniju.Name = "gumbObrisiLiniju";
            this.gumbObrisiLiniju.Size = new System.Drawing.Size(119, 48);
            this.gumbObrisiLiniju.TabIndex = 25;
            this.gumbObrisiLiniju.Text = "Obriši";
            this.gumbObrisiLiniju.UseVisualStyleBackColor = false;
            // 
            // gumbAzurirajLiniju
            // 
            this.gumbAzurirajLiniju.BackColor = System.Drawing.Color.Black;
            this.gumbAzurirajLiniju.ForeColor = System.Drawing.Color.White;
            this.gumbAzurirajLiniju.Location = new System.Drawing.Point(173, 358);
            this.gumbAzurirajLiniju.Margin = new System.Windows.Forms.Padding(15);
            this.gumbAzurirajLiniju.Name = "gumbAzurirajLiniju";
            this.gumbAzurirajLiniju.Size = new System.Drawing.Size(119, 48);
            this.gumbAzurirajLiniju.TabIndex = 24;
            this.gumbAzurirajLiniju.Text = "Ažuriraj";
            this.gumbAzurirajLiniju.UseVisualStyleBackColor = false;
            this.gumbAzurirajLiniju.Click += new System.EventHandler(this.gumbAzurirajLiniju_Click);
            // 
            // gumbDodajLiniju
            // 
            this.gumbDodajLiniju.BackColor = System.Drawing.Color.Black;
            this.gumbDodajLiniju.ForeColor = System.Drawing.Color.White;
            this.gumbDodajLiniju.Location = new System.Drawing.Point(24, 358);
            this.gumbDodajLiniju.Margin = new System.Windows.Forms.Padding(15);
            this.gumbDodajLiniju.Name = "gumbDodajLiniju";
            this.gumbDodajLiniju.Size = new System.Drawing.Size(119, 48);
            this.gumbDodajLiniju.TabIndex = 23;
            this.gumbDodajLiniju.Text = "Dodaj";
            this.gumbDodajLiniju.UseVisualStyleBackColor = false;
            this.gumbDodajLiniju.Click += new System.EventHandler(this.gumbDodajLiniju_Click);
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
            this.label1.Size = new System.Drawing.Size(264, 74);
            this.label1.TabIndex = 22;
            this.label1.Text = "Popis linija";
            // 
            // FormaLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.dgvLinija);
            this.Controls.Add(this.gumbNatrag);
            this.Controls.Add(this.gumbObrisiLiniju);
            this.Controls.Add(this.gumbAzurirajLiniju);
            this.Controls.Add(this.gumbDodajLiniju);
            this.Controls.Add(this.label1);
            this.Name = "FormaLinija";
            this.Text = "FormaLinija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.DataGridView dgvLinija;
        private System.Windows.Forms.Button gumbNatrag;
        private System.Windows.Forms.Button gumbObrisiLiniju;
        private System.Windows.Forms.Button gumbAzurirajLiniju;
        private System.Windows.Forms.Button gumbDodajLiniju;
        private System.Windows.Forms.Label label1;
    }
}