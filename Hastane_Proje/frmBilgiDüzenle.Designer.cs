namespace Hastane_Proje
{
    partial class frmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiDüzenle));
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.maskhastatel = new System.Windows.Forms.MaskedTextBox();
            this.txthastasifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbhastacinsiyet = new System.Windows.Forms.ComboBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskhasttc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txthastaad
            // 
            this.txthastaad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthastaad.Location = new System.Drawing.Point(230, 36);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(147, 36);
            this.txthastaad.TabIndex = 1;
            // 
            // maskhastatel
            // 
            this.maskhastatel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskhastatel.Location = new System.Drawing.Point(230, 210);
            this.maskhastatel.Mask = "(999) 000-0000";
            this.maskhastatel.Name = "maskhastatel";
            this.maskhastatel.Size = new System.Drawing.Size(152, 36);
            this.maskhastatel.TabIndex = 4;
            // 
            // txthastasifre
            // 
            this.txthastasifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthastasifre.Location = new System.Drawing.Point(230, 275);
            this.txthastasifre.Name = "txthastasifre";
            this.txthastasifre.Size = new System.Drawing.Size(152, 36);
            this.txthastasifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet :";
            // 
            // cmbhastacinsiyet
            // 
            this.cmbhastacinsiyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbhastacinsiyet.FormattingEnabled = true;
            this.cmbhastacinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbhastacinsiyet.Location = new System.Drawing.Point(230, 338);
            this.cmbhastacinsiyet.Name = "cmbhastacinsiyet";
            this.cmbhastacinsiyet.Size = new System.Drawing.Size(152, 36);
            this.cmbhastacinsiyet.TabIndex = 6;
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btngüncelle.Location = new System.Drawing.Point(212, 396);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(152, 53);
            this.btngüncelle.TabIndex = 32;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik Numara :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefon Numarası :";
            // 
            // maskhasttc
            // 
            this.maskhasttc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskhasttc.Location = new System.Drawing.Point(230, 156);
            this.maskhasttc.Mask = "00000000000";
            this.maskhasttc.Name = "maskhasttc";
            this.maskhasttc.Size = new System.Drawing.Size(152, 36);
            this.maskhasttc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "HastaAd :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "HastaSoyad :";
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthastasoyad.Location = new System.Drawing.Point(230, 94);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(147, 36);
            this.txthastasoyad.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbhastacinsiyet);
            this.groupBox1.Controls.Add(this.maskhasttc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txthastasifre);
            this.groupBox1.Controls.Add(this.maskhastatel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txthastaad);
            this.groupBox1.Controls.Add(this.txthastasoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 491);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLERİM";
            // 
            // frmBilgiDüzenle
            // 
            this.AcceptButton = this.btngüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(439, 505);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBilgiDüzenle";
            this.Text = "Bilgi Düzenleme";
            this.Load += new System.EventHandler(this.frmBilgiDüzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.MaskedTextBox maskhastatel;
        private System.Windows.Forms.TextBox txthastasifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbhastacinsiyet;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskhasttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}