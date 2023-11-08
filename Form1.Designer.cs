namespace Banka_Sıra_Al___Çagıran_Vezne_Uygulaması
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
            this.textBanka = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSıra = new System.Windows.Forms.Button();
            this.buttonCagır = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVezne = new System.Windows.Forms.Label();
            this.labelSıra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listNumaralar = new System.Windows.Forms.ListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioİslem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBanka
            // 
            this.textBanka.BackColor = System.Drawing.Color.Black;
            this.textBanka.Font = new System.Drawing.Font("Stencil", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBanka.ForeColor = System.Drawing.Color.White;
            this.textBanka.Location = new System.Drawing.Point(89, 12);
            this.textBanka.Name = "textBanka";
            this.textBanka.Size = new System.Drawing.Size(212, 31);
            this.textBanka.TabIndex = 0;
            this.textBanka.Text = "          Beko  Bankasina  Hosgeldiniz";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSıra
            // 
            this.buttonSıra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSıra.Location = new System.Drawing.Point(12, 72);
            this.buttonSıra.Name = "buttonSıra";
            this.buttonSıra.Size = new System.Drawing.Size(138, 47);
            this.buttonSıra.TabIndex = 1;
            this.buttonSıra.Text = "SIRA AL";
            this.buttonSıra.UseVisualStyleBackColor = true;
            this.buttonSıra.Click += new System.EventHandler(this.buttonSıra_Click);
            // 
            // buttonCagır
            // 
            this.buttonCagır.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCagır.Location = new System.Drawing.Point(12, 141);
            this.buttonCagır.Name = "buttonCagır";
            this.buttonCagır.Size = new System.Drawing.Size(138, 47);
            this.buttonCagır.TabIndex = 2;
            this.buttonCagır.Text = "CAĞIR";
            this.buttonCagır.UseVisualStyleBackColor = true;
            this.buttonCagır.Click += new System.EventHandler(this.buttonCagır_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vezne No:";
            // 
            // labelVezne
            // 
            this.labelVezne.AutoSize = true;
            this.labelVezne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVezne.Location = new System.Drawing.Point(120, 325);
            this.labelVezne.Name = "labelVezne";
            this.labelVezne.Size = new System.Drawing.Size(23, 25);
            this.labelVezne.TabIndex = 4;
            this.labelVezne.Text = "0";
            // 
            // labelSıra
            // 
            this.labelSıra.AutoSize = true;
            this.labelSıra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSıra.Location = new System.Drawing.Point(120, 361);
            this.labelSıra.Name = "labelSıra";
            this.labelSıra.Size = new System.Drawing.Size(23, 25);
            this.labelSıra.TabIndex = 6;
            this.labelSıra.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sıra No:";
            // 
            // listNumaralar
            // 
            this.listNumaralar.FormattingEnabled = true;
            this.listNumaralar.ItemHeight = 16;
            this.listNumaralar.Location = new System.Drawing.Point(239, 245);
            this.listNumaralar.Name = "listNumaralar";
            this.listNumaralar.Size = new System.Drawing.Size(224, 244);
            this.listNumaralar.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(239, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(191, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Para Çekme - Para Yatırma";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(239, 217);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(111, 20);
            this.radioButton6.TabIndex = 9;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Kredi Başvuru";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(239, 139);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(167, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Kredi Kartı Borç Ödeme";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(239, 165);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(124, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Para Gönderme";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(239, 191);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(115, 20);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Döviz İşlemleri";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(239, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(224, 20);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hesap Açma - Kapatma İşlemleri";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioİslem
            // 
            this.radioİslem.AutoSize = true;
            this.radioİslem.Location = new System.Drawing.Point(239, 61);
            this.radioİslem.Name = "radioİslem";
            this.radioİslem.Size = new System.Drawing.Size(106, 20);
            this.radioİslem.TabIndex = 14;
            this.radioİslem.TabStop = true;
            this.radioİslem.Text = "İşlem Seçiniz";
            this.radioİslem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(475, 501);
            this.Controls.Add(this.radioİslem);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.listNumaralar);
            this.Controls.Add(this.labelSıra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVezne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCagır);
            this.Controls.Add(this.buttonSıra);
            this.Controls.Add(this.textBanka);
            this.Name = "Form1";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBanka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSıra;
        private System.Windows.Forms.Button buttonCagır;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVezne;
        private System.Windows.Forms.Label labelSıra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listNumaralar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioİslem;
    }
}

