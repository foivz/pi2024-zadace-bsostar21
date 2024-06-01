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
            this.label1.Location = new System.Drawing.Point(220, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(214, 16, 214, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "GLINES";
            // 
            // dgvRed
            // 
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Location = new System.Drawing.Point(9, 119);
            this.dgvRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.RowHeadersWidth = 51;
            this.dgvRed.RowTemplate.Height = 24;
            this.dgvRed.Size = new System.Drawing.Size(568, 182);
            this.dgvRed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(133, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "VOZNI RED GRADA VARAŽDINA";
            // 
            // gumbNatrag
            // 
            this.gumbNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbNatrag.ForeColor = System.Drawing.Color.Black;
            this.gumbNatrag.Location = new System.Drawing.Point(495, 24);
            this.gumbNatrag.Margin = new System.Windows.Forms.Padding(150, 162, 150, 162);
            this.gumbNatrag.Name = "gumbNatrag";
            this.gumbNatrag.Size = new System.Drawing.Size(82, 41);
            this.gumbNatrag.TabIndex = 4;
            this.gumbNatrag.Text = "Natrag";
            this.gumbNatrag.UseVisualStyleBackColor = false;
            this.gumbNatrag.Click += new System.EventHandler(this.gumbZaposlenici_Click);
            // 
            // gumbInfo
            // 
            this.gumbInfo.BackColor = System.Drawing.Color.Black;
            this.gumbInfo.ForeColor = System.Drawing.Color.Transparent;
            this.gumbInfo.Location = new System.Drawing.Point(495, 319);
            this.gumbInfo.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.gumbInfo.Name = "gumbInfo";
            this.gumbInfo.Size = new System.Drawing.Size(82, 41);
            this.gumbInfo.TabIndex = 11;
            this.gumbInfo.Text = "Dodatne info";
            this.gumbInfo.UseVisualStyleBackColor = false;
            this.gumbInfo.Click += new System.EventHandler(this.gumbInfo_Click);
            // 
            // FormaZaPutnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.gumbInfo);
            this.Controls.Add(this.gumbNatrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRed);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button gumbInfo;
    }
}