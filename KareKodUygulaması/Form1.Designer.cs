namespace KareKodUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.karekodGetirVeOkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karekodKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_Numeric = new System.Windows.Forms.RadioButton();
            this.radio_AlphaNumeric = new System.Windows.Forms.RadioButton();
            this.radio_Byte = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KarekodCoz = new System.Windows.Forms.Button();
            this.btn_KarekodUret = new System.Windows.Forms.Button();
            this.karekod_img = new System.Windows.Forms.PictureBox();
            this.txtKareKodİcerik = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karekod_img)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karekodGetirVeOkuToolStripMenuItem,
            this.karekodKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 48);
            // 
            // karekodGetirVeOkuToolStripMenuItem
            // 
            this.karekodGetirVeOkuToolStripMenuItem.Name = "karekodGetirVeOkuToolStripMenuItem";
            this.karekodGetirVeOkuToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.karekodGetirVeOkuToolStripMenuItem.Text = "Karekod Getir ve Oku";
            this.karekodGetirVeOkuToolStripMenuItem.Click += new System.EventHandler(this.karekodGetirVeOkuToolStripMenuItem_Click);
            // 
            // karekodKaydetToolStripMenuItem
            // 
            this.karekodKaydetToolStripMenuItem.Name = "karekodKaydetToolStripMenuItem";
            this.karekodKaydetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.karekodKaydetToolStripMenuItem.Text = "Karekod Kaydet";
            this.karekodKaydetToolStripMenuItem.Click += new System.EventHandler(this.karekodKaydetToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_Numeric);
            this.groupBox1.Controls.Add(this.radio_AlphaNumeric);
            this.groupBox1.Controls.Add(this.radio_Byte);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENCODE_MODE";
            // 
            // radio_Numeric
            // 
            this.radio_Numeric.AutoSize = true;
            this.radio_Numeric.Location = new System.Drawing.Point(6, 64);
            this.radio_Numeric.Name = "radio_Numeric";
            this.radio_Numeric.Size = new System.Drawing.Size(326, 17);
            this.radio_Numeric.TabIndex = 2;
            this.radio_Numeric.TabStop = true;
            this.radio_Numeric.Text = "NUMERIC (Sayısal olarak şifrelenir. Sadece sayı kullanmalısınız.)";
            this.radio_Numeric.UseVisualStyleBackColor = true;
            // 
            // radio_AlphaNumeric
            // 
            this.radio_AlphaNumeric.AutoSize = true;
            this.radio_AlphaNumeric.Location = new System.Drawing.Point(6, 41);
            this.radio_AlphaNumeric.Name = "radio_AlphaNumeric";
            this.radio_AlphaNumeric.Size = new System.Drawing.Size(528, 17);
            this.radio_AlphaNumeric.TabIndex = 1;
            this.radio_AlphaNumeric.TabStop = true;
            this.radio_AlphaNumeric.Text = "ALPHA_NUMERIC (Alfa nümerik olarak şifrelenir.  Metin şifreleme yapılırsa geri ok" +
    "umada sadece 0 geliyor. )";
            this.radio_AlphaNumeric.UseVisualStyleBackColor = true;
            // 
            // radio_Byte
            // 
            this.radio_Byte.AutoSize = true;
            this.radio_Byte.Location = new System.Drawing.Point(6, 19);
            this.radio_Byte.Name = "radio_Byte";
            this.radio_Byte.Size = new System.Drawing.Size(293, 17);
            this.radio_Byte.TabIndex = 0;
            this.radio_Byte.TabStop = true;
            this.radio_Byte.Text = "BYTE (Byte olarak şifrelenir. Tüm karakterler desteklenir.)";
            this.radio_Byte.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOT: Boyut sınırlamaları, yukarıdaki modlara göre değişiyor.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Karakter Sayısı : 0";
            // 
            // btn_KarekodCoz
            // 
            this.btn_KarekodCoz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KarekodCoz.Location = new System.Drawing.Point(540, 338);
            this.btn_KarekodCoz.Name = "btn_KarekodCoz";
            this.btn_KarekodCoz.Size = new System.Drawing.Size(140, 35);
            this.btn_KarekodCoz.TabIndex = 11;
            this.btn_KarekodCoz.Text = "KareKod Çöz";
            this.btn_KarekodCoz.UseVisualStyleBackColor = true;
            this.btn_KarekodCoz.Click += new System.EventHandler(this.btn_KarekodCoz_Click);
            // 
            // btn_KarekodUret
            // 
            this.btn_KarekodUret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KarekodUret.Location = new System.Drawing.Point(191, 338);
            this.btn_KarekodUret.Name = "btn_KarekodUret";
            this.btn_KarekodUret.Size = new System.Drawing.Size(343, 35);
            this.btn_KarekodUret.TabIndex = 10;
            this.btn_KarekodUret.Text = "KareKod Üret";
            this.btn_KarekodUret.UseVisualStyleBackColor = true;
            this.btn_KarekodUret.Click += new System.EventHandler(this.btn_KarekodUret_Click);
            // 
            // karekod_img
            // 
            this.karekod_img.ContextMenuStrip = this.contextMenuStrip1;
            this.karekod_img.Location = new System.Drawing.Point(540, 189);
            this.karekod_img.Name = "karekod_img";
            this.karekod_img.Size = new System.Drawing.Size(140, 140);
            this.karekod_img.TabIndex = 9;
            this.karekod_img.TabStop = false;
            // 
            // txtKareKodİcerik
            // 
            this.txtKareKodİcerik.Location = new System.Drawing.Point(15, 189);
            this.txtKareKodİcerik.Multiline = true;
            this.txtKareKodİcerik.Name = "txtKareKodİcerik";
            this.txtKareKodİcerik.Size = new System.Drawing.Size(522, 140);
            this.txtKareKodİcerik.TabIndex = 8;
            this.txtKareKodİcerik.TextChanged += new System.EventHandler(this.txtKareKodİcerik_TextChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label13.ForeColor = System.Drawing.Color.Silver;
            this.Label13.Location = new System.Drawing.Point(264, 13);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(172, 20);
            this.Label13.TabIndex = 89;
            this.Label13.Text = "Karekod Uygulaması";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 387);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_KarekodCoz);
            this.Controls.Add(this.btn_KarekodUret);
            this.Controls.Add(this.karekod_img);
            this.Controls.Add(this.txtKareKodİcerik);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Karekod Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karekod_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karekodGetirVeOkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karekodKaydetToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_Numeric;
        private System.Windows.Forms.RadioButton radio_AlphaNumeric;
        private System.Windows.Forms.RadioButton radio_Byte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KarekodCoz;
        private System.Windows.Forms.Button btn_KarekodUret;
        private System.Windows.Forms.PictureBox karekod_img;
        private System.Windows.Forms.TextBox txtKareKodİcerik;
        private System.Windows.Forms.Label Label13;
    }
}

