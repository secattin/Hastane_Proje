namespace Hastane_Proje
{
    partial class Hastakayıt
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
            this.txthastasifre = new System.Windows.Forms.TextBox();
            this.maskhasttc = new System.Windows.Forms.MaskedTextBox();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.maskhastatel = new System.Windows.Forms.MaskedTextBox();
            this.cmbhastacinsiyet = new System.Windows.Forms.ComboBox();
            this.btnhastakyt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txthastasifre
            // 
            this.txthastasifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txthastasifre.Location = new System.Drawing.Point(140, 259);
            this.txthastasifre.Name = "txthastasifre";
            this.txthastasifre.Size = new System.Drawing.Size(136, 36);
            this.txthastasifre.TabIndex = 9;
            // 
            // maskhasttc
            // 
            this.maskhasttc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskhasttc.Location = new System.Drawing.Point(140, 140);
            this.maskhasttc.Mask = "00000000000";
            this.maskhasttc.Name = "maskhasttc";
            this.maskhasttc.Size = new System.Drawing.Size(136, 36);
            this.maskhasttc.TabIndex = 8;
            // 
            // txthastaad
            // 
            this.txthastaad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txthastaad.Location = new System.Drawing.Point(140, 25);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(136, 36);
            this.txthastaad.TabIndex = 12;
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txthastasoyad.Location = new System.Drawing.Point(140, 78);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(136, 36);
            this.txthastasoyad.TabIndex = 14;
            // 
            // maskhastatel
            // 
            this.maskhastatel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskhastatel.Location = new System.Drawing.Point(140, 194);
            this.maskhastatel.Mask = "(999) 000-0000";
            this.maskhastatel.Name = "maskhastatel";
            this.maskhastatel.Size = new System.Drawing.Size(136, 36);
            this.maskhastatel.TabIndex = 16;
            // 
            // cmbhastacinsiyet
            // 
            this.cmbhastacinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbhastacinsiyet.FormattingEnabled = true;
            this.cmbhastacinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbhastacinsiyet.Location = new System.Drawing.Point(140, 322);
            this.cmbhastacinsiyet.Name = "cmbhastacinsiyet";
            this.cmbhastacinsiyet.Size = new System.Drawing.Size(136, 36);
            this.cmbhastacinsiyet.TabIndex = 18;
            // 
            // btnhastakyt
            // 
            this.btnhastakyt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhastakyt.BackColor = System.Drawing.Color.SlateGray;
            this.btnhastakyt.Location = new System.Drawing.Point(140, 382);
            this.btnhastakyt.Name = "btnhastakyt";
            this.btnhastakyt.Size = new System.Drawing.Size(136, 53);
            this.btnhastakyt.TabIndex = 19;
            this.btnhastakyt.Text = "kayıt Yap";
            this.btnhastakyt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "TC kimlik :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefon no:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Branş :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Hastakayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(477, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhastakyt);
            this.Controls.Add(this.cmbhastacinsiyet);
            this.Controls.Add(this.maskhastatel);
            this.Controls.Add(this.txthastasoyad);
            this.Controls.Add(this.txthastaad);
            this.Controls.Add(this.txthastasifre);
            this.Controls.Add(this.maskhasttc);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Hastakayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Hasta kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txthastasifre;
        private System.Windows.Forms.MaskedTextBox maskhasttc;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.MaskedTextBox maskhastatel;
        private System.Windows.Forms.ComboBox cmbhastacinsiyet;
        private System.Windows.Forms.Button btnhastakyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}