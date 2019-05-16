namespace TelefonRehberi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_ad = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.label_soyad = new System.Windows.Forms.Label();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.label_telefon = new System.Windows.Forms.Label();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.buton_ekle = new System.Windows.Forms.Button();
            this.buton_sil = new System.Windows.Forms.Button();
            this.buton_guncelle = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.label_arama = new System.Windows.Forms.Label();
            this.tb_arama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ad
            // 
            resources.ApplyResources(this.label_ad, "label_ad");
            this.label_ad.Name = "label_ad";
            // 
            // tb_ad
            // 
            resources.ApplyResources(this.tb_ad, "tb_ad");
            this.tb_ad.Name = "tb_ad";
            // 
            // label_soyad
            // 
            resources.ApplyResources(this.label_soyad, "label_soyad");
            this.label_soyad.Name = "label_soyad";
            // 
            // tb_soyad
            // 
            resources.ApplyResources(this.tb_soyad, "tb_soyad");
            this.tb_soyad.Name = "tb_soyad";
            // 
            // label_telefon
            // 
            resources.ApplyResources(this.label_telefon, "label_telefon");
            this.label_telefon.Name = "label_telefon";
            // 
            // tb_telefon
            // 
            resources.ApplyResources(this.tb_telefon, "tb_telefon");
            this.tb_telefon.Name = "tb_telefon";
            // 
            // buton_ekle
            // 
            resources.ApplyResources(this.buton_ekle, "buton_ekle");
            this.buton_ekle.Name = "buton_ekle";
            this.buton_ekle.UseVisualStyleBackColor = true;
            this.buton_ekle.Click += new System.EventHandler(this.buton_ekle_Click);
            // 
            // buton_sil
            // 
            resources.ApplyResources(this.buton_sil, "buton_sil");
            this.buton_sil.Name = "buton_sil";
            this.buton_sil.UseVisualStyleBackColor = true;
            this.buton_sil.Click += new System.EventHandler(this.buton_sil_Click);
            // 
            // buton_guncelle
            // 
            resources.ApplyResources(this.buton_guncelle, "buton_guncelle");
            this.buton_guncelle.Name = "buton_guncelle";
            this.buton_guncelle.UseVisualStyleBackColor = true;
            this.buton_guncelle.Click += new System.EventHandler(this.buton_guncelle_Click);
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridview, "gridview");
            this.gridview.Name = "gridview";
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick);
            // 
            // label_arama
            // 
            resources.ApplyResources(this.label_arama, "label_arama");
            this.label_arama.Name = "label_arama";
            // 
            // tb_arama
            // 
            resources.ApplyResources(this.tb_arama, "tb_arama");
            this.tb_arama.Name = "tb_arama";
            this.tb_arama.TextChanged += new System.EventHandler(this.tb_arama_TextChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_arama);
            this.Controls.Add(this.label_arama);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.buton_guncelle);
            this.Controls.Add(this.buton_sil);
            this.Controls.Add(this.buton_ekle);
            this.Controls.Add(this.label_telefon);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.tb_ad);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.Button buton_ekle;
        private System.Windows.Forms.Button buton_sil;
        private System.Windows.Forms.Button buton_guncelle;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label_arama;
        private System.Windows.Forms.TextBox tb_arama;
    }
}

