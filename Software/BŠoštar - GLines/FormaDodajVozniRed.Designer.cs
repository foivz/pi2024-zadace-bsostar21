namespace BŠoštar___GLines
{
    partial class FormaDodajVozniRed
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
            this.gumbDodajVozniRed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gumbOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStanicaPolaska = new System.Windows.Forms.ComboBox();
            this.cbStanicaDolaska = new System.Windows.Forms.ComboBox();
            this.dtVrijemePolaska = new System.Windows.Forms.DateTimePicker();
            this.dtVrijemeDolaska = new System.Windows.Forms.DateTimePicker();
            this.cmbDani = new System.Windows.Forms.ComboBox();
            this.cbLinija = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumbDodajVozniRed
            // 
            this.gumbDodajVozniRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gumbDodajVozniRed.ForeColor = System.Drawing.Color.Transparent;
            this.gumbDodajVozniRed.Location = new System.Drawing.Point(256, 349);
            this.gumbDodajVozniRed.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.gumbDodajVozniRed.Name = "gumbDodajVozniRed";
            this.gumbDodajVozniRed.Size = new System.Drawing.Size(82, 41);
            this.gumbDodajVozniRed.TabIndex = 51;
            this.gumbDodajVozniRed.Text = "Dodaj";
            this.gumbDodajVozniRed.UseVisualStyleBackColor = false;
            this.gumbDodajVozniRed.Click += new System.EventHandler(this.gumbDodajVozniRed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Stanica dolaska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Stanica polaska:";
            // 
            // gumbOdustani
            // 
            this.gumbOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbOdustani.ForeColor = System.Drawing.Color.Transparent;
            this.gumbOdustani.Location = new System.Drawing.Point(368, 349);
            this.gumbOdustani.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.gumbOdustani.Name = "gumbOdustani";
            this.gumbOdustani.Size = new System.Drawing.Size(82, 41);
            this.gumbOdustani.TabIndex = 46;
            this.gumbOdustani.Text = "Odustani";
            this.gumbOdustani.UseVisualStyleBackColor = false;
            this.gumbOdustani.Click += new System.EventHandler(this.gumbOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Vrijeme dolaska:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Vrijeme polaska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Dan u tjednu:";
            // 
            // cbStanicaPolaska
            // 
            this.cbStanicaPolaska.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStanicaPolaska.FormattingEnabled = true;
            this.cbStanicaPolaska.Location = new System.Drawing.Point(21, 177);
            this.cbStanicaPolaska.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStanicaPolaska.Name = "cbStanicaPolaska";
            this.cbStanicaPolaska.Size = new System.Drawing.Size(169, 21);
            this.cbStanicaPolaska.TabIndex = 54;
            // 
            // cbStanicaDolaska
            // 
            this.cbStanicaDolaska.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStanicaDolaska.FormattingEnabled = true;
            this.cbStanicaDolaska.Location = new System.Drawing.Point(21, 240);
            this.cbStanicaDolaska.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStanicaDolaska.Name = "cbStanicaDolaska";
            this.cbStanicaDolaska.Size = new System.Drawing.Size(169, 21);
            this.cbStanicaDolaska.TabIndex = 55;
            // 
            // dtVrijemePolaska
            // 
            this.dtVrijemePolaska.CustomFormat = "HH:mm";
            this.dtVrijemePolaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVrijemePolaska.Location = new System.Drawing.Point(21, 50);
            this.dtVrijemePolaska.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtVrijemePolaska.Name = "dtVrijemePolaska";
            this.dtVrijemePolaska.ShowUpDown = true;
            this.dtVrijemePolaska.Size = new System.Drawing.Size(169, 20);
            this.dtVrijemePolaska.TabIndex = 56;
            this.dtVrijemePolaska.Value = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            // 
            // dtVrijemeDolaska
            // 
            this.dtVrijemeDolaska.CustomFormat = "HH:mm";
            this.dtVrijemeDolaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVrijemeDolaska.Location = new System.Drawing.Point(21, 114);
            this.dtVrijemeDolaska.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtVrijemeDolaska.Name = "dtVrijemeDolaska";
            this.dtVrijemeDolaska.ShowUpDown = true;
            this.dtVrijemeDolaska.Size = new System.Drawing.Size(169, 20);
            this.dtVrijemeDolaska.TabIndex = 57;
            this.dtVrijemeDolaska.Value = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            // 
            // cmbDani
            // 
            this.cmbDani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDani.FormattingEnabled = true;
            this.cmbDani.Location = new System.Drawing.Point(23, 302);
            this.cmbDani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDani.Name = "cmbDani";
            this.cmbDani.Size = new System.Drawing.Size(169, 21);
            this.cmbDani.TabIndex = 58;
            // 
            // cbLinija
            // 
            this.cbLinija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinija.FormattingEnabled = true;
            this.cbLinija.Location = new System.Drawing.Point(21, 369);
            this.cbLinija.Name = "cbLinija";
            this.cbLinija.Size = new System.Drawing.Size(169, 21);
            this.cbLinija.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(20, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Linija:";
            // 
            // FormaDodajVozniRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(474, 421);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLinija);
            this.Controls.Add(this.cmbDani);
            this.Controls.Add(this.dtVrijemeDolaska);
            this.Controls.Add(this.dtVrijemePolaska);
            this.Controls.Add(this.cbStanicaDolaska);
            this.Controls.Add(this.cbStanicaPolaska);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gumbDodajVozniRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gumbOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaDodajVozniRed";
            this.Text = "FormaDodajVozniRed";
            this.Load += new System.EventHandler(this.FormaDodajVozniRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbDodajVozniRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gumbOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStanicaPolaska;
        private System.Windows.Forms.ComboBox cbStanicaDolaska;
        private System.Windows.Forms.DateTimePicker dtVrijemePolaska;
        private System.Windows.Forms.DateTimePicker dtVrijemeDolaska;
        private System.Windows.Forms.ComboBox cmbDani;
        private System.Windows.Forms.ComboBox cbLinija;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
    }
}