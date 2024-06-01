namespace BŠoštar___GLines
{
    partial class FormaZaLiniju
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
            this.gumbObrisiLiniju = new System.Windows.Forms.Button();
            this.gumbAzurirajLiniju = new System.Windows.Forms.Button();
            this.gumbDodajLiniju = new System.Windows.Forms.Button();
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.txtPretrazivanjeLinije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(482, 307);
            this.button5.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 41);
            this.button5.TabIndex = 30;
            this.button5.Text = "Natrag";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gumbObrisiLiniju
            // 
            this.gumbObrisiLiniju.BackColor = System.Drawing.Color.Black;
            this.gumbObrisiLiniju.ForeColor = System.Drawing.Color.Transparent;
            this.gumbObrisiLiniju.Location = new System.Drawing.Point(232, 307);
            this.gumbObrisiLiniju.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.gumbObrisiLiniju.Name = "gumbObrisiLiniju";
            this.gumbObrisiLiniju.Size = new System.Drawing.Size(82, 41);
            this.gumbObrisiLiniju.TabIndex = 29;
            this.gumbObrisiLiniju.Text = "Obriši";
            this.gumbObrisiLiniju.UseVisualStyleBackColor = false;
            this.gumbObrisiLiniju.Click += new System.EventHandler(this.gumbObrisiLiniju_Click);
            // 
            // gumbAzurirajLiniju
            // 
            this.gumbAzurirajLiniju.BackColor = System.Drawing.Color.Black;
            this.gumbAzurirajLiniju.ForeColor = System.Drawing.Color.Transparent;
            this.gumbAzurirajLiniju.Location = new System.Drawing.Point(127, 307);
            this.gumbAzurirajLiniju.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.gumbAzurirajLiniju.Name = "gumbAzurirajLiniju";
            this.gumbAzurirajLiniju.Size = new System.Drawing.Size(82, 41);
            this.gumbAzurirajLiniju.TabIndex = 28;
            this.gumbAzurirajLiniju.Text = "Ažuriraj";
            this.gumbAzurirajLiniju.UseVisualStyleBackColor = false;
            this.gumbAzurirajLiniju.Click += new System.EventHandler(this.gumbAzurirajLiniju_Click);
            // 
            // gumbDodajLiniju
            // 
            this.gumbDodajLiniju.BackColor = System.Drawing.Color.Black;
            this.gumbDodajLiniju.ForeColor = System.Drawing.Color.Transparent;
            this.gumbDodajLiniju.Location = new System.Drawing.Point(22, 307);
            this.gumbDodajLiniju.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.gumbDodajLiniju.Name = "gumbDodajLiniju";
            this.gumbDodajLiniju.Size = new System.Drawing.Size(82, 41);
            this.gumbDodajLiniju.TabIndex = 27;
            this.gumbDodajLiniju.Text = "Dodaj";
            this.gumbDodajLiniju.UseVisualStyleBackColor = false;
            this.gumbDodajLiniju.Click += new System.EventHandler(this.gumbDodajLiniju_Click);
            // 
            // dgvLinije
            // 
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Location = new System.Drawing.Point(22, 100);
            this.dgvLinije.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.RowHeadersWidth = 51;
            this.dgvLinije.RowTemplate.Height = 24;
            this.dgvLinije.Size = new System.Drawing.Size(543, 179);
            this.dgvLinije.TabIndex = 26;
            // 
            // txtPretrazivanjeLinije
            // 
            this.txtPretrazivanjeLinije.Location = new System.Drawing.Point(418, 50);
            this.txtPretrazivanjeLinije.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.txtPretrazivanjeLinije.Name = "txtPretrazivanjeLinije";
            this.txtPretrazivanjeLinije.Size = new System.Drawing.Size(148, 20);
            this.txtPretrazivanjeLinije.TabIndex = 25;
            this.txtPretrazivanjeLinije.TextChanged += new System.EventHandler(this.txtPretrazivanjeLinije_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(415, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pretraživanje:";
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
            this.label1.Size = new System.Drawing.Size(202, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Popis linija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Zeleno označeni redovi predstavljaju linije koji se koriste kod voznog reda. Ne b" +
    "rišu se!";
            // 
            // FormaZaLiniju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gumbObrisiLiniju);
            this.Controls.Add(this.gumbAzurirajLiniju);
            this.Controls.Add(this.gumbDodajLiniju);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.txtPretrazivanjeLinije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaZaLiniju";
            this.Text = "FormaZaLiniju";
            this.Load += new System.EventHandler(this.FormaZaLiniju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button gumbObrisiLiniju;
        private System.Windows.Forms.Button gumbAzurirajLiniju;
        private System.Windows.Forms.Button gumbDodajLiniju;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.TextBox txtPretrazivanjeLinije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}