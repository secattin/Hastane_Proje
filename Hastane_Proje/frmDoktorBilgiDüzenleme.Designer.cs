namespace Hastane_Proje
{
    partial class frmDoktorBilgiDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorBilgiDüzenleme));
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskhasttc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthastasifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Location = new System.Drawing.Point(170, 82);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(147, 36);
            this.txthastasoyad.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Soyad :";
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(170, 32);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(147, 36);
            this.txthastaad.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad :";
            // 
            // maskhasttc
            // 
            this.maskhasttc.Location = new System.Drawing.Point(170, 130);
            this.maskhasttc.Mask = "00000000000";
            this.maskhasttc.Name = "maskhasttc";
            this.maskhasttc.Size = new System.Drawing.Size(147, 36);
            this.maskhasttc.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "TC Numara :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Şifre :";
            // 
            // txthastasifre
            // 
            this.txthastasifre.Location = new System.Drawing.Point(170, 217);
            this.txthastasifre.Name = "txthastasifre";
            this.txthastasifre.Size = new System.Drawing.Size(147, 36);
            this.txthastasifre.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(170, 172);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(147, 36);
            this.cmbBrans.TabIndex = 37;
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btngüncelle.Location = new System.Drawing.Point(170, 275);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(147, 53);
            this.btngüncelle.TabIndex = 38;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // frmDoktorBilgiDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(390, 368);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthastasifre);
            this.Controls.Add(this.maskhasttc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthastasoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthastaad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDoktorBilgiDüzenleme";
            this.Text = "Doktor Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frmDoktorBilgiDüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskhasttc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthastasifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btngüncelle;
    }
}