namespace WindowsFormsAppEFDBFirst
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.ProductName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(21, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(14, 16);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "0";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(21, 211);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(122, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(21, 153);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(122, 22);
            this.txtStock.TabIndex = 6;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(18, 134);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(76, 16);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stok Miktarı";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(21, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 22);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Ürün Fiyatı";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(21, 65);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(122, 22);
            this.txtUrunAdi.TabIndex = 2;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(18, 46);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(58, 16);
            this.ProductName.TabIndex = 1;
            this.ProductName.Text = "Ürün Adı";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(178, 44);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(668, 394);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(178, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(668, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 448);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ürün Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

