namespace StampaEtichetteZebraZT411
{
    partial class FormStampaEtichette
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStampaEtichette));
            this.cmbEtichette = new System.Windows.Forms.ComboBox();
            this.lblElenco = new System.Windows.Forms.Label();
            this.txtCodiceCorrispondente = new System.Windows.Forms.TextBox();
            this.txtStagione = new System.Windows.Forms.TextBox();
            this.txtGenere = new System.Windows.Forms.TextBox();
            this.txtPrezzoVendita = new System.Windows.Forms.TextBox();
            this.txtNumeroEtichette = new System.Windows.Forms.TextBox();
            this.btnStampaEtichetta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtTipologia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEtichette
            // 
            this.cmbEtichette.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEtichette.FormattingEnabled = true;
            this.cmbEtichette.Location = new System.Drawing.Point(27, 230);
            this.cmbEtichette.Name = "cmbEtichette";
            this.cmbEtichette.Size = new System.Drawing.Size(435, 44);
            this.cmbEtichette.TabIndex = 0;
            this.cmbEtichette.SelectedIndexChanged += new System.EventHandler(this.cmbEtichette_SelectedIndexChanged_1);
            // 
            // lblElenco
            // 
            this.lblElenco.AutoSize = true;
            this.lblElenco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElenco.Location = new System.Drawing.Point(24, 191);
            this.lblElenco.Name = "lblElenco";
            this.lblElenco.Size = new System.Drawing.Size(246, 36);
            this.lblElenco.TabIndex = 1;
            this.lblElenco.Text = "Elenco Etichette";
            // 
            // txtCodiceCorrispondente
            // 
            this.txtCodiceCorrispondente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodiceCorrispondente.Location = new System.Drawing.Point(527, 230);
            this.txtCodiceCorrispondente.Name = "txtCodiceCorrispondente";
            this.txtCodiceCorrispondente.Size = new System.Drawing.Size(234, 41);
            this.txtCodiceCorrispondente.TabIndex = 1;
            // 
            // txtStagione
            // 
            this.txtStagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStagione.Location = new System.Drawing.Point(30, 323);
            this.txtStagione.Name = "txtStagione";
            this.txtStagione.Size = new System.Drawing.Size(472, 41);
            this.txtStagione.TabIndex = 2;
            // 
            // txtGenere
            // 
            this.txtGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenere.Location = new System.Drawing.Point(33, 502);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.Size = new System.Drawing.Size(469, 41);
            this.txtGenere.TabIndex = 5;
            // 
            // txtPrezzoVendita
            // 
            this.txtPrezzoVendita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezzoVendita.Location = new System.Drawing.Point(33, 600);
            this.txtPrezzoVendita.Name = "txtPrezzoVendita";
            this.txtPrezzoVendita.Size = new System.Drawing.Size(223, 41);
            this.txtPrezzoVendita.TabIndex = 6;
            // 
            // txtNumeroEtichette
            // 
            this.txtNumeroEtichette.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEtichette.Location = new System.Drawing.Point(527, 600);
            this.txtNumeroEtichette.Name = "txtNumeroEtichette";
            this.txtNumeroEtichette.Size = new System.Drawing.Size(234, 41);
            this.txtNumeroEtichette.TabIndex = 7;
            // 
            // btnStampaEtichetta
            // 
            this.btnStampaEtichetta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStampaEtichetta.FlatAppearance.BorderSize = 3;
            this.btnStampaEtichetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampaEtichetta.Location = new System.Drawing.Point(316, 679);
            this.btnStampaEtichetta.Name = "btnStampaEtichetta";
            this.btnStampaEtichetta.Size = new System.Drawing.Size(404, 155);
            this.btnStampaEtichetta.TabIndex = 9;
            this.btnStampaEtichetta.Text = "STAMPA ETICHETTE";
            this.btnStampaEtichetta.UseVisualStyleBackColor = false;
            this.btnStampaEtichetta.Click += new System.EventHandler(this.btnStampaEtichetta_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 159);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(521, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = "Codice corrispondente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stagione";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(527, 410);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(469, 41);
            this.txtBarcode.TabIndex = 4;
            // 
            // txtTipologia
            // 
            this.txtTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipologia.Location = new System.Drawing.Point(30, 410);
            this.txtTipologia.Name = "txtTipologia";
            this.txtTipologia.Size = new System.Drawing.Size(472, 41);
            this.txtTipologia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipologia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "Genere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pz. vendita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nr. etichette";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-89, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(644, 62);
            this.label7.TabIndex = 1;
            this.label7.Text = "GONZATO CALZATURE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 62);
            this.label8.TabIndex = 2;
            this.label8.Text = "Stampa etichette";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormStampaEtichette
            // 
            this.ClientSize = new System.Drawing.Size(1031, 891);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbEtichette);
            this.Controls.Add(this.lblElenco);
            this.Controls.Add(this.txtCodiceCorrispondente);
            this.Controls.Add(this.txtStagione);
            this.Controls.Add(this.txtTipologia);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtGenere);
            this.Controls.Add(this.txtPrezzoVendita);
            this.Controls.Add(this.txtNumeroEtichette);
            this.Controls.Add(this.btnStampaEtichetta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStampaEtichette";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gonzato - Stampa Etichette Zebra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbEtichette;
        private System.Windows.Forms.Label lblElenco;
        private System.Windows.Forms.TextBox txtCodiceCorrispondente;
        private System.Windows.Forms.TextBox txtStagione;
        private System.Windows.Forms.TextBox txtGenere;
        private System.Windows.Forms.TextBox txtPrezzoVendita;
        private System.Windows.Forms.TextBox txtNumeroEtichette;
        private System.Windows.Forms.Button btnStampaEtichetta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtTipologia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
