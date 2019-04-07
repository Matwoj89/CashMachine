namespace SystemBankowy2
{
    partial class Form1
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
            this.TPin = new System.Windows.Forms.NumericUpDown();
            this.TNumerKarty = new System.Windows.Forms.NumericUpDown();
            this.BZaloguj = new System.Windows.Forms.Button();
            this.BStanKonta = new System.Windows.Forms.Button();
            this.BWyplata = new System.Windows.Forms.Button();
            this.BWplata = new System.Windows.Forms.Button();
            this.LZalogowany = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNumerKarty)).BeginInit();
            this.SuspendLayout();
            // 
            // TPin
            // 
            this.TPin.Location = new System.Drawing.Point(12, 12);
            this.TPin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TPin.Name = "TPin";
            this.TPin.Size = new System.Drawing.Size(176, 20);
            this.TPin.TabIndex = 0;
            this.TPin.ValueChanged += new System.EventHandler(this.TPin_ValueChanged);
            // 
            // TNumerKarty
            // 
            this.TNumerKarty.Location = new System.Drawing.Point(194, 12);
            this.TNumerKarty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TNumerKarty.Name = "TNumerKarty";
            this.TNumerKarty.Size = new System.Drawing.Size(175, 20);
            this.TNumerKarty.TabIndex = 1;
            this.TNumerKarty.ValueChanged += new System.EventHandler(this.TNumerKarty_ValueChanged);
            // 
            // BZaloguj
            // 
            this.BZaloguj.Location = new System.Drawing.Point(375, 9);
            this.BZaloguj.Name = "BZaloguj";
            this.BZaloguj.Size = new System.Drawing.Size(75, 23);
            this.BZaloguj.TabIndex = 2;
            this.BZaloguj.Text = "Zaloguj";
            this.BZaloguj.UseVisualStyleBackColor = true;
            this.BZaloguj.Click += new System.EventHandler(this.BZaloguj_Click);
            // 
            // BStanKonta
            // 
            this.BStanKonta.Location = new System.Drawing.Point(12, 62);
            this.BStanKonta.Name = "BStanKonta";
            this.BStanKonta.Size = new System.Drawing.Size(438, 23);
            this.BStanKonta.TabIndex = 3;
            this.BStanKonta.Text = "Stan konta";
            this.BStanKonta.UseVisualStyleBackColor = true;
            this.BStanKonta.Click += new System.EventHandler(this.BStanKonta_Click);
            // 
            // BWyplata
            // 
            this.BWyplata.Location = new System.Drawing.Point(12, 91);
            this.BWyplata.Name = "BWyplata";
            this.BWyplata.Size = new System.Drawing.Size(438, 23);
            this.BWyplata.TabIndex = 4;
            this.BWyplata.Text = "Wypłata";
            this.BWyplata.UseVisualStyleBackColor = true;
            this.BWyplata.Click += new System.EventHandler(this.BWyplata_Click);
            // 
            // BWplata
            // 
            this.BWplata.Location = new System.Drawing.Point(12, 120);
            this.BWplata.Name = "BWplata";
            this.BWplata.Size = new System.Drawing.Size(438, 23);
            this.BWplata.TabIndex = 5;
            this.BWplata.Text = "Wpłata";
            this.BWplata.UseVisualStyleBackColor = true;
            this.BWplata.Click += new System.EventHandler(this.BWplata_Click);
            // 
            // LZalogowany
            // 
            this.LZalogowany.AutoSize = true;
            this.LZalogowany.Location = new System.Drawing.Point(12, 266);
            this.LZalogowany.Name = "LZalogowany";
            this.LZalogowany.Size = new System.Drawing.Size(0, 13);
            this.LZalogowany.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.Controls.Add(this.LZalogowany);
            this.Controls.Add(this.BWplata);
            this.Controls.Add(this.BWyplata);
            this.Controls.Add(this.BStanKonta);
            this.Controls.Add(this.BZaloguj);
            this.Controls.Add(this.TNumerKarty);
            this.Controls.Add(this.TPin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNumerKarty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TPin;
        private System.Windows.Forms.NumericUpDown TNumerKarty;
        private System.Windows.Forms.Button BZaloguj;
        private System.Windows.Forms.Button BStanKonta;
        private System.Windows.Forms.Button BWyplata;
        private System.Windows.Forms.Button BWplata;
        private System.Windows.Forms.Label LZalogowany;
    }
}

