namespace BŠoštar___GLines
{
    partial class FormaZaPutnike
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
            this.dvgPutnici = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbZaposlenici = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPutnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(294, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(285, 20, 285, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "GLINES";
            // 
            // dvgPutnici
            // 
            this.dvgPutnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPutnici.Location = new System.Drawing.Point(12, 146);
            this.dvgPutnici.Name = "dvgPutnici";
            this.dvgPutnici.RowHeadersWidth = 51;
            this.dvgPutnici.RowTemplate.Height = 24;
            this.dvgPutnici.Size = new System.Drawing.Size(758, 224);
            this.dvgPutnici.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(177, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "VOZNI RED GRADA VARAŽDINA";
            // 
            // gumbZaposlenici
            // 
            this.gumbZaposlenici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.gumbZaposlenici.Location = new System.Drawing.Point(660, 29);
            this.gumbZaposlenici.Margin = new System.Windows.Forms.Padding(200);
            this.gumbZaposlenici.Name = "gumbZaposlenici";
            this.gumbZaposlenici.Size = new System.Drawing.Size(110, 51);
            this.gumbZaposlenici.TabIndex = 4;
            this.gumbZaposlenici.Text = "Natrag";
            this.gumbZaposlenici.UseVisualStyleBackColor = false;
            this.gumbZaposlenici.Click += new System.EventHandler(this.gumbZaposlenici_Click);
            // 
            // FormaZaPutnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(782, 382);
            this.Controls.Add(this.gumbZaposlenici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgPutnici);
            this.Controls.Add(this.label1);
            this.Name = "FormaZaPutnike";
            this.Text = "FormaZaPutnike";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPutnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgPutnici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbZaposlenici;
    }
}