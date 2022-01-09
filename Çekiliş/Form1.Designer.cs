namespace Çekiliş
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
            this.label1 = new System.Windows.Forms.Label();
            this.adaylarRtxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LstDgw = new System.Windows.Forms.DataGridView();
            this.baslatBtn = new System.Windows.Forms.Button();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cekilisLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LstDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çekiliş Programı";
            // 
            // adaylarRtxt
            // 
            this.adaylarRtxt.Location = new System.Drawing.Point(456, 93);
            this.adaylarRtxt.Name = "adaylarRtxt";
            this.adaylarRtxt.Size = new System.Drawing.Size(316, 478);
            this.adaylarRtxt.TabIndex = 1;
            this.adaylarRtxt.Text = "";
            this.adaylarRtxt.TextChanged += new System.EventHandler(this.adaylarRtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çekiliş Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Her satıra bir isim gelecek şekilde doldurdun";
            // 
            // LstDgw
            // 
            this.LstDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LstDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LstDgw.Location = new System.Drawing.Point(12, 206);
            this.LstDgw.Name = "LstDgw";
            this.LstDgw.RowTemplate.Height = 24;
            this.LstDgw.Size = new System.Drawing.Size(438, 365);
            this.LstDgw.TabIndex = 4;
            // 
            // baslatBtn
            // 
            this.baslatBtn.Location = new System.Drawing.Point(153, 158);
            this.baslatBtn.Name = "baslatBtn";
            this.baslatBtn.Size = new System.Drawing.Size(109, 42);
            this.baslatBtn.TabIndex = 6;
            this.baslatBtn.Text = "Başlat";
            this.baslatBtn.UseVisualStyleBackColor = true;
            this.baslatBtn.Click += new System.EventHandler(this.baslatBtn_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.Location = new System.Drawing.Point(286, 158);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(109, 42);
            this.temizleBtn.TabIndex = 7;
            this.temizleBtn.Text = "Yeni Çekiliş";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 178);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Katılan Sayısı:";
            // 
            // cekilisLbl
            // 
            this.cekilisLbl.AutoSize = true;
            this.cekilisLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekilisLbl.Location = new System.Drawing.Point(217, 88);
            this.cekilisLbl.Name = "cekilisLbl";
            this.cekilisLbl.Size = new System.Drawing.Size(28, 31);
            this.cekilisLbl.TabIndex = 10;
            this.cekilisLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.cekilisLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.baslatBtn);
            this.Controls.Add(this.LstDgw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adaylarRtxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LstDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox adaylarRtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LstDgw;
        private System.Windows.Forms.Button baslatBtn;
        private System.Windows.Forms.Button temizleBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cekilisLbl;
    }
}

