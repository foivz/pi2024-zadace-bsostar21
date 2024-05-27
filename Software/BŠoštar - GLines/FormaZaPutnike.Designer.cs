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
            this.dgvRed = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbNatrag = new System.Windows.Forms.Button();
            this.gumbKupi = new System.Windows.Forms.Button();
            this.gumbInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).BeginInit();
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
            // dgvRed
            // 
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Location = new System.Drawing.Point(12, 146);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.RowHeadersWidth = 51;
            this.dgvRed.RowTemplate.Height = 24;
            this.dgvRed.Size = new System.Drawing.Size(758, 224);
            this.dgvRed.TabIndex = 2;
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
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbNatrag.ForeColor = System.Drawing.Color.Black;
            this.gumbNatrag.Location = new System.Drawing.Point(660, 29);
            this.gumbNatrag.Margin = new System.Windows.Forms.Padding(200);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(110, 51);
            this.gumbNatrag.TabIndex = 4;
            this.gumbNatrag.Text = "Natrag";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbZaposlenici_Click);
            // 
            // gumbKupi
            // 
            this.gumbKupi.BackColor = System.Drawing.Color.Black;
            this.gumbKupi.ForeColor = System.Drawing.Color.Transparent;
            this.gumbKupi.Location = new System.Drawing.Point(12, 393);
            this.gumbKupi.Margin = new System.Windows.Forms.Padding(20);
            this.gumbKupi.Name = "gumbKupi";
            this.gumbKupi.Size = new System.Drawing.Size(110, 51);
            this.gumbKupi.TabIndex = 10;
            this.gumbKupi.Text = "Kupi kartu";
            this.gumbKupi.UseVisualStyleBackColor = false;
            // 
            // gumbInfo
            // 
            this.gumbInfo.BackColor = System.Drawing.Color.Black;
            this.gumbInfo.ForeColor = System.Drawing.Color.Transparent;
            this.gumbInfo.Location = new System.Drawing.Point(660, 393);
            this.gumbInfo.Margin = new System.Windows.Forms.Padding(20);
            this.gumbInfo.Name = "gumbInfo";
            this.gumbInfo.Size = new System.Drawing.Size(110, 51);
            this.gumbInfo.TabIndex = 11;
            this.gumbInfo.Text = "Dodatne info";
            this.gumbInfo.UseVisualStyleBackColor = false;
            // 
            // FormaZaPutnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gumbInfo);
            this.Controls.Add(this.gumbKupi);
            this.Controls.Add(this.gumbNatrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRed);
            this.Controls.Add(this.label1);
            this.Name = "FormaZaPutnike";
            this.Text = "FormaZaPutnike";
            this.Load += new System.EventHandler(this.FormaZaPutnike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbNatrag;
        private System.Windows.Forms.Button gumbKupi;
        private System.Windows.Forms.Button gumbInfo;
    }
}